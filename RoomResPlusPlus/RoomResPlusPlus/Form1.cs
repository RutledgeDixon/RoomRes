﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomResPlusPlus
{
    public partial class Form1 : Form
    {
        bool treeView_invisible = true;
        object last_selected_building;
        Dictionary<Button, String> building_buttons = new Dictionary<Button, String>();
        public Form1()
        {
            InitializeComponent();
            building_buttons.Add(button3, "ASC"); building_buttons.Add(button4, "Library");
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void Building_selected(Object sended, EventArgs e)
        {
            panel3.Visible = true;
            if (sended is Button sender)
            {
                if ((last_selected_building != null) && (last_selected_building is Button temp) && (temp != sender))
                {
                    temp.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
                    sender.FlatAppearance.BorderColor = Color.LightYellow;
                    last_selected_building = sender;
                    String da_building;
                    building_buttons.TryGetValue(sender, out da_building);
                    panel3.Visible = true;
                    label2.Text = da_building;
                }
                else if ((last_selected_building is Button temp2) && (temp2 == sender))
                {
                    panel3.Visible = false;
                    sender.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
                }
            }
        }
    }
}
