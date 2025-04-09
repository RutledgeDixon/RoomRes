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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Building_selected(Object sender, EventArgs e)
        {
            panel3.Visible = true;

            if (sender is Button buildingButton)
            {
                // Reset the border color of the previously selected building
                if (last_selected_building is Button previousButton && previousButton != buildingButton)
                {
                    previousButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
                }

                // Highlight the selected building
                buildingButton.FlatAppearance.BorderColor = Color.LightYellow;
                last_selected_building = buildingButton;

                // Get the building name
                if (building_buttons.TryGetValue(buildingButton, out string buildingName))
                {
                    label2.Text = buildingName;

                    // Show floor selection dropdown and location name
                    ShowFloorDropdown(buildingName);
                }
            }
        }

        private void ShowFloorDropdown(string buildingName)
        {
            panel3.Controls.Clear(); // Clear previous controls
            panel3.Visible = true; // Ensure the panel is visible

            // Add a label to display the location name
            Label locationLabel = new Label
            {
                Text = $"Location: {buildingName}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(10, 10) // Position at the top of the panel
            };
            panel3.Controls.Add(locationLabel);

            // Add a ComboBox for floor selection
            ComboBox floorDropdown = new ComboBox
            {
                Width = 150,
                Location = new Point(10, 40), // Position below the label
                DropDownStyle = ComboBoxStyle.DropDownList // Prevent user from typing
            };

            // Populate the ComboBox with floor numbers
            int numberOfFloors = buildingName == "ASC" ? 5 : 3; // Example: ASC has 5 floors, Library has 3
            for (int i = 1; i <= numberOfFloors; i++)
            {
                floorDropdown.Items.Add($"Floor {i}");
            }

            panel3.Controls.Add(floorDropdown);
        }
    }
}
