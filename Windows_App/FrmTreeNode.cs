using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_App
{
    public partial class FrmTreeNode : Form
    {
        public FrmTreeNode()
        {
            InitializeComponent();
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("Minhas pastas");
            var node = treeView1.Nodes[0];
            MinhasPastas(@"C:\Users\lucas\source\repos\", ref node);
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show($"{e.Node.Text}");
        }

        private void MinhasPastas(string path, ref TreeNode node) //ref evita clonagem de objeto
        {
            string[] meusArquivos = Directory.GetFiles(path);

            foreach (var arquivo in meusArquivos)
            {
                node.Nodes.Add(Path.GetFileName(arquivo));
            }

            string[] subdiretorios = Directory.GetDirectories(path);
            foreach (var subdiretorio in subdiretorios) 
            {
                TreeNode no = new TreeNode(Path.GetFileName(subdiretorio));
                MinhasPastas(subdiretorio, ref no);
                node.Nodes.Add(no);
            }
        }
    }
}
