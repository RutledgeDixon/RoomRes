using System.Drawing;

namespace RoomResPlusPlus
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ASCButton = new System.Windows.Forms.Button();
            this.LibraryButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Hamburger = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ASCButton
            // 
            this.ASCButton.BackColor = System.Drawing.Color.Transparent;
            this.ASCButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ASCButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ASCButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ASCButton.Location = new System.Drawing.Point(447, 407);
            this.ASCButton.Name = "ASCButton";
            this.ASCButton.Size = new System.Drawing.Size(106, 92);
            this.ASCButton.TabIndex = 1;
            this.ASCButton.Text = "ASC";
            this.ASCButton.UseVisualStyleBackColor = false;
            this.ASCButton.Click += new System.EventHandler(this.ASCButton_Click);
            // 
            // LibraryButton
            // 
            this.LibraryButton.BackColor = System.Drawing.Color.Transparent;
            this.LibraryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LibraryButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LibraryButton.Location = new System.Drawing.Point(317, 389);
            this.LibraryButton.Name = "LibraryButton";
            this.LibraryButton.Size = new System.Drawing.Size(63, 76);
            this.LibraryButton.TabIndex = 2;
            this.LibraryButton.Text = "Library";
            this.LibraryButton.UseVisualStyleBackColor = false;
            this.LibraryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(326, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 58);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(459, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 58);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(94, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 123);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(326, 599);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 132);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.toolStripMenuItem2,
            this.darkModeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-4, 117);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(165, 154);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForRoomsToolStripMenuItem,
            this.searchByTimeToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(158, 36);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchForRoomsToolStripMenuItem
            // 
            this.searchForRoomsToolStripMenuItem.Name = "searchForRoomsToolStripMenuItem";
            this.searchForRoomsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.searchForRoomsToolStripMenuItem.Text = "Search for Rooms";
            // 
            // searchByTimeToolStripMenuItem
            // 
            this.searchByTimeToolStripMenuItem.Name = "searchByTimeToolStripMenuItem";
            this.searchByTimeToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.searchByTimeToolStripMenuItem.Text = "Search by Time";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBookingsToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(158, 36);
            this.toolStripMenuItem2.Text = "Bookings";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // viewBookingsToolStripMenuItem
            // 
            this.viewBookingsToolStripMenuItem.Name = "viewBookingsToolStripMenuItem";
            this.viewBookingsToolStripMenuItem.Size = new System.Drawing.Size(303, 44);
            this.viewBookingsToolStripMenuItem.Text = "View Bookings";
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(158, 36);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // Hamburger
            // 
            this.Hamburger.AutoSize = true;
            this.Hamburger.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Hamburger.Location = new System.Drawing.Point(-4, 0);
            this.Hamburger.Name = "Hamburger";
            this.Hamburger.Size = new System.Drawing.Size(137, 127);
            this.Hamburger.TabIndex = 8;
            this.Hamburger.UseVisualStyleBackColor = false;
            this.Hamburger.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1027, 815);
            this.Controls.Add(this.Hamburger);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LibraryButton);
            this.Controls.Add(this.ASCButton);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ASCButton;
        private System.Windows.Forms.Button LibraryButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Hamburger;
    }
}

