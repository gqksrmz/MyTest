using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //TreeNodeCollection：当前树状节点的集合，所有的数据都要添加到这个集合下
            treeView1.Nodes.Add(textRoot.Text.Trim());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //获得要添加子节点的根节点
            //获取当前选中的节点
            TreeNode tn=treeView1.SelectedNode;
            //每一个节点都可以看作是一个节点集合，因为可以无限的向下添加
            tn.Nodes.Add(textChild.Text);
        }
    }
}
