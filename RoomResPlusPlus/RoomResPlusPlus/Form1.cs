using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RoomResPlusPlus
{
    public partial class Form1 : Form
    {
        bool treeView_invisible = true;
        bool darkMode = true;
        Dictionary<String, Array> jsonData;

        Button last_selected_building;
        Dictionary<Button, String> building_buttons = new Dictionary<Button, String>();
        public Form1()
        {
            InitializeComponent();
            building_buttons.Add(button3, "ASC"); building_buttons.Add(button4, "Library");
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            //var jason = File.ReadAllText("Data/mock_event_rooms.json");
            //jsonData = JsonConvert.DeserializeObject<Dictionary<String, Array>>(jason);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Unsubscribe to prevent duplicate subscriptions
            treeView1.AfterSelect -= treeView1_AfterSelect;

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

            AdjustTreeViewHeight(); // Adjust height based on node count

            // Handle AfterSelect event
            treeView1.AfterSelect += treeView1_AfterSelect;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView_invisible)
            {
                treeView1.Visible = true;
                treeView1.Refresh(); // Ensure the TreeView is refreshed
                //treeView1.Focus();   // Set focus to the TreeView
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
            
            if (e.Node.Text == "Help" || e.Node.Text == "Settings")
            {
                //do nothing
            }
            else if(e.Node.Text == "About")
            {
                MessageBox.Show("Room Reservation++\r\nWritten by Josh, Rutledge, and Will\r\nSP25 SE1 Project");
            }
            else if(e.Node.Text == "Instructions")
            {
                MessageBox.Show("1. Click on the building you want to reserve a room in.\r\n2. Select a floor (if appllicable).\r\n3. Select an available room and create a schedule");
            }
            else if(e.Node.Text == "Dark Mode")
            {
                String darkColor = "#444444";
                String blueColor = "#000040";

                if (darkMode == false)
                {
                    panel3.BackColor = ColorTranslator.FromHtml(blueColor);
                    panel1.BackColor = ColorTranslator.FromHtml("#FF8000");
                    panel5.BackColor = ColorTranslator.FromHtml(blueColor);
                    treeView1.BackColor = ColorTranslator.FromHtml(blueColor);
                    Form1.ActiveForm.BackColor = ColorTranslator.FromHtml(blueColor);

                    darkMode = true;
                }
                else
                {
                    panel3.BackColor = ColorTranslator.FromHtml(darkColor);
                    panel1.BackColor = ColorTranslator.FromHtml(darkColor);
                    panel5.BackColor = ColorTranslator.FromHtml(darkColor);
                    treeView1.BackColor = ColorTranslator.FromHtml(darkColor);
                    Form1.ActiveForm.BackColor = Color.Black;

                    darkMode = false;
                }

                //change the selected node to the parent node so that
                // this node can be clicked multiple times in a row
                treeView1.SelectedNode = e.Node.Parent;

            }
            else
            {
                MessageBox.Show("Selected Node: " + e.Node.Text);
            }      
        }

        private void AdjustTreeViewHeight()
        {
            int nodeHeight = treeView1.ItemHeight; // Height of a single node
            int totalNodes = GetTotalNodeCount(treeView1.Nodes); // Total number of nodes (including child nodes)
            int padding = 10; // Optional padding for aesthetics

            // Set the TreeView height based on the total node count
            treeView1.Height = (nodeHeight * totalNodes) + padding;
        }

        // Helper method to count all nodes (including child nodes)
        private int GetTotalNodeCount(TreeNodeCollection nodes)
        {
            int count = 0;
            foreach (TreeNode node in nodes)
            {
                count++; // Count the current node
                count += GetTotalNodeCount(node.Nodes); // Recursively count child nodes
            }
            return count;
        }
        private void Building_selected(Object sended, EventArgs e)
        {
            if (sended is Button sender)
            {
                panel3.Visible = true;
                if ((last_selected_building != null) && (last_selected_building != sender))
                {
                    last_selected_building.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
                }
                sender.FlatAppearance.BorderColor = Color.LightYellow;
                last_selected_building = sender;
                String da_building;
                building_buttons.TryGetValue(sender, out da_building);
                panel3.Visible = true;
                label2.Text = da_building;
                //Array dingy;
                //jsonData.TryGetValue(da_building, out dingy);
                //for (int i = 0; i < dingy.Length; i++)
                //{
                //    String temporary = "Floor " + String.Concat(i + 1);
                //    comboBox1.Items.Add(temporary);
                //}
                //comboBox1.SelectedIndex = 0;
                //floorSelection(comboBox1);
            }
        }

        private void floorSelection(object sender, EventArgs e = null)
        {
            if (sender is ComboBox comboTemp)
            {
                String floor = comboTemp.SelectedText;
            }
        }

        private void roomSelection(object sender, EventArgs e)
        {
            
        }
    }
}
