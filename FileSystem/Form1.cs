using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;            //370881199709265329

namespace FileSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadDirectoryAndFile(@"H:\", treeView1.Nodes);
        }
        //将找到的文件和文件夹加载到节点上
        public void LoadDirectoryAndFile(string path,TreeNodeCollection tc)
        {
            try
            {
                //获取当前这一目录下所有文件夹的路径
                string[] dics = Directory.GetDirectories(path);
                for (int i = 0; i < dics.Length; i++)
                {
                    //从文件夹的全路径中截取出文件夹的名字
                    string dicName = Path.GetFileNameWithoutExtension(dics[i]);
                    //获得节点
                    TreeNode tn = tc.Add(dicName);
                    string[] fileName = Directory.GetFiles(dics[i]);
                    for (int j = 0; j < fileName.Length; j++)
                    {
                        Path.GetFileNameWithoutExtension(fileName[j]);
                        //记录全路径
                        tn.Tag = fileName[j];
                    }
                    LoadDirectoryAndFile(dics[i], tn.Nodes);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("出错啦！");
            }
          
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //获得选中的节点
            string path=treeView1.SelectedNode.Tag.ToString();
            textBox1.Text = File.ReadAllText(path, Encoding.Default);
        }
    }
}
