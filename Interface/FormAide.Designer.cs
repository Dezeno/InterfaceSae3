namespace Interface
{
    partial class FormAide
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 29);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "IP App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 90);
            label2.Name = "label2";
            label2.Size = new Size(398, 40);
            label2.TabIndex = 1;
            label2.Text = "-Renseignez au choix votre adresse IP dans la partie saisie, \r\n soit en décimal, soit en binaire, soit en hexadécimal. ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(9, 130);
            label3.Name = "label3";
            label3.Size = new Size(305, 40);
            label3.TabIndex = 2;
            label3.Text = "(Les conversions se feront automatiquement \r\n dans les autres champs).";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 202);
            label4.Name = "label4";
            label4.Size = new Size(339, 40);
            label4.TabIndex = 3;
            label4.Text = "-Renseignez ensuite votre masque de sous réseau.\r\n Soit en notation CIDR, soit en décimal.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(9, 243);
            label5.Name = "label5";
            label5.Size = new Size(409, 20);
            label5.TabIndex = 4;
            label5.Text = "(La conversion se fera automatiquement dans l'autre champ)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 306);
            label6.Name = "label6";
            label6.Size = new Size(358, 40);
            label6.TabIndex = 5;
            label6.Text = "-Enfin, vous n'avez plus qu'à récolter les informations\r\n de votre réseau.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Green;
            label7.Location = new Point(42, 392);
            label7.Name = "label7";
            label7.Size = new Size(325, 20);
            label7.TabIndex = 6;
            label7.Text = "Cette application prend en compte la RFC 5735.";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Green;
            linkLabel1.Location = new Point(61, 438);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(287, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Plus d'informations sur le VLSM et le FLSM";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormAide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(419, 467);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAide";
            Text = "Aide";
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
        private LinkLabel linkLabel1;
    }
}