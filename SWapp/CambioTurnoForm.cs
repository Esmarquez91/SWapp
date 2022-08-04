using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWapp
{
    public partial class CambioTurnoForm : Form
    {
        public CambioTurnoForm()
        {
            InitializeComponent();
        }

        private void CambioTurnoForm_Load(object sender, EventArgs e)
        {
            
            
        }

        int countnodes = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            if(treeView1.SelectedNode!=null)
            {
                foreach(string linea in textBox1.Lines)
                {
                    if (linea.Length <= 45)
                    {
                        //treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                        treeView1.SelectedNode.Nodes.Add(linea);
                    }
                    else
                    {
                        int caracteres = linea.Length;
                        string line = "";
                        int CuentaCaracteres = 0;
                        for (int i = 0; i < caracteres; i++)
                        {
                            CuentaCaracteres++;
                            line = line + linea.Substring(i, 1);
                            if (CuentaCaracteres >= 45)
                            {
                                if ((linea.Substring(i, 1) == " ")&&(CuentaCaracteres<60)) { treeView1.SelectedNode.Nodes.Add(line); line = ""; CuentaCaracteres = 0; }
                                else if(CuentaCaracteres>=60)
                                {
                                    MessageBox.Show("Palabra larga");
                                    CuentaCaracteres = 0;
                                    treeView1.SelectedNode.Nodes.Add(line); line = "";
                                }
                            }
                            //if (Convert.ToChar(linea.Substring(i, 1)) == (char)13) { treeView1.SelectedNode.Nodes.Add(line); line = ""; }
                            //if ((line.Length >= 45) && (linea.Substring(i, 1) == " ")) { treeView1.SelectedNode.Nodes.Add(line); line = ""; }
                        }
                        if (line != "") { treeView1.SelectedNode.Nodes.Add(line); line = ""; }
                        //if (line.Length > 0) { treeView1.SelectedNode.Nodes.Add(line); line = ""; }
                    }
                }
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            countnodes = treeView1.GetNodeCount(false);
            //treeView1.Nodes.Add("Pendiente" + (countnodes + 1).ToString());

            TreeNode Node = new TreeNode("Pendiente" + (countnodes + 1).ToString());
            
            Font f = new Font("Comic Sans MS",10,FontStyle.Bold);
            Node.NodeFont = f;
            treeView1.CheckBoxes = true;
            treeView1.ShowLines = false;
            treeView1.Nodes.Add(Node);
        }

        
    }
}
