using System;
using System.Windows.Forms;

namespace Windows_App
{
    public partial class FrmNovoForm : Form
    {
        public FrmNovoForm()
        {
            InitializeComponent();
        }

        public FrmNovoForm(string texto) : this()
        {
            this.lblMensagem.Text = texto;
        }

        private void FrmNovoForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }
    }
}
