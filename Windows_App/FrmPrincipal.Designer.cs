
namespace Windows_App
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.CboStatusUsuario = new System.Windows.Forms.ComboBox();
            this.lblUserState = new System.Windows.Forms.Label();
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ArquivoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NovoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SairMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjudaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConteudoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMensagem.Location = new System.Drawing.Point(12, 44);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(67, 15);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Combobox";
            // 
            // CboStatusUsuario
            // 
            this.CboStatusUsuario.FormattingEnabled = true;
            this.CboStatusUsuario.Location = new System.Drawing.Point(12, 80);
            this.CboStatusUsuario.Name = "CboStatusUsuario";
            this.CboStatusUsuario.Size = new System.Drawing.Size(235, 23);
            this.CboStatusUsuario.TabIndex = 2;
            // 
            // lblUserState
            // 
            this.lblUserState.AutoSize = true;
            this.lblUserState.Location = new System.Drawing.Point(12, 62);
            this.lblUserState.Name = "lblUserState";
            this.lblUserState.Size = new System.Drawing.Size(164, 15);
            this.lblUserState.TabIndex = 3;
            this.lblUserState.Text = "Selecione o estado do usuário";
            // 
            // dgvEstados
            // 
            this.dgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstados.Location = new System.Drawing.Point(335, 80);
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.RowTemplate.Height = 25;
            this.dgvEstados.Size = new System.Drawing.Size(464, 175);
            this.dgvEstados.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Meu GridView";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArquivoMenuItem,
            this.AjudaMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(811, 24);
            this.Menu.TabIndex = 6;
            // 
            // ArquivoMenuItem
            // 
            this.ArquivoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoMenuItem,
            this.toolStripSeparator,
            this.SairMenuItem});
            this.ArquivoMenuItem.Name = "ArquivoMenuItem";
            this.ArquivoMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ArquivoMenuItem.Text = "&Arquivo";
            // 
            // NovoMenuItem
            // 
            this.NovoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NovoMenuItem.Image")));
            this.NovoMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NovoMenuItem.Name = "NovoMenuItem";
            this.NovoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NovoMenuItem.Size = new System.Drawing.Size(146, 22);
            this.NovoMenuItem.Text = "&Novo";
            this.NovoMenuItem.Click += new System.EventHandler(this.NovoMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // SairMenuItem
            // 
            this.SairMenuItem.Name = "SairMenuItem";
            this.SairMenuItem.Size = new System.Drawing.Size(146, 22);
            this.SairMenuItem.Text = "&Sair";
            this.SairMenuItem.Click += new System.EventHandler(this.SairMenuItem_Click);
            // 
            // AjudaMenuItem
            // 
            this.AjudaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConteudoMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.AjudaMenuItem.Name = "AjudaMenuItem";
            this.AjudaMenuItem.Size = new System.Drawing.Size(50, 20);
            this.AjudaMenuItem.Text = "A&juda";
            // 
            // ConteudoMenuItem
            // 
            this.ConteudoMenuItem.Name = "ConteudoMenuItem";
            this.ConteudoMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ConteudoMenuItem.Text = "&Conteudo";
            this.ConteudoMenuItem.Click += new System.EventHandler(this.ConteudoMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(124, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstados);
            this.Controls.Add(this.lblUserState);
            this.Controls.Add(this.CboStatusUsuario);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmNovoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.ComboBox CboStatusUsuario;
        private System.Windows.Forms.Label lblUserState;
        private System.Windows.Forms.DataGridView dgvEstados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuArquivo;
        private System.Windows.Forms.ToolStripMenuItem menuInfo;
        private System.Windows.Forms.ToolStripMenuItem NovoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Abrir;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem ArquivoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConteudoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjudaMenuItem;
    }
}