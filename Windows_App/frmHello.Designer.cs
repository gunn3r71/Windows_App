
namespace Windows_App
{
    partial class frmHello
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblRecebeOla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(59, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(110, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Hello World";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(6, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Digite seu nome";
            this.txtNome.Size = new System.Drawing.Size(210, 25);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(76, 97);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 37);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Ok";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // lblRecebeOla
            // 
            this.lblRecebeOla.AutoSize = true;
            this.lblRecebeOla.Location = new System.Drawing.Point(93, 155);
            this.lblRecebeOla.Name = "lblRecebeOla";
            this.lblRecebeOla.Size = new System.Drawing.Size(30, 14);
            this.lblRecebeOla.TabIndex = 3;
            this.lblRecebeOla.Text = "Olá, ";
            this.lblRecebeOla.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRecebeOla.Visible = false;
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(222, 228);
            this.ControlBox = false;
            this.Controls.Add(this.lblRecebeOla);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmHello";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ok";
            this.Load += new System.EventHandler(this.frmHello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblRecebeOla;
    }
}

