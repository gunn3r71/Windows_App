using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_App
{
    public partial class FrmHello : Form
    {
        public FrmHello()
        {
            //MessageBox.Show("Primeiro objeto a ser mostrado");
            InitializeComponent();
        }

        private void FrmHello_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Iniciando um form","Teste Hello");
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                lblRecebeOla.Text = $"Olá, {txtNome.Text}!";
                lblRecebeOla.Show();
            } else
            {
                MessageBox.Show("Informe um valor no input","Erro");
            }
        }

        private void BtnNovaJanela_Click(object sender, EventArgs e)
        {
            var novoForm = new FrmNovoForm();
            novoForm.Show();
        }
    }
}
