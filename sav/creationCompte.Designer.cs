namespace sav
{
    partial class creationCompte
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            cboGenre = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtEmail = new TextBox();
            txtUtilisateur = new TextBox();
            txtMDP = new TextBox();
            txtConf = new TextBox();
            btnCreer = new Button();
            btnretour = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(222, 73);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(222, 112);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 1;
            label2.Text = "Prenom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(222, 150);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 2;
            label3.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(222, 193);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 3;
            label4.Text = "Date de naissance";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(222, 229);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(226, 272);
            label6.Name = "label6";
            label6.Size = new Size(136, 21);
            label6.TabIndex = 5;
            label6.Text = "Nom d'utilisateur";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(228, 310);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 6;
            label7.Text = "Mot de passe";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(154, 349);
            label8.Name = "label8";
            label8.Size = new Size(208, 21);
            label8.TabIndex = 7;
            label8.Text = "Confirmation mot de passe";
            label8.Click += label8_Click;
            // 
            // txtNom
            // 
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.Location = new Point(391, 73);
            txtNom.MaxLength = 30;
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(208, 23);
            txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            txtPrenom.BorderStyle = BorderStyle.FixedSingle;
            txtPrenom.Location = new Point(391, 115);
            txtPrenom.MaxLength = 30;
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(208, 23);
            txtPrenom.TabIndex = 1;
            // 
            // cboGenre
            // 
            cboGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenre.FormattingEnabled = true;
            cboGenre.Location = new Point(391, 152);
            cboGenre.Name = "cboGenre";
            cboGenre.Size = new Size(208, 23);
            cboGenre.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(391, 193);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(391, 232);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtUtilisateur
            // 
            txtUtilisateur.BorderStyle = BorderStyle.FixedSingle;
            txtUtilisateur.Location = new Point(391, 272);
            txtUtilisateur.MaxLength = 50;
            txtUtilisateur.Name = "txtUtilisateur";
            txtUtilisateur.Size = new Size(208, 23);
            txtUtilisateur.TabIndex = 5;
            // 
            // txtMDP
            // 
            txtMDP.BorderStyle = BorderStyle.FixedSingle;
            txtMDP.Location = new Point(391, 313);
            txtMDP.MaxLength = 50;
            txtMDP.Name = "txtMDP";
            txtMDP.Size = new Size(208, 23);
            txtMDP.TabIndex = 6;
            // 
            // txtConf
            // 
            txtConf.BorderStyle = BorderStyle.FixedSingle;
            txtConf.Location = new Point(391, 349);
            txtConf.MaxLength = 50;
            txtConf.Name = "txtConf";
            txtConf.Size = new Size(208, 23);
            txtConf.TabIndex = 7;
            // 
            // btnCreer
            // 
            btnCreer.Location = new Point(426, 396);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(137, 41);
            btnCreer.TabIndex = 8;
            btnCreer.Text = "Créer un compte";
            btnCreer.UseVisualStyleBackColor = true;
            btnCreer.Click += btnCreer_Click;
            // 
            // btnretour
            // 
            btnretour.Location = new Point(405, 453);
            btnretour.Name = "btnretour";
            btnretour.Size = new Size(174, 39);
            btnretour.TabIndex = 9;
            btnretour.Text = "Retour à connexion";
            btnretour.UseVisualStyleBackColor = true;
            btnretour.Click += btnretour_Click;
            // 
            // creationCompte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(959, 544);
            Controls.Add(btnretour);
            Controls.Add(btnCreer);
            Controls.Add(txtConf);
            Controls.Add(txtMDP);
            Controls.Add(txtUtilisateur);
            Controls.Add(txtEmail);
            Controls.Add(dateTimePicker1);
            Controls.Add(cboGenre);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "creationCompte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Créer un compte";
            Load += creationCompte_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private ComboBox cboGenre;
        private DateTimePicker dateTimePicker1;
        private TextBox txtEmail;
        private TextBox txtUtilisateur;
        private TextBox txtMDP;
        private TextBox txtConf;
        private Button btnCreer;
        private Button btnretour;
    }
}