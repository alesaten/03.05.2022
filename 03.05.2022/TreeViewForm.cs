using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03._05._2022
{
    public partial class TreeViewForm : Form
    {
        public TreeViewForm()
        {
            InitializeComponent();

            TreeNode continents = new TreeNode("Континенты");
            Continents_treeView.Nodes.Add(continents);

            Continents_treeView.Nodes[0].Nodes.Add(new TreeNode("Евразия"));
            Continents_treeView.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Австрия"));
            Continents_treeView.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Великобритания"));
            Continents_treeView.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Греция"));
            Continents_treeView.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Исландия"));
            Continents_treeView.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Норвегия"));
            Continents_treeView.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Россия"));
            Continents_treeView.Nodes[0].Nodes.Add(new TreeNode("Африка"));
            Continents_treeView.Nodes[0].Nodes.Add(new TreeNode("Северная Америка"));
            Continents_treeView.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("Мексика"));
            Continents_treeView.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("США"));
            Continents_treeView.Nodes[0].Nodes.Add(new TreeNode("Южная Америка"));
            Continents_treeView.Nodes[0].Nodes.Add(new TreeNode("Антарктида"));
            Continents_treeView.Nodes[0].Nodes.Add(new TreeNode("Австралия"));

            AddCheckBox_checkBox.CheckedChanged += AddCheckBox_checkBox_CheckedChanged;
            Expand_button.Click += Expand_button_Click;
            ExpandAll_button.Click += ExpandAll_button_Click;
            Collapse_button.Click += Collapse_button_Click;
        }

        void AddCheckBox_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddCheckBox_checkBox.Checked == true)
            {
                Continents_treeView.CheckBoxes = true;
            }
            else
            {
                Continents_treeView.CheckBoxes = false;
            }
        }

        void Expand_button_Click(object sender, EventArgs e)
        {
            Continents_treeView.Nodes[0].Expand();
        }

        void ExpandAll_button_Click(object sender, EventArgs e)
        {
            Continents_treeView.Nodes[0].ExpandAll();
        }

        void Collapse_button_Click(object sender, EventArgs e)
        {
            Continents_treeView.Nodes[0].Collapse();
        }
    }
}
