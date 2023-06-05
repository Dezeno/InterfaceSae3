namespace Interface
{
    partial class FormInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInterface));
            btnAide = new Button();
            picIUT = new PictureBox();
            lblNoms = new Label();
            grpSaisie = new GroupBox();
            lblPt12 = new Label();
            lblPt11 = new Label();
            lblPt10 = new Label();
            txtMasque4 = new TextBox();
            txtMasque3 = new TextBox();
            txtMasque2 = new TextBox();
            txtMasque1 = new TextBox();
            label10 = new Label();
            txtCIDR = new TextBox();
            lblSlash = new Label();
            lblCIDR = new Label();
            lblPt9 = new Label();
            lblPt8 = new Label();
            lblPt7 = new Label();
            txtHexa4 = new TextBox();
            txtHexa3 = new TextBox();
            txtHexa2 = new TextBox();
            txtHexa1 = new TextBox();
            lblPt6 = new Label();
            lblPt5 = new Label();
            lblPt4 = new Label();
            txtBin4 = new TextBox();
            txtBin3 = new TextBox();
            txtBin2 = new TextBox();
            txtBin1 = new TextBox();
            lblPt3 = new Label();
            lblPt2 = new Label();
            lblPt1 = new Label();
            txtDec4 = new TextBox();
            txtDec3 = new TextBox();
            txtDec2 = new TextBox();
            txtDec1 = new TextBox();
            lblMasque = new Label();
            lblDecBinHexa = new Label();
            lblIPV4 = new Label();
            btnValider = new Button();
            grpCalcul = new GroupBox();
            lblRFC = new Label();
            txtNbMachines = new TextBox();
            label15 = new Label();
            txtNbIP = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtLIP1 = new TextBox();
            txtLIP4 = new TextBox();
            txtLIP2 = new TextBox();
            txtLIP3 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            txtFIP1 = new TextBox();
            txtFIP4 = new TextBox();
            txtFIP2 = new TextBox();
            txtFIP3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtBroad1 = new TextBox();
            txtBroad4 = new TextBox();
            txtBroad2 = new TextBox();
            txtBroad3 = new TextBox();
            label2 = new Label();
            txtClasse = new TextBox();
            label3 = new Label();
            lblCalculs = new Label();
            label4 = new Label();
            txtNet1 = new TextBox();
            txtNet4 = new TextBox();
            txtNet2 = new TextBox();
            txtNet3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picIUT).BeginInit();
            grpSaisie.SuspendLayout();
            grpCalcul.SuspendLayout();
            SuspendLayout();
            // 
            // btnAide
            // 
            btnAide.BackColor = SystemColors.ButtonHighlight;
            btnAide.Location = new Point(587, 12);
            btnAide.Name = "btnAide";
            btnAide.Size = new Size(27, 29);
            btnAide.TabIndex = 0;
            btnAide.Text = "?";
            btnAide.UseVisualStyleBackColor = false;
            btnAide.Click += btnAide_Click;
            // 
            // picIUT
            // 
            picIUT.Image = (Image)resources.GetObject("picIUT.Image");
            picIUT.Location = new Point(12, 677);
            picIUT.Name = "picIUT";
            picIUT.Size = new Size(75, 75);
            picIUT.TabIndex = 1;
            picIUT.TabStop = false;
            // 
            // lblNoms
            // 
            lblNoms.AutoSize = true;
            lblNoms.Location = new Point(104, 692);
            lblNoms.Name = "lblNoms";
            lblNoms.Size = new Size(510, 60);
            lblNoms.TabIndex = 2;
            lblNoms.Text = resources.GetString("lblNoms.Text");
            // 
            // grpSaisie
            // 
            grpSaisie.BackColor = SystemColors.ScrollBar;
            grpSaisie.Controls.Add(lblPt12);
            grpSaisie.Controls.Add(lblPt11);
            grpSaisie.Controls.Add(lblPt10);
            grpSaisie.Controls.Add(txtMasque4);
            grpSaisie.Controls.Add(txtMasque3);
            grpSaisie.Controls.Add(txtMasque2);
            grpSaisie.Controls.Add(txtMasque1);
            grpSaisie.Controls.Add(label10);
            grpSaisie.Controls.Add(txtCIDR);
            grpSaisie.Controls.Add(lblSlash);
            grpSaisie.Controls.Add(lblCIDR);
            grpSaisie.Controls.Add(lblPt9);
            grpSaisie.Controls.Add(lblPt8);
            grpSaisie.Controls.Add(lblPt7);
            grpSaisie.Controls.Add(txtHexa4);
            grpSaisie.Controls.Add(txtHexa3);
            grpSaisie.Controls.Add(txtHexa2);
            grpSaisie.Controls.Add(txtHexa1);
            grpSaisie.Controls.Add(lblPt6);
            grpSaisie.Controls.Add(lblPt5);
            grpSaisie.Controls.Add(lblPt4);
            grpSaisie.Controls.Add(txtBin4);
            grpSaisie.Controls.Add(txtBin3);
            grpSaisie.Controls.Add(txtBin2);
            grpSaisie.Controls.Add(txtBin1);
            grpSaisie.Controls.Add(lblPt3);
            grpSaisie.Controls.Add(lblPt2);
            grpSaisie.Controls.Add(lblPt1);
            grpSaisie.Controls.Add(txtDec4);
            grpSaisie.Controls.Add(txtDec3);
            grpSaisie.Controls.Add(txtDec2);
            grpSaisie.Controls.Add(txtDec1);
            grpSaisie.Controls.Add(lblMasque);
            grpSaisie.Controls.Add(lblDecBinHexa);
            grpSaisie.Controls.Add(lblIPV4);
            grpSaisie.Controls.Add(btnValider);
            grpSaisie.Location = new Point(22, 47);
            grpSaisie.Name = "grpSaisie";
            grpSaisie.Size = new Size(592, 305);
            grpSaisie.TabIndex = 3;
            grpSaisie.TabStop = false;
            grpSaisie.Text = "Saisie";
            // 
            // lblPt12
            // 
            lblPt12.AutoSize = true;
            lblPt12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt12.Location = new Point(465, 226);
            lblPt12.Name = "lblPt12";
            lblPt12.Size = new Size(16, 28);
            lblPt12.TabIndex = 36;
            lblPt12.Text = ".";
            // 
            // lblPt11
            // 
            lblPt11.AutoSize = true;
            lblPt11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt11.Location = new Point(351, 226);
            lblPt11.Name = "lblPt11";
            lblPt11.Size = new Size(16, 28);
            lblPt11.TabIndex = 35;
            lblPt11.Text = ".";
            // 
            // lblPt10
            // 
            lblPt10.AutoSize = true;
            lblPt10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt10.Location = new Point(237, 226);
            lblPt10.Name = "lblPt10";
            lblPt10.Size = new Size(16, 28);
            lblPt10.TabIndex = 34;
            lblPt10.Text = ".";
            // 
            // txtMasque4
            // 
            txtMasque4.BackColor = Color.LightSteelBlue;
            txtMasque4.BorderStyle = BorderStyle.FixedSingle;
            txtMasque4.Enabled = false;
            txtMasque4.Location = new Point(483, 225);
            txtMasque4.MaxLength = 3;
            txtMasque4.Name = "txtMasque4";
            txtMasque4.Size = new Size(90, 27);
            txtMasque4.TabIndex = 33;
            txtMasque4.TextAlign = HorizontalAlignment.Center;
            txtMasque4.KeyPress += txtDec_KeyPress;
            // 
            // txtMasque3
            // 
            txtMasque3.BackColor = Color.LightSteelBlue;
            txtMasque3.BorderStyle = BorderStyle.FixedSingle;
            txtMasque3.Enabled = false;
            txtMasque3.Location = new Point(368, 225);
            txtMasque3.MaxLength = 3;
            txtMasque3.Name = "txtMasque3";
            txtMasque3.Size = new Size(91, 27);
            txtMasque3.TabIndex = 32;
            txtMasque3.TextAlign = HorizontalAlignment.Center;
            txtMasque3.KeyPress += txtDec_KeyPress;
            // 
            // txtMasque2
            // 
            txtMasque2.BackColor = Color.LightSteelBlue;
            txtMasque2.BorderStyle = BorderStyle.FixedSingle;
            txtMasque2.Enabled = false;
            txtMasque2.Location = new Point(256, 225);
            txtMasque2.MaxLength = 3;
            txtMasque2.Name = "txtMasque2";
            txtMasque2.Size = new Size(89, 27);
            txtMasque2.TabIndex = 31;
            txtMasque2.TextAlign = HorizontalAlignment.Center;
            txtMasque2.KeyPress += txtDec_KeyPress;
            // 
            // txtMasque1
            // 
            txtMasque1.BackColor = Color.LightSteelBlue;
            txtMasque1.BorderStyle = BorderStyle.FixedSingle;
            txtMasque1.Enabled = false;
            txtMasque1.Location = new Point(144, 224);
            txtMasque1.MaxLength = 3;
            txtMasque1.Name = "txtMasque1";
            txtMasque1.Size = new Size(87, 27);
            txtMasque1.TabIndex = 30;
            txtMasque1.TextAlign = HorizontalAlignment.Center;
            txtMasque1.KeyPress += txtDec_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(102, 209);
            label10.Name = "label10";
            label10.Size = new Size(35, 54);
            label10.TabIndex = 29;
            label10.Text = "I";
            // 
            // txtCIDR
            // 
            txtCIDR.BackColor = Color.LightSteelBlue;
            txtCIDR.BorderStyle = BorderStyle.FixedSingle;
            txtCIDR.Location = new Point(38, 224);
            txtCIDR.MaxLength = 2;
            txtCIDR.Name = "txtCIDR";
            txtCIDR.Size = new Size(50, 27);
            txtCIDR.TabIndex = 28;
            txtCIDR.TextAlign = HorizontalAlignment.Center;
            txtCIDR.KeyPress += txtDec_KeyPress;
            txtCIDR.Leave += txtCIDR_Leave;
            // 
            // lblSlash
            // 
            lblSlash.AutoSize = true;
            lblSlash.Font = new Font("Segoe UI", 11.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSlash.Location = new Point(18, 225);
            lblSlash.Name = "lblSlash";
            lblSlash.Size = new Size(19, 25);
            lblSlash.TabIndex = 27;
            lblSlash.Text = "/";
            // 
            // lblCIDR
            // 
            lblCIDR.AutoSize = true;
            lblCIDR.Location = new Point(34, 193);
            lblCIDR.Name = "lblCIDR";
            lblCIDR.Size = new Size(42, 20);
            lblCIDR.TabIndex = 26;
            lblCIDR.Text = "CIDR";
            // 
            // lblPt9
            // 
            lblPt9.AutoSize = true;
            lblPt9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt9.Location = new Point(483, 133);
            lblPt9.Name = "lblPt9";
            lblPt9.Size = new Size(16, 28);
            lblPt9.TabIndex = 25;
            lblPt9.Text = ".";
            // 
            // lblPt8
            // 
            lblPt8.AutoSize = true;
            lblPt8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt8.Location = new Point(390, 133);
            lblPt8.Name = "lblPt8";
            lblPt8.Size = new Size(16, 28);
            lblPt8.TabIndex = 24;
            lblPt8.Text = ".";
            // 
            // lblPt7
            // 
            lblPt7.AutoSize = true;
            lblPt7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt7.Location = new Point(293, 133);
            lblPt7.Name = "lblPt7";
            lblPt7.Size = new Size(16, 28);
            lblPt7.TabIndex = 23;
            lblPt7.Text = ".";
            // 
            // txtHexa4
            // 
            txtHexa4.BackColor = Color.LightSteelBlue;
            txtHexa4.BorderStyle = BorderStyle.FixedSingle;
            txtHexa4.Location = new Point(500, 131);
            txtHexa4.MaxLength = 2;
            txtHexa4.Name = "txtHexa4";
            txtHexa4.Size = new Size(73, 27);
            txtHexa4.TabIndex = 22;
            txtHexa4.TextAlign = HorizontalAlignment.Center;
            txtHexa4.KeyPress += txtHexa_KeyPress;
            txtHexa4.Leave += txtHexa_Leave;
            // 
            // txtHexa3
            // 
            txtHexa3.BackColor = Color.LightSteelBlue;
            txtHexa3.BorderStyle = BorderStyle.FixedSingle;
            txtHexa3.Location = new Point(408, 131);
            txtHexa3.MaxLength = 2;
            txtHexa3.Name = "txtHexa3";
            txtHexa3.Size = new Size(73, 27);
            txtHexa3.TabIndex = 21;
            txtHexa3.TextAlign = HorizontalAlignment.Center;
            txtHexa3.KeyPress += txtHexa_KeyPress;
            txtHexa3.Leave += txtHexa_Leave;
            // 
            // txtHexa2
            // 
            txtHexa2.BackColor = Color.LightSteelBlue;
            txtHexa2.BorderStyle = BorderStyle.FixedSingle;
            txtHexa2.Location = new Point(312, 131);
            txtHexa2.MaxLength = 2;
            txtHexa2.Name = "txtHexa2";
            txtHexa2.Size = new Size(73, 27);
            txtHexa2.TabIndex = 20;
            txtHexa2.TextAlign = HorizontalAlignment.Center;
            txtHexa2.KeyPress += txtHexa_KeyPress;
            txtHexa2.Leave += txtHexa_Leave;
            // 
            // txtHexa1
            // 
            txtHexa1.BackColor = Color.LightSteelBlue;
            txtHexa1.BorderStyle = BorderStyle.FixedSingle;
            txtHexa1.Location = new Point(215, 131);
            txtHexa1.MaxLength = 2;
            txtHexa1.Name = "txtHexa1";
            txtHexa1.Size = new Size(73, 27);
            txtHexa1.TabIndex = 19;
            txtHexa1.TextAlign = HorizontalAlignment.Center;
            txtHexa1.KeyPress += txtHexa_KeyPress;
            txtHexa1.Leave += txtHexa_Leave;
            // 
            // lblPt6
            // 
            lblPt6.AutoSize = true;
            lblPt6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt6.Location = new Point(451, 95);
            lblPt6.Name = "lblPt6";
            lblPt6.Size = new Size(16, 28);
            lblPt6.TabIndex = 18;
            lblPt6.Text = ".";
            // 
            // lblPt5
            // 
            lblPt5.AutoSize = true;
            lblPt5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt5.Location = new Point(326, 95);
            lblPt5.Name = "lblPt5";
            lblPt5.Size = new Size(16, 28);
            lblPt5.TabIndex = 17;
            lblPt5.Text = ".";
            // 
            // lblPt4
            // 
            lblPt4.AutoSize = true;
            lblPt4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt4.Location = new Point(199, 95);
            lblPt4.Name = "lblPt4";
            lblPt4.Size = new Size(16, 28);
            lblPt4.TabIndex = 16;
            lblPt4.Text = ".";
            // 
            // txtBin4
            // 
            txtBin4.BackColor = Color.LightSteelBlue;
            txtBin4.BorderStyle = BorderStyle.FixedSingle;
            txtBin4.Location = new Point(467, 94);
            txtBin4.MaxLength = 8;
            txtBin4.Name = "txtBin4";
            txtBin4.Size = new Size(107, 27);
            txtBin4.TabIndex = 15;
            txtBin4.TextAlign = HorizontalAlignment.Center;
            txtBin4.KeyPress += txtBin_KeyPress;
            txtBin4.Leave += txtBin_Leave;
            // 
            // txtBin3
            // 
            txtBin3.BackColor = Color.LightSteelBlue;
            txtBin3.BorderStyle = BorderStyle.FixedSingle;
            txtBin3.Location = new Point(342, 94);
            txtBin3.MaxLength = 8;
            txtBin3.Name = "txtBin3";
            txtBin3.Size = new Size(107, 27);
            txtBin3.TabIndex = 14;
            txtBin3.TextAlign = HorizontalAlignment.Center;
            txtBin3.KeyPress += txtBin_KeyPress;
            txtBin3.Leave += txtBin_Leave;
            // 
            // txtBin2
            // 
            txtBin2.BackColor = Color.LightSteelBlue;
            txtBin2.BorderStyle = BorderStyle.FixedSingle;
            txtBin2.Location = new Point(215, 94);
            txtBin2.MaxLength = 8;
            txtBin2.Name = "txtBin2";
            txtBin2.Size = new Size(107, 27);
            txtBin2.TabIndex = 13;
            txtBin2.TextAlign = HorizontalAlignment.Center;
            txtBin2.KeyPress += txtBin_KeyPress;
            txtBin2.Leave += txtBin_Leave;
            // 
            // txtBin1
            // 
            txtBin1.BackColor = Color.LightSteelBlue;
            txtBin1.BorderStyle = BorderStyle.FixedSingle;
            txtBin1.Location = new Point(92, 94);
            txtBin1.MaxLength = 8;
            txtBin1.Name = "txtBin1";
            txtBin1.Size = new Size(107, 27);
            txtBin1.TabIndex = 12;
            txtBin1.TextAlign = HorizontalAlignment.Center;
            txtBin1.KeyPress += txtBin_KeyPress;
            txtBin1.Leave += txtBin_Leave;
            // 
            // lblPt3
            // 
            lblPt3.AutoSize = true;
            lblPt3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt3.Location = new Point(451, 53);
            lblPt3.Name = "lblPt3";
            lblPt3.Size = new Size(16, 28);
            lblPt3.TabIndex = 10;
            lblPt3.Text = ".";
            // 
            // lblPt2
            // 
            lblPt2.AutoSize = true;
            lblPt2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt2.Location = new Point(326, 53);
            lblPt2.Name = "lblPt2";
            lblPt2.Size = new Size(16, 28);
            lblPt2.TabIndex = 9;
            lblPt2.Text = ".";
            // 
            // lblPt1
            // 
            lblPt1.AutoSize = true;
            lblPt1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPt1.Location = new Point(199, 53);
            lblPt1.Name = "lblPt1";
            lblPt1.Size = new Size(16, 28);
            lblPt1.TabIndex = 8;
            lblPt1.Text = ".";
            // 
            // txtDec4
            // 
            txtDec4.BackColor = Color.LightSteelBlue;
            txtDec4.BorderStyle = BorderStyle.FixedSingle;
            txtDec4.Location = new Point(467, 52);
            txtDec4.MaxLength = 3;
            txtDec4.Name = "txtDec4";
            txtDec4.Size = new Size(107, 27);
            txtDec4.TabIndex = 7;
            txtDec4.TextAlign = HorizontalAlignment.Center;
            txtDec4.KeyPress += txtDec_KeyPress;
            txtDec4.Leave += txtDec_Leave;
            // 
            // txtDec3
            // 
            txtDec3.BackColor = Color.LightSteelBlue;
            txtDec3.BorderStyle = BorderStyle.FixedSingle;
            txtDec3.Location = new Point(342, 52);
            txtDec3.MaxLength = 3;
            txtDec3.Name = "txtDec3";
            txtDec3.Size = new Size(107, 27);
            txtDec3.TabIndex = 6;
            txtDec3.TextAlign = HorizontalAlignment.Center;
            txtDec3.KeyPress += txtDec_KeyPress;
            txtDec3.Leave += txtDec_Leave;
            // 
            // txtDec2
            // 
            txtDec2.BackColor = Color.LightSteelBlue;
            txtDec2.BorderStyle = BorderStyle.FixedSingle;
            txtDec2.Location = new Point(215, 52);
            txtDec2.MaxLength = 3;
            txtDec2.Name = "txtDec2";
            txtDec2.Size = new Size(107, 27);
            txtDec2.TabIndex = 5;
            txtDec2.TextAlign = HorizontalAlignment.Center;
            txtDec2.KeyPress += txtDec_KeyPress;
            txtDec2.Leave += txtDec_Leave;
            // 
            // txtDec1
            // 
            txtDec1.BackColor = Color.LightSteelBlue;
            txtDec1.BorderStyle = BorderStyle.FixedSingle;
            txtDec1.Location = new Point(92, 52);
            txtDec1.MaxLength = 3;
            txtDec1.Name = "txtDec1";
            txtDec1.Size = new Size(107, 27);
            txtDec1.TabIndex = 4;
            txtDec1.TextAlign = HorizontalAlignment.Center;
            txtDec1.KeyPress += txtDec_KeyPress;
            txtDec1.Leave += txtDec_Leave;
            // 
            // lblMasque
            // 
            lblMasque.AutoSize = true;
            lblMasque.Location = new Point(263, 182);
            lblMasque.Name = "lblMasque";
            lblMasque.Size = new Size(69, 20);
            lblMasque.TabIndex = 3;
            lblMasque.Text = "MASQUE";
            // 
            // lblDecBinHexa
            // 
            lblDecBinHexa.AutoSize = true;
            lblDecBinHexa.Location = new Point(6, 55);
            lblDecBinHexa.Name = "lblDecBinHexa";
            lblDecBinHexa.Size = new Size(103, 100);
            lblDecBinHexa.TabIndex = 2;
            lblDecBinHexa.Text = "(déc.)\r\n\r\n(bin.)\r\n\r\n(hexadécimal)";
            // 
            // lblIPV4
            // 
            lblIPV4.AutoSize = true;
            lblIPV4.Location = new Point(278, 23);
            lblIPV4.Name = "lblIPV4";
            lblIPV4.Size = new Size(38, 20);
            lblIPV4.TabIndex = 1;
            lblIPV4.Text = "IPV4";
            // 
            // btnValider
            // 
            btnValider.BackColor = Color.PaleGreen;
            btnValider.FlatStyle = FlatStyle.Flat;
            btnValider.Location = new Point(256, 264);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(89, 29);
            btnValider.TabIndex = 0;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = false;
            btnValider.Click += btnValider_Click;
            // 
            // grpCalcul
            // 
            grpCalcul.Controls.Add(lblRFC);
            grpCalcul.Controls.Add(txtNbMachines);
            grpCalcul.Controls.Add(label15);
            grpCalcul.Controls.Add(txtNbIP);
            grpCalcul.Controls.Add(label12);
            grpCalcul.Controls.Add(label13);
            grpCalcul.Controls.Add(label14);
            grpCalcul.Controls.Add(txtLIP1);
            grpCalcul.Controls.Add(txtLIP4);
            grpCalcul.Controls.Add(txtLIP2);
            grpCalcul.Controls.Add(txtLIP3);
            grpCalcul.Controls.Add(label8);
            grpCalcul.Controls.Add(label9);
            grpCalcul.Controls.Add(label11);
            grpCalcul.Controls.Add(txtFIP1);
            grpCalcul.Controls.Add(txtFIP4);
            grpCalcul.Controls.Add(txtFIP2);
            grpCalcul.Controls.Add(txtFIP3);
            grpCalcul.Controls.Add(label5);
            grpCalcul.Controls.Add(label6);
            grpCalcul.Controls.Add(label7);
            grpCalcul.Controls.Add(txtBroad1);
            grpCalcul.Controls.Add(txtBroad4);
            grpCalcul.Controls.Add(txtBroad2);
            grpCalcul.Controls.Add(txtBroad3);
            grpCalcul.Controls.Add(label2);
            grpCalcul.Controls.Add(txtClasse);
            grpCalcul.Controls.Add(label3);
            grpCalcul.Controls.Add(lblCalculs);
            grpCalcul.Controls.Add(label4);
            grpCalcul.Controls.Add(txtNet1);
            grpCalcul.Controls.Add(txtNet4);
            grpCalcul.Controls.Add(txtNet2);
            grpCalcul.Controls.Add(txtNet3);
            grpCalcul.Location = new Point(22, 376);
            grpCalcul.Name = "grpCalcul";
            grpCalcul.Size = new Size(592, 280);
            grpCalcul.TabIndex = 4;
            grpCalcul.TabStop = false;
            grpCalcul.Text = "Calcul";
            // 
            // lblRFC
            // 
            lblRFC.AutoSize = true;
            lblRFC.ForeColor = Color.Red;
            lblRFC.Location = new Point(174, 39);
            lblRFC.Name = "lblRFC";
            lblRFC.Size = new Size(0, 20);
            lblRFC.TabIndex = 68;
            // 
            // txtNbMachines
            // 
            txtNbMachines.Enabled = false;
            txtNbMachines.Location = new Point(461, 237);
            txtNbMachines.Name = "txtNbMachines";
            txtNbMachines.Size = new Size(87, 27);
            txtNbMachines.TabIndex = 67;
            txtNbMachines.TextAlign = HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(293, 243);
            label15.Name = "label15";
            label15.Size = new Size(151, 20);
            label15.TabIndex = 66;
            label15.Text = "Nombre de Machines";
            // 
            // txtNbIP
            // 
            txtNbIP.Enabled = false;
            txtNbIP.Location = new Point(122, 235);
            txtNbIP.Name = "txtNbIP";
            txtNbIP.Size = new Size(87, 27);
            txtNbIP.TabIndex = 65;
            txtNbIP.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(443, 195);
            label12.Name = "label12";
            label12.Size = new Size(16, 28);
            label12.TabIndex = 64;
            label12.Text = ".";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(329, 195);
            label13.Name = "label13";
            label13.Size = new Size(16, 28);
            label13.TabIndex = 63;
            label13.Text = ".";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(215, 195);
            label14.Name = "label14";
            label14.Size = new Size(16, 28);
            label14.TabIndex = 62;
            label14.Text = ".";
            // 
            // txtLIP1
            // 
            txtLIP1.Enabled = false;
            txtLIP1.Location = new Point(122, 193);
            txtLIP1.Name = "txtLIP1";
            txtLIP1.Size = new Size(87, 27);
            txtLIP1.TabIndex = 58;
            txtLIP1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLIP4
            // 
            txtLIP4.Enabled = false;
            txtLIP4.Location = new Point(461, 194);
            txtLIP4.Name = "txtLIP4";
            txtLIP4.Size = new Size(87, 27);
            txtLIP4.TabIndex = 61;
            txtLIP4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLIP2
            // 
            txtLIP2.Enabled = false;
            txtLIP2.Location = new Point(234, 194);
            txtLIP2.Name = "txtLIP2";
            txtLIP2.Size = new Size(88, 27);
            txtLIP2.TabIndex = 59;
            txtLIP2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLIP3
            // 
            txtLIP3.Enabled = false;
            txtLIP3.Location = new Point(346, 194);
            txtLIP3.Name = "txtLIP3";
            txtLIP3.Size = new Size(91, 27);
            txtLIP3.TabIndex = 60;
            txtLIP3.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(443, 157);
            label8.Name = "label8";
            label8.Size = new Size(16, 28);
            label8.TabIndex = 57;
            label8.Text = ".";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(329, 157);
            label9.Name = "label9";
            label9.Size = new Size(16, 28);
            label9.TabIndex = 56;
            label9.Text = ".";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(215, 157);
            label11.Name = "label11";
            label11.Size = new Size(16, 28);
            label11.TabIndex = 55;
            label11.Text = ".";
            // 
            // txtFIP1
            // 
            txtFIP1.Enabled = false;
            txtFIP1.Location = new Point(122, 155);
            txtFIP1.Name = "txtFIP1";
            txtFIP1.Size = new Size(87, 27);
            txtFIP1.TabIndex = 51;
            txtFIP1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFIP4
            // 
            txtFIP4.Enabled = false;
            txtFIP4.Location = new Point(461, 156);
            txtFIP4.Name = "txtFIP4";
            txtFIP4.Size = new Size(87, 27);
            txtFIP4.TabIndex = 54;
            txtFIP4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFIP2
            // 
            txtFIP2.Enabled = false;
            txtFIP2.Location = new Point(234, 156);
            txtFIP2.Name = "txtFIP2";
            txtFIP2.Size = new Size(88, 27);
            txtFIP2.TabIndex = 52;
            txtFIP2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFIP3
            // 
            txtFIP3.Enabled = false;
            txtFIP3.Location = new Point(346, 156);
            txtFIP3.Name = "txtFIP3";
            txtFIP3.Size = new Size(91, 27);
            txtFIP3.TabIndex = 53;
            txtFIP3.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(443, 118);
            label5.Name = "label5";
            label5.Size = new Size(16, 28);
            label5.TabIndex = 50;
            label5.Text = ".";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(329, 118);
            label6.Name = "label6";
            label6.Size = new Size(16, 28);
            label6.TabIndex = 49;
            label6.Text = ".";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(215, 118);
            label7.Name = "label7";
            label7.Size = new Size(16, 28);
            label7.TabIndex = 48;
            label7.Text = ".";
            // 
            // txtBroad1
            // 
            txtBroad1.Enabled = false;
            txtBroad1.Location = new Point(122, 116);
            txtBroad1.Name = "txtBroad1";
            txtBroad1.Size = new Size(87, 27);
            txtBroad1.TabIndex = 44;
            txtBroad1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBroad4
            // 
            txtBroad4.Enabled = false;
            txtBroad4.Location = new Point(461, 117);
            txtBroad4.Name = "txtBroad4";
            txtBroad4.Size = new Size(87, 27);
            txtBroad4.TabIndex = 47;
            txtBroad4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBroad2
            // 
            txtBroad2.Enabled = false;
            txtBroad2.Location = new Point(234, 117);
            txtBroad2.Name = "txtBroad2";
            txtBroad2.Size = new Size(88, 27);
            txtBroad2.TabIndex = 45;
            txtBroad2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBroad3
            // 
            txtBroad3.Enabled = false;
            txtBroad3.Location = new Point(346, 117);
            txtBroad3.Name = "txtBroad3";
            txtBroad3.Size = new Size(91, 27);
            txtBroad3.TabIndex = 46;
            txtBroad3.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(443, 76);
            label2.Name = "label2";
            label2.Size = new Size(16, 28);
            label2.TabIndex = 43;
            label2.Text = ".";
            // 
            // txtClasse
            // 
            txtClasse.Enabled = false;
            txtClasse.Location = new Point(122, 36);
            txtClasse.Name = "txtClasse";
            txtClasse.Size = new Size(37, 27);
            txtClasse.TabIndex = 37;
            txtClasse.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(329, 76);
            label3.Name = "label3";
            label3.Size = new Size(16, 28);
            label3.TabIndex = 42;
            label3.Text = ".";
            // 
            // lblCalculs
            // 
            lblCalculs.AutoSize = true;
            lblCalculs.Location = new Point(18, 39);
            lblCalculs.Name = "lblCalculs";
            lblCalculs.Size = new Size(98, 220);
            lblCalculs.TabIndex = 0;
            lblCalculs.Text = "Type Classe\r\n\r\n@Net\r\n\r\n@Broadcast\r\n\r\n1re IP\r\n\r\nDernière IP\r\n\r\nNombre d'IPs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(215, 76);
            label4.Name = "label4";
            label4.Size = new Size(16, 28);
            label4.TabIndex = 41;
            label4.Text = ".";
            // 
            // txtNet1
            // 
            txtNet1.Enabled = false;
            txtNet1.Location = new Point(122, 74);
            txtNet1.Name = "txtNet1";
            txtNet1.Size = new Size(87, 27);
            txtNet1.TabIndex = 37;
            txtNet1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNet4
            // 
            txtNet4.Enabled = false;
            txtNet4.Location = new Point(461, 75);
            txtNet4.Name = "txtNet4";
            txtNet4.Size = new Size(87, 27);
            txtNet4.TabIndex = 40;
            txtNet4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNet2
            // 
            txtNet2.Enabled = false;
            txtNet2.Location = new Point(234, 75);
            txtNet2.Name = "txtNet2";
            txtNet2.Size = new Size(88, 27);
            txtNet2.TabIndex = 38;
            txtNet2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNet3
            // 
            txtNet3.Enabled = false;
            txtNet3.Location = new Point(346, 75);
            txtNet3.Name = "txtNet3";
            txtNet3.Size = new Size(91, 27);
            txtNet3.TabIndex = 39;
            txtNet3.TextAlign = HorizontalAlignment.Center;
            // 
            // FormInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(626, 764);
            Controls.Add(grpCalcul);
            Controls.Add(grpSaisie);
            Controls.Add(lblNoms);
            Controls.Add(picIUT);
            Controls.Add(btnAide);
            Name = "FormInterface";
            Text = "IP App";
            Load += FormInterface_Load;
            ((System.ComponentModel.ISupportInitialize)picIUT).EndInit();
            grpSaisie.ResumeLayout(false);
            grpSaisie.PerformLayout();
            grpCalcul.ResumeLayout(false);
            grpCalcul.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAide;
        private PictureBox picIUT;
        private Label lblNoms;
        private GroupBox grpSaisie;
        private Label lblIPV4;
        private Button btnValider;
        private GroupBox grpCalcul;
        private Label lblPt9;
        private Label lblPt8;
        private Label lblPt7;
        private TextBox txtHexa4;
        private TextBox txtHexa3;
        private TextBox txtHexa2;
        private TextBox txtHexa1;
        private Label lblPt6;
        private Label lblPt5;
        private Label lblPt4;
        private TextBox txtBin4;
        private TextBox txtBin3;
        private TextBox txtBin2;
        private TextBox txtBin1;
        private Label lblPt3;
        private Label lblPt2;
        private Label lblPt1;
        private TextBox txtDec4;
        private TextBox txtDec3;
        private TextBox txtDec2;
        private TextBox txtDec1;
        private Label lblMasque;
        private Label lblDecBinHexa;
        private Label lblPt12;
        private Label lblPt11;
        private Label lblPt10;
        private TextBox txtMasque4;
        private TextBox txtMasque3;
        private TextBox txtMasque2;
        private TextBox txtMasque1;
        private Label label10;
        private TextBox txtCIDR;
        private Label lblSlash;
        private Label lblCIDR;
        private TextBox txtNbMachines;
        private Label label15;
        private TextBox txtNbIP;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtLIP1;
        private TextBox txtLIP4;
        private TextBox txtLIP2;
        private TextBox txtLIP3;
        private Label label8;
        private Label label9;
        private Label label11;
        private TextBox txtFIP1;
        private TextBox txtFIP4;
        private TextBox txtFIP2;
        private TextBox txtFIP3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtBroad1;
        private TextBox txtBroad4;
        private TextBox txtBroad2;
        private TextBox txtBroad3;
        private Label label2;
        private TextBox txtClasse;
        private Label label3;
        private Label lblCalculs;
        private Label label4;
        private TextBox txtNet1;
        private TextBox txtNet4;
        private TextBox txtNet2;
        private TextBox txtNet3;
        private Label lblRFC;
    }
}