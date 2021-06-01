
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.CboStatusUsuario = new System.Windows.Forms.ComboBox();
            this.lblUserState = new System.Windows.Forms.Label();
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerHoraAtual = new System.Windows.Forms.Timer(this.components);
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMensagem.Location = new System.Drawing.Point(63, 32);
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
            this.dgvEstados.Location = new System.Drawing.Point(266, 62);
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.RowTemplate.Height = 25;
            this.dgvEstados.Size = new System.Drawing.Size(464, 175);
            this.dgvEstados.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Meu GridView";
            // 
            // TimerHoraAtual
            // 
            this.TimerHoraAtual.Interval = 1000;
            this.TimerHoraAtual.Tick += new System.EventHandler(this.TimerHoraAtual_Tick);
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.AutoSize = true;
            this.lblHoraAtual.Location = new System.Drawing.Point(539, 9);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(200, 15);
            this.lblHoraAtual.TabIndex = 7;
            this.lblHoraAtual.Text = "Data/Hora atual: 00/00/0000 00:00:00";
            this.lblHoraAtual.Click += new System.EventHandler(this.lblHoraAtual_Click);
            // 
            // Notify
            // 
            this.Notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "Teste de notificação";
            this.Notify.Visible = true;
            this.Notify.Click += new System.EventHandler(this.Notify_Click);
            this.Notify.DoubleClick += new System.EventHandler(this.Notify_DoubleClick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 403);
            this.ControlBox = false;
            this.Controls.Add(this.lblHoraAtual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstados);
            this.Controls.Add(this.lblUserState);
            this.Controls.Add(this.CboStatusUsuario);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FrmNovoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem Abrir;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer TimerHoraAtual;
        private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.NotifyIcon Notify;
    }
}