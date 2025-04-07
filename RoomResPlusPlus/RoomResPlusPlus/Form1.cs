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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.Visible = true){
                button2.Text = "<";
                treeView1.Visible = false;
                treeView1
            }
            else
            {
                button2.Text = ">";
                treeView1.Visible = true;
            }
        }
    }
}
