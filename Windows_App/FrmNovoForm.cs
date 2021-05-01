using System;
using System.Windows.Forms;
using Windows_App.Classes;

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
            this.CboStatusUsuario.SelectedText = "Selecione um estado";
            this.CboStatusUsuario.Items.Add(Estado.RetornaEstados());
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
