namespace FormLibrary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Remove = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.titre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.Language = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Remove.Enabled = false;
            this.Remove.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.Color.White;
            this.Remove.Location = new System.Drawing.Point(493, 312);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(115, 37);
            this.Remove.TabIndex = 0;
            this.Remove.Text = "Suprimer";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.DarkGray;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(153, 389);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(125, 37);
            this.Save.TabIndex = 1;
            this.Save.Text = "Enregistrer";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Edit.Enabled = false;
            this.Edit.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(493, 241);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(115, 37);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Modifier";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Abort
            // 
            this.Abort.BackColor = System.Drawing.Color.DarkGray;
            this.Abort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abort.Location = new System.Drawing.Point(322, 389);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(131, 37);
            this.Abort.TabIndex = 3;
            this.Abort.Text = "Annuler";
            this.Abort.UseVisualStyleBackColor = false;
            this.Abort.Visible = false;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.New.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.Color.White;
            this.New.Location = new System.Drawing.Point(493, 170);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(115, 37);
            this.New.TabIndex = 4;
            this.New.Text = "Nouveau";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.BackColor = System.Drawing.Color.White;
            this.titre.Font = new System.Drawing.Font("MV Boli", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.Purple;
            this.titre.Location = new System.Drawing.Point(135, 21);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(424, 52);
            this.titre.TabIndex = 5;
            this.titre.Text = "Bibliothéque Scolaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categorie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Auteur:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Langue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantité:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Selectionner:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DarkGray;
            this.comboBox1.DisplayMember = "Nom";
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(311, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "Id";
            // 
            // Category
            // 
            this.Category.Enabled = false;
            this.Category.Location = new System.Drawing.Point(144, 202);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(265, 20);
            this.Category.TabIndex = 13;
            // 
            // Author
            // 
            this.Author.Enabled = false;
            this.Author.Location = new System.Drawing.Point(144, 244);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(265, 20);
            this.Author.TabIndex = 14;
            // 
            // Language
            // 
            this.Language.Enabled = false;
            this.Language.Location = new System.Drawing.Point(144, 286);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(265, 20);
            this.Language.TabIndex = 15;
            // 
            // Quantity
            // 
            this.Quantity.Enabled = false;
            this.Quantity.Location = new System.Drawing.Point(144, 328);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(265, 20);
            this.Quantity.TabIndex = 16;
            // 
            // Name
            // 
            this.Name.Enabled = false;
            this.Name.Location = new System.Drawing.Point(144, 160);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(265, 20);
            this.Name.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 467);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Abort);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Remove);
            //this.Name = "Form1";
            this.Text = "FormLibrary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Abort;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox Language;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Name;
      
    }
}

