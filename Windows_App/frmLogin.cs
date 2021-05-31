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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private Usuario Usuario { get; set; }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Usuario.NomeUsuario = "j";
            this.Usuario.Senha = 47777;
            this.Usuario.Gravar(); //iniciando arquivo, simulando banco
            try
            {
                var usuario = (!string.IsNullOrEmpty(txtUsuario.Text)) ? txtUsuario.Text : null;
                var senha = (!string.IsNullOrEmpty(txtSenha.Text)) ? txtSenha.Text : null;

                if (usuario == null || senha == null)
                    throw new Exception("Preencha todos os campos!");

                var resultado = this.Usuario.Logado(new Usuario { NomeUsuario = usuario, Senha = int.Parse(senha)});
                if (resultado)
                {
                    this.Visible = false;
                    new FrmPrincipal().Show();
                } else
                {
                    MessageBox.Show("Verifique os dados digitados!", "Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
        }
    }
}
