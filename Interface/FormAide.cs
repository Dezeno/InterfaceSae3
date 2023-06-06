using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Interface
{
    public partial class FormAide : Form
    {
        public FormAide()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VLSM_FLSM frmVLSM = new VLSM_FLSM();
            frmVLSM.ShowDialog(this);
        }
    }
}