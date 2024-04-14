namespace sav
{
    partial class ConnexionEtablie
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
            btndeco = new Button();
            SuspendLayout();
            // 
            // btndeco
            // 
            btndeco.Location = new Point(306, 212);
            btndeco.Name = "btndeco";
            btndeco.Size = new Size(155, 37);
            btndeco.TabIndex = 0;
            btndeco.Text = "Deconnexion";
            btndeco.UseVisualStyleBackColor = true;
            btndeco.Click += btndeco_Click;
            // 
            // ConnexionEtablie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndeco);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ConnexionEtablie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Réussite de connexion";
            Load += ConnexionEtablie_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btndeco;
    }
}