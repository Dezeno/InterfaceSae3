namespace Interface
{
    public partial class FormAide : Form
    {
        public FormAide()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VLSM_FLSM frmVLSM = new VLSM_FLSM();
            frmVLSM.ShowDialog(this);
        }
    }
}