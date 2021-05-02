
namespace Windows_App
{
    partial class FrmNovoForm
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.CboStatusUsuario = new System.Windows.Forms.ComboBox();
            this.lblUserState = new System.Windows.Forms.Label();
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMensagem.Location = new System.Drawing.Point(99, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(67, 15);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Combobox";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 188);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(235, 29);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
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
            this.lblUserState.Location = new System.Drawing.Point(13, 59);
            this.lblUserState.Name = "lblUserState";
            this.lblUserState.Size = new System.Drawing.Size(170, 15);
            this.lblUserState.TabIndex = 3;
            this.lblUserState.Text = "Selecione um status de usuário";
            // 
            // dgvEstados
            // 
            this.dgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstados.Location = new System.Drawing.Point(335, 59);
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.RowTemplate.Height = 25;
            this.dgvEstados.Size = new System.Drawing.Size(464, 196);
            this.dgvEstados.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Meu GridView";
            // 
            // FrmNovoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstados);
            this.Controls.Add(this.lblUserState);
            this.Controls.Add(this.CboStatusUsuario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblMensagem);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmNovoForm";
            this.Text = "frmNovoForm";
            this.Load += new System.EventHandler(this.FrmNovoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox CboStatusUsuario;
        private System.Windows.Forms.Label lblUserState;
        private System.Windows.Forms.DataGridView dgvEstados;
        private System.Windows.Forms.Label label1;
    }
}