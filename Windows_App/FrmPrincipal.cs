using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Windows_App.Classes;

namespace Windows_App
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public FrmPrincipal(string texto) : this()
        {
            this.lblMensagem.Text = texto;
        }

        private void FrmNovoForm_Load(object sender, EventArgs e)
        {
            this.CboStatusUsuario.DataSource = Estado.RetornaEstados();
            this.CboStatusUsuario.Text = "Selecione um estado";

            var dados = from estado in Estado.RetornaEstados() //é como se fosse um foreach
                        where estado.Id == 1 || estado.Id == 3 // Faz um filtro do objeto retornado
                        orderby estado.Nome //Ordenando os dados por nome
                        select new
                        { //bloco que seleciona as propriedades que quero retornar
                            Id = estado.Id,
                            Name = estado.Nome
                        };
            dgvEstados.DataSource = dados.ToList(); //Transformando os dados retornados em lista e devolvendo
        }

        private void SairMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja realmente sair?","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Muito obrigado por utilizar nossa aplicação!!!");
                Application.Exit();
            }
        }

        private void NovoMenuItem_Click(object sender, EventArgs e)
        {
            var notepad = new FrmNotePad();
            notepad.ShowDialog();
        }
        
        private void ConteudoMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Implementando....");
            //Process.Start("https://www.torneseumprogramador.com.br");
        }
    }
}
