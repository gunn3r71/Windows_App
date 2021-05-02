using System;
using System.Collections.Generic;
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

            //DataSource é a propriedade que recebe a collection no objeto
            //this.dgvEstados.DataSource = Estado.RetornaEstados(); (*Pega todos as propriedades da sua propriedade e exibem*)
            this.dgvEstados.ColumnCount = 2;
            this.dgvEstados.Columns[0].Name = "Id";
            this.dgvEstados.Columns[1].Name = "Nome";
            var rows = new List<string[]>();
            foreach(var estado in Estado.RetornaEstados())
            {
                rows.Add(new string[] { estado.Id.ToString(),estado.Nome});
            }

            foreach (var row in rows)
            {
                dgvEstados.Rows.Add(row);
            }

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
