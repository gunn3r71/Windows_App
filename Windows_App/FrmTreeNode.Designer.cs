
namespace Windows_App
{
    partial class FrmTreeNode
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Filha 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Filha 2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Principal", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblNodeSelecionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodeFilha1";
            treeNode1.Text = "Filha 1";
            treeNode1.ToolTipText = "Filha 1";
            treeNode2.Name = "NodeFilha2";
            treeNode2.Text = "Filha 2";
            treeNode2.ToolTipText = "Filha 2";
            treeNode3.Name = "NodePrincipal";
            treeNode3.Text = "Principal";
            treeNode3.ToolTipText = "Node inicial";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(338, 326);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // lblNodeSelecionado
            // 
            this.lblNodeSelecionado.AutoSize = true;
            this.lblNodeSelecionado.Location = new System.Drawing.Point(243, 82);
            this.lblNodeSelecionado.Name = "lblNodeSelecionado";
            this.lblNodeSelecionado.Size = new System.Drawing.Size(0, 15);
            this.lblNodeSelecionado.TabIndex = 1;
            // 
            // FrmTreeNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 351);
            this.Controls.Add(this.lblNodeSelecionado);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTreeNode";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblNodeSelecionado;
    }
}