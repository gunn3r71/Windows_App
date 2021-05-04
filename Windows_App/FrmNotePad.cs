using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_App.Classes;

namespace Windows_App
{
    public partial class FrmNotePad : Form
    {
        public FrmNotePad()
        {
            InitializeComponent();
        }

        private void FrmNotePad_Load(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var arquivo = new Arquivo();

            arquivo.Nome = "Meublocodenotas";
            arquivo.Texto = txtTexto.Text;

            arquivo.SalvarArquivo();

            MessageBox.Show("Arquivo salvo com sucesso!","Status");
        }
    }
}
