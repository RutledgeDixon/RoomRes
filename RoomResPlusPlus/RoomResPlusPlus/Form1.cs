using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomResPlusPlus
{
    public partial class Form1 : Form
    {
        bool treeView_invisible = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add root nodes
            TreeNode rootNode1 = new TreeNode("Help");
            TreeNode rootNode2 = new TreeNode("Settings");

            // Add child nodes
            rootNode1.Nodes.Add("About");
            rootNode1.Nodes.Add("Instructions");
            rootNode2.Nodes.Add("Dark Mode");

            // Add root nodes to TreeView
            treeView1.Nodes.Add(rootNode1);
            treeView1.Nodes.Add(rootNode2);

            // Customize appearance
            //treeView1.BackColor = Color.Black;
            treeView1.ForeColor = Color.White;
            treeView1.Font = new Font("Arial", 16, FontStyle.Regular);

            // Handle AfterSelect event
            treeView1.AfterSelect += treeView1_AfterSelect;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView_invisible)
            {
                treeView1.Visible = true;
                treeView_invisible = false;
                button2.Text = "<";
            }
            else
            {
                treeView1.Visible = false;
                treeView_invisible = true;
                button2.Text = ">";
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Text == "About")
            {
                MessageBox.Show("Room Reservation++\r\nWritten by Josh, Rutledge, and Will\r\nSP25 SE1 Project");
            }
            else if(e.Node.Text == "Instructions")
            {
                MessageBox.Show("1. Click on the building you want to reserve a room in.\r\n2. Select a floor (if appllicable).\r\n3. Select an available room and create a schedule");
            }
            else
            {
                MessageBox.Show("Selected Node: " + e.Node.Text);
            }      
        }
    }
}
