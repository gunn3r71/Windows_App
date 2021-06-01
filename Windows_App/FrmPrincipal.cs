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
            TimerHoraAtual.Enabled = true;
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

            var contextMenu = new ContextMenuStrip();
            var menuItens = new ToolStripMenuItem[1];
            menuItens.Append(new ToolStripMenuItem("Novo bloco de notas"));
            menuItens.Append(new ToolStripMenuItem("Novo bloco de notas 2"));

            this.Notify.ContextMenuStrip = contextMenu;
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

        private void TimerHoraAtual_Tick(object sender, EventArgs e)
        {
            this.HoraAtual();
        }

        public void HoraAtual()
        {
            lblHoraAtual.Text = "Data/hora atual: "
                    + DateTime.UtcNow.ToString(format: "dd/MM/yyyy - HH:mm:ss");
        }

        private void CadastroMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Notify_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Teste de clique");
        }

        private void Notify_DoubleClick(object sender, EventArgs e)
        {
            this.Notify.ShowBalloonTip(300,"Teste","Teste double click",ToolTipIcon.Info);
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblHoraAtual_Click(object sender, EventArgs e)
        {

        }
    }
}
