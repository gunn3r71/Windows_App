using System;
using System.Collections.Generic;
using System.Linq;
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

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
