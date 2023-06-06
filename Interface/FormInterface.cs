using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace Interface
{
    public partial class FormInterface : Form
    {
        public FormInterface()
        {
            InitializeComponent();
        }

        private void FormInterface_Load(object sender, EventArgs e)
        {
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            FormAide frmAide = new FormAide();
            frmAide.ShowDialog(this);
        }
        private void txtDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }



        private void txtBin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtHexa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'A' && e.KeyChar <= 'F') || (e.KeyChar >= 48 && e.KeyChar <= 57)) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDec_Leave(object sender, EventArgs e)
        {

            if (txtDec1.Text != "" && txtDec2.Text != "" && txtDec3.Text != "" && txtDec4.Text != "")
            {
                txtBin1.Text = Convert.ToString(Convert.ToInt32(txtDec1.Text), 2);
                txtBin2.Text = Convert.ToString(Convert.ToInt32(txtDec2.Text), 2);
                txtBin3.Text = Convert.ToString(Convert.ToInt32(txtDec3.Text), 2);
                txtBin4.Text = Convert.ToString(Convert.ToInt32(txtDec4.Text), 2);
                txtHexa1.Text = Convert.ToInt32(txtDec1.Text, 10).ToString("X");
                txtHexa2.Text = Convert.ToInt32(txtDec2.Text, 10).ToString("X");
                txtHexa3.Text = Convert.ToInt32(txtDec3.Text, 10).ToString("X");
                txtHexa4.Text = Convert.ToInt32(txtDec4.Text, 10).ToString("X");
            }

        }

        private void txtBin_Leave(object sender, EventArgs e)
        {

            if (txtBin1.Text != "" && txtBin2.Text != "" && txtBin3.Text != "" && txtBin4.Text != "")
            {
                txtDec1.Text = Convert.ToInt32(txtBin1.Text, 2).ToString();
                txtDec2.Text = Convert.ToInt32(txtBin2.Text, 2).ToString();
                txtDec3.Text = Convert.ToInt32(txtBin3.Text, 2).ToString();
                txtDec4.Text = Convert.ToInt32(txtBin4.Text, 2).ToString();
                txtHexa1.Text = Convert.ToInt32(txtBin1.Text, 2).ToString("X");
                txtHexa2.Text = Convert.ToInt32(txtBin2.Text, 2).ToString("X");
                txtHexa3.Text = Convert.ToInt32(txtBin3.Text, 2).ToString("X");
                txtHexa4.Text = Convert.ToInt32(txtBin4.Text, 2).ToString("X");
            }
        }

        private void txtHexa_Leave(object sender, EventArgs e)
        {
            TextBox txtTemp = (TextBox)sender;

            if (txtHexa1.Text != "" && txtHexa2.Text != "" && txtHexa3.Text != "" && txtHexa4.Text != "")
            {
                txtDec1.Text = Convert.ToInt32(txtHexa1.Text, 16).ToString();
                txtDec2.Text = Convert.ToInt32(txtHexa2.Text, 16).ToString();
                txtDec3.Text = Convert.ToInt32(txtHexa3.Text, 16).ToString();
                txtDec4.Text = Convert.ToInt32(txtHexa4.Text, 16).ToString();
                txtBin1.Text = Convert.ToString(Convert.ToInt32(txtHexa1.Text, 16), 2);
                txtBin2.Text = Convert.ToString(Convert.ToInt32(txtHexa2.Text, 16), 2);
                txtBin3.Text = Convert.ToString(Convert.ToInt32(txtHexa3.Text, 16), 2);
                txtBin4.Text = Convert.ToString(Convert.ToInt32(txtHexa4.Text, 16), 2);
            }
        }

        public string ConvertCIDRToMask(int cidr)
        {
            if (cidr > 31 || cidr < 8)
            {
                return "";
            }

            int bitsSet = (int)Math.Pow(2, cidr) - 1;
            int masque = bitsSet << (32 - cidr);

            byte[] maskBytes = BitConverter.GetBytes(masque);
            Array.Reverse(maskBytes); // Inversion de l'ordre des octets pour obtenir le format correct

            IPAddress ipAddress = new IPAddress(maskBytes);
            return ipAddress.ToString();
        }

        public string[] SplitMasque(string masque)
        {
            string[] parties_masque = masque.Split('.');

            return parties_masque;
        }

        public int ConvertMaskToCIDR(string[] masque)
        {
            string masque_convert = "";
            for (int i = 0; i < masque.Length; i++)
            {
                masque_convert += Convert.ToString(Convert.ToInt32(masque[i]), 2).PadLeft(8, '0');
            }

            int cidr = 0;

            bool zeroFound = false;
            for (int i = 0; i < masque_convert.Length - 1; i++)
            {
                if (masque_convert[i] == '1')
                {
                    cidr++;
                }
                else if (masque_convert[i] == '0')
                {
                    zeroFound = true;
                    if (masque_convert.Substring(i + 1).Contains('1'))
                    {
                        // CIDR invalide, il y a des bits "1" après le premier bit "0"
                        cidr = 0;
                    }
                    break;
                }
            }
            return cidr;
        }

        private void txtMasque_Leave(object sender, EventArgs e)
        {
            if (txtMasque1.Text != "" && txtMasque2.Text != "" && txtMasque3.Text != "" && txtMasque4.Text != "")
            {
                string[] masque = new string[4];
                for (int i = 0; i < 4; i++)
                {
                    string name = "txtMasque" + Convert.ToString(i + 1);
                    masque[i] = grpSaisie.Controls[name].Text;
                }
                int CIDR = ConvertMaskToCIDR(masque);
                txtCIDR.Text = Convert.ToString(CIDR);
            }

        }
        private void txtCIDR_Leave(object sender, EventArgs e)
        {
            if (txtCIDR.Text != "")
            {
                string masque = ConvertCIDRToMask(Convert.ToInt32(txtCIDR.Text));
                if (masque != "")
                {
                    string[] masque_list = SplitMasque(masque);
                    int compt = 1;
                    foreach (string split in masque_list)
                    {
                        string name = "txtMasque" + Convert.ToString(compt);
                        grpSaisie.Controls[name].Text = split;
                        compt++;
                    }
                }
                else
                {
                    txtMasque1.Text = ""; txtMasque2.Text = ""; txtMasque3.Text = ""; txtMasque4.Text = "";
                }

                /*switch (Convert.ToInt32(txtCIDR.Text))
                {
                    case 8: txtMasque1.Text = "255"; txtMasque2.Text = "0"; txtMasque3.Text = "0"; txtMasque4.Text = "0"; break;
                    case 9: txtMasque1.Text = "255"; txtMasque2.Text = "128"; txtMasque3.Text = "0"; txtMasque4.Text = "0"; break;
                    case 10: txtMasque1.Text = "255"; txtMasque2.Text = "192"; txtMasque3.Text = "0"; txtMasque4.Text = "0"; break;
                    case 11: txtMasque1.Text = "255"; txtMasque2.Text = "224"; txtMasque3.Text = "0"; txtMasque4.Text = "0"; break;
                    case 12: txtMasque1.Text = "255"; txtMasque2.Text = "240"; txtMasque3.Text = "0"; txtMasque4.Text = "0"; break;
                    case 13: txtMasque1.Text = "255"; txtMasque2.Text = "248"; txtMasque3.Text = "0"; txtMasque4.Text = "0"; break;
                    case 14: txtMasque1.Text = "255"; txtMasque2.Text = "252"; txtMasque3.Text = "0"; txtMasque4.Text = "0"; break;
                    case 15: txtMasque1.Text = "255"; txtMasque2.Text = "254"; txtMasque3.Text = "0"; txtMasque4.Text = "0"; break;
                    case 16: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "0"; txtMasque4.Text = "0"; break;
                    case 17: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "128"; txtMasque4.Text = "0"; break;
                    case 18: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "192"; txtMasque4.Text = "0"; break;
                    case 19: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "224"; txtMasque4.Text = "0"; break;
                    case 20: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "240"; txtMasque4.Text = "0"; break;
                    case 21: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "248"; txtMasque4.Text = "0"; break;
                    case 22: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "252"; txtMasque4.Text = "0"; break;
                    case 23: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "254"; txtMasque4.Text = "0"; break;
                    case 24: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "255"; txtMasque4.Text = "0"; break;
                    case 25: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "255"; txtMasque4.Text = "128"; break;
                    case 26: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "255"; txtMasque4.Text = "192"; break;
                    case 27: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "255"; txtMasque4.Text = "224"; break;
                    case 28: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "255"; txtMasque4.Text = "240"; break;
                    case 29: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "255"; txtMasque4.Text = "248"; break;
                    case 30: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "255"; txtMasque4.Text = "252"; break;
                    case 31: txtMasque1.Text = "255"; txtMasque2.Text = "255"; txtMasque3.Text = "255"; txtMasque4.Text = "254"; break;
                    default: txtMasque1.Text = ""; txtMasque2.Text = ""; txtMasque3.Text = ""; txtMasque4.Text = ""; break;
                }*/
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult quitDialog;
            if (txtDec1.Text == "" || txtDec2.Text == "" || txtDec3.Text == "" || txtDec4.Text == "" || txtCIDR.Text == "")
            {
                quitDialog = MessageBox.Show("L'adresse IP et/ou le masque sont incomplets !", "Attention !", MessageBoxButtons.OK);
            }
            else
            {
                if ((Convert.ToInt32(txtDec1.Text) > 255 || Convert.ToInt32(txtDec2.Text) > 255 || Convert.ToInt32(txtDec3.Text) > 255 || Convert.ToInt32(txtDec4.Text) > 255) ||( txtDec1.Text == "255" && txtDec2.Text == "255" && txtDec3.Text == "255" && txtDec4.Text == "255"))
                {
                    txtDec1.BackColor = Color.LightSalmon;
                    txtDec2.BackColor = Color.LightSalmon;
                    txtDec3.BackColor = Color.LightSalmon;
                    txtDec4.BackColor = Color.LightSalmon;
                    quitDialog = MessageBox.Show("L'adresse IP est incorrecte !", "Attention !", MessageBoxButtons.OK);
                    txtDec1.BackColor = Color.LightSteelBlue;
                    txtDec2.BackColor = Color.LightSteelBlue;
                    txtDec3.BackColor = Color.LightSteelBlue;
                    txtDec4.BackColor = Color.LightSteelBlue;
                }
                else
                {
                    if (Convert.ToInt32(txtCIDR.Text) > 31 || Convert.ToInt32(txtCIDR.Text) < 8)
                    {
                        txtCIDR.BackColor = Color.LightSalmon;
                        quitDialog = MessageBox.Show("Le masque est incorrect !", "Attention !", MessageBoxButtons.OK);
                        txtCIDR.BackColor = Color.LightSteelBlue;
                    }
                    else
                    {
                        lblRFC.Font = new Font("Segoe UI", 9);
                        lblRFC.Text = "";
                        if (Convert.ToInt32(txtDec1.Text) < 128)
                        {
                            txtClasse.Text = "A";
                        }
                        else
                        {
                            if (Convert.ToInt32(txtDec1.Text) < 192)
                            {
                                txtClasse.Text = "B";
                            }
                            else
                            {
                                if (Convert.ToInt32(txtDec1.Text) < 224)
                                {
                                    txtClasse.Text = "C";
                                }
                                else
                                {
                                    if (Convert.ToInt32(txtDec1.Text) < 240)
                                    {
                                        txtClasse.Text = "D";
                                        lblRFC.Text = "Adresse non utilisable (Multicast)";
                                    }
                                    else
                                    {
                                        if (Convert.ToInt32(txtDec1.Text) < 256)
                                        {
                                            txtClasse.Text = "E";
                                            lblRFC.Text = "Adresse non utilisable (Reserved for Future Use)";
                                        }
                                    }
                                }
                            }
                        }
                        if (txtDec1.Text == "0")
                        {
                            lblRFC.Text = "Adresse non utilisable (\"This\" Network)";
                        }
                        if (txtDec1.Text == "10")
                        {
                            lblRFC.Text = "Adresse non routable (Private-Use Networks)";
                        }
                        if (txtDec1.Text == "127")
                        {
                            lblRFC.Text = "Adresse non utilisable (Loopback)";
                        }
                        if (txtDec1.Text == "169" && txtDec2.Text == "254")
                        {
                            lblRFC.Text = "Adresse non utilisable (Link Local)";
                        }
                        if (txtDec1.Text == "172" && Convert.ToInt32(txtDec2.Text) >= 16 && Convert.ToInt32(txtDec2.Text) < 32)
                        {
                            lblRFC.Text = "Adresse non routable (Private-Use Networks)";
                        }
                        if (txtDec1.Text == "192" && txtDec2.Text == "0" && txtDec3.Text == "0")
                        {
                            lblRFC.Text = "Adresse non utilisable (IETF Protocol Assignments)";
                        }
                        if (txtDec1.Text == "192" && txtDec2.Text == "0" && txtDec3.Text == "2")
                        {
                            lblRFC.Text = "Adresse non utilisable (TEST-NET-1)";
                        }
                        if (txtDec1.Text == "192" && txtDec2.Text == "88" && txtDec3.Text == "99")
                        {
                            lblRFC.Text = "Adresse non utilisable (6to4 Relay Anycast)";
                        }
                        if (txtDec1.Text == "192" && txtDec2.Text == "168")
                        {
                            lblRFC.Text = "Adresse non routable (Private-Use Networks)";
                        }
                        if (txtDec1.Text == "198" && Convert.ToInt32(txtDec2.Text) >= 18 && Convert.ToInt32(txtDec2.Text) < 20)
                        {
                            lblRFC.Font = new Font("Segoe UI", 7);
                            lblRFC.Text = "Adresse non utilisable (Network Interconnect Device Benchmark Testing)";
                        }
                        if (txtDec1.Text == "198" && txtDec2.Text == "51" && txtDec3.Text == "100")
                        {
                            lblRFC.Text = "Adresse non utilisable (TEST-NET-2)";
                        }
                        if (txtDec1.Text == "203" && txtDec2.Text == "0" && txtDec3.Text == "113")
                        {
                            lblRFC.Text = "Adresse non utilisable (TEST-NET-3)";
                        }
                        byte[] ip = new byte[4];
                        byte[] ipNet = new byte[4];
                        byte[] ipBroad = new byte[4];
                        byte[] firstIp = new byte[4];
                        byte[] lastIp = new byte[4];
                        byte[] masque = new byte[4];
                        int nbIp = (int)Math.Pow(2, 32 - Convert.ToInt32(txtCIDR.Text));

                        txtNbIP.Text = Convert.ToString(nbIp);
                        txtNbMachines.Text = Convert.ToString(nbIp - 2);
                        ip[0] = Convert.ToByte(txtDec1.Text);
                        ip[1] = Convert.ToByte(txtDec2.Text);
                        ip[2] = Convert.ToByte(txtDec3.Text);
                        ip[3] = Convert.ToByte(txtDec4.Text);

                        masque[0] = Convert.ToByte(txtMasque1.Text);
                        masque[1] = Convert.ToByte(txtMasque2.Text);
                        masque[2] = Convert.ToByte(txtMasque3.Text);
                        masque[3] = Convert.ToByte(txtMasque4.Text);

                        ipNet[0] = Convert.ToByte(ip[0] & masque[0]);
                        ipNet[1] = Convert.ToByte(ip[1] & masque[1]);
                        ipNet[2] = Convert.ToByte(ip[2] & masque[2]);
                        ipNet[3] = Convert.ToByte(ip[3] & masque[3]);

                        ipBroad[0] = Convert.ToByte(ipNet[0] | (byte)~masque[0]);
                        ipBroad[1] = Convert.ToByte(ipNet[1] | (byte)~masque[1]);
                        ipBroad[2] = Convert.ToByte(ipNet[2] | (byte)~masque[2]);
                        ipBroad[3] = Convert.ToByte(ipNet[3] | (byte)~masque[3]);

                        if (txtCIDR.Text == "31")
                        {
                            firstIp[3] = Convert.ToByte(ipNet[3]);
                            lastIp[3] = Convert.ToByte(ipBroad[3]);
                        }
                        else
                        {
                            firstIp[3] = Convert.ToByte(ipNet[3] + Convert.ToByte(1));
                            lastIp[3] = Convert.ToByte((ipBroad[3]) - Convert.ToByte(1));
                        }
                        firstIp[0] = Convert.ToByte(ipNet[0]);
                        firstIp[1] = Convert.ToByte(ipNet[1]);
                        firstIp[2] = Convert.ToByte(ipNet[2]);

                        lastIp[0] = Convert.ToByte(ipBroad[0]);
                        lastIp[1] = Convert.ToByte(ipBroad[1]);
                        lastIp[2] = Convert.ToByte(ipBroad[2]);

                        txtNet1.Text = Convert.ToString(ipNet[0]);
                        txtNet2.Text = Convert.ToString(ipNet[1]);
                        txtNet3.Text = Convert.ToString(ipNet[2]);
                        txtNet4.Text = Convert.ToString(ipNet[3]);

                        txtBroad1.Text = Convert.ToString(ipBroad[0]);
                        txtBroad2.Text = Convert.ToString(ipBroad[1]);
                        txtBroad3.Text = Convert.ToString(ipBroad[2]);
                        txtBroad4.Text = Convert.ToString(ipBroad[3]);

                        txtFIP1.Text = Convert.ToString(firstIp[0]);
                        txtFIP2.Text = Convert.ToString(firstIp[1]);
                        txtFIP3.Text = Convert.ToString(firstIp[2]);
                        txtFIP4.Text = Convert.ToString(firstIp[3]);

                        txtLIP1.Text = Convert.ToString(lastIp[0]);
                        txtLIP2.Text = Convert.ToString(lastIp[1]);
                        txtLIP3.Text = Convert.ToString(lastIp[2]);
                        txtLIP4.Text = Convert.ToString(lastIp[3]);
                    }
                }
            }
        }
    }
}