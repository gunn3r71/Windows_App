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
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void frmHello_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
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
    }
}
