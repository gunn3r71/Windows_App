
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
            this.btnVoltar.Location = new System.Drawing.Point(12, 194);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(235, 23);
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
            // FrmNovoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 229);
            this.Controls.Add(this.lblUserState);
            this.Controls.Add(this.CboStatusUsuario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblMensagem);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmNovoForm";
            this.Text = "frmNovoForm";
            this.Load += new System.EventHandler(this.FrmNovoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox CboStatusUsuario;
        private System.Windows.Forms.Label lblUserState;
    }
}