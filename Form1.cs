using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormLibrary
{

    public partial class Form1 : Form
    {
        private static string chaine = @"Data Source=DESKTOP-F8JEVTP\SQLDEVELOPPER;Initial Catalog=SchoolLibrary;Integrated Security=True";
        private static SqlConnection cnx = new SqlConnection(chaine);
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        private TextBox[] textBoxes;
        private string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxes = new TextBox[] { Name, Category, Author, Language, Quantity };
            updatecombobox();
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);


        }
        private void updatecombobox()
        {
            try
            {
                cnx.Open();
                cmd.CommandText = "SELECT Id, Nom FROM Library";
                cmd.Connection = cnx;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1   .ValueMember = "Id";
                comboBox1.DisplayMember = "Nom";
                comboBox1.SelectedIndex = -1;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedItem = comboBox1.SelectedItem as DataRowView;

            if (selectedItem == null)
            {
                return;

            }


            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }


            int Id = (int)selectedItem.Row[0];
            cnx.Open();
            cmd.CommandText = "SELECT * FROM Library WHERE Id='" + Id + "'";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cnx.Close();
            DataRow row = dt.Rows[0];
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Enabled = true;
                textBoxes[i].ReadOnly = true;
                textBoxes[i].Text = row[i + 1].ToString();
            }
            Affichage();
            
    

        }


        private void New_Click(object sender, EventArgs e)
        {
            Ajout();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Text = textBoxes[i].Text.Trim();
                if (textBoxes[i].Text == "")
                {
                    MessageBox.Show("Veuillez remplir tout les champs");
                    return;
                }
            }
            switch (operation)
            {
                case "ajout":
                   

                        cnx.Open();
                        cmd.Connection = cnx;
                        cmd.CommandText = "insert into Library(Nom,Categorie,Auteur,Langue,Quantité) values('" + textBoxes[0].Text + "','" + textBoxes[1].Text + "','" + textBoxes[2].Text + "','" + textBoxes[3].Text + "','" + textBoxes[4].Text + "') ";
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                        updatecombobox();
                        Selection();
                        comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                    break;
                case "modification":
                     DataRowView selectedItem = comboBox1.SelectedItem as DataRowView;
                        int id = (int)selectedItem.Row[0];
                        cnx.Open();
                        cmd.Connection = cnx;
                        cmd.CommandText = "UPDATE Library SET" +
                            " Nom = '" + textBoxes[0].Text.Trim() +
                            "', Categorie = '" + textBoxes[1].Text.Trim() +
                            "', Auteur  = '" + textBoxes[2].Text.Trim() +
                            "', Langue = '" + textBoxes[3].Text.Trim() +
                            "', Quantité = '" + textBoxes[4].Text.Trim() +
                            "' WHERE Id='" + id + "';";
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                        updatecombobox();
                        Selection();
                        comboBox1.SelectedValue = id;

                    break;
                default:
                    break;
            }

               

            //}
            //else
            //{
            //    MessageBox.Show("Veuiller remplir tout les champs!");
            //}


        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Modification();
        }

        private void Abort_Click(object sender, EventArgs e)
        {
            
                    comboBox1.SelectedIndex = -1;
                    Selection();
                    
            
        }
       
        private void Ajout()
        {
            operation = "ajout";
            comboBox1.Enabled = false;
            New.Enabled = false;
            Edit.Enabled = false;
            Remove.Enabled = false;
            Save.Visible = true;
            Abort.Visible = true;

            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Text = string.Empty;
                textBoxes[i].Enabled = true;
                textBoxes[i].ReadOnly = false;
            }
        }

        private void Modification()
        {
            operation = "Modification";
            comboBox1.Enabled = true;
            New.Enabled = false;
            Edit.Enabled = false;
            Remove.Enabled = true;
            Save.Visible = true;
            Abort.Visible = true;

            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Enabled = true;
                textBoxes[i].ReadOnly = false;

            }
        }

        private void Selection()
        {
            operation = "selection";
            comboBox1.Enabled = true;
            New.Enabled = true;
            Edit.Enabled = false;
            Remove.Enabled = false;
            Save.Visible = false;
            Abort.Visible = false;

            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Text = string.Empty;
                textBoxes[i].Enabled = false;
                textBoxes[i].ReadOnly = true;

            }
        }

        private void Affichage()
        {
            operation = "Affichage";
            comboBox1.Enabled = true;
            New.Enabled = true;
            Edit.Enabled = true;
            Remove.Enabled= true;
            Save.Visible = false;
            Abort.Visible= false;

            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Enabled = true;
                textBoxes[i].ReadOnly = true;

            }

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("vous etes sur?!", "AAlleerrtte!", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                DataRowView selectedItem = comboBox1.SelectedItem as DataRowView;
                int id = (int)selectedItem.Row[0];
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "DELETE FROM Library WHERE Id='" + id + "';";
                cmd.ExecuteNonQuery();
                cnx.Close();
                updatecombobox();
                Selection();
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                comboBox1.SelectedIndex = -1;
                Selection();
            }
        }
    }
}
