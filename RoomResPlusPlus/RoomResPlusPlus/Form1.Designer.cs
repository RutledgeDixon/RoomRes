using System.Drawing;
using System.Windows.Forms;

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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.roomFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateCalendar = new System.Windows.Forms.MonthCalendar();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.roomInfoPanel = new System.Windows.Forms.Panel();
            this.reservationList = new System.Windows.Forms.ListBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayMonth = new System.Windows.Forms.Label();
            this.displayDay = new System.Windows.Forms.Label();
            this.displayYear = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.roomInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.roomFlowPanel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
<<<<<<< HEAD
            this.panel3.Location = new System.Drawing.Point(874, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 691);

=======
            this.panel3.Location = new System.Drawing.Point(583, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 449);
>>>>>>> parent of 6941f8d (E)
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // roomFlowPanel
            // 
<<<<<<< HEAD
            this.roomFlowPanel.Location = new System.Drawing.Point(9, 278);
            this.roomFlowPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomFlowPanel.Name = "roomFlowPanel";
            this.roomFlowPanel.Size = new System.Drawing.Size(312, 395);
=======
            this.roomFlowPanel.Location = new System.Drawing.Point(6, 181);
            this.roomFlowPanel.Name = "roomFlowPanel";
            this.roomFlowPanel.Size = new System.Drawing.Size(208, 257);
>>>>>>> parent of 6941f8d (E)
            this.roomFlowPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(3, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 106);
=======
            this.label3.Location = new System.Drawing.Point(2, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 69);
>>>>>>> parent of 6941f8d (E)
            this.label3.TabIndex = 3;
            this.label3.Text = "Select a highlighted room for more details";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "FloorSelector";
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
<<<<<<< HEAD
            this.comboBox1.Location = new System.Drawing.Point(69, 129);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);

=======
            this.comboBox1.Location = new System.Drawing.Point(46, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
>>>>>>> parent of 6941f8d (E)
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.floorSelection);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(0, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 75);

=======
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 49);
>>>>>>> parent of 6941f8d (E)
            this.label2.TabIndex = 1;
            this.label2.Text = "Location Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 49);

=======
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
>>>>>>> parent of 6941f8d (E)
            this.label1.TabIndex = 0;
            this.label1.Text = "Building Selected:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
<<<<<<< HEAD
            this.panel5.Location = new System.Drawing.Point(116, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(758, 697);

=======
            this.panel5.Location = new System.Drawing.Point(77, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(505, 453);
>>>>>>> parent of 6941f8d (E)
            this.panel5.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RoomResPlusPlus.Properties.Resources.CampusMap;
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Controls.Add(this.roomInfoPanel);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 450);
            this.panel2.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.AccessibleName = "Menu_Tree";
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.treeView1.CausesValidation = false;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.HotTracking = true;
<<<<<<< HEAD
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(260, 44);

=======
            this.treeView1.Location = new System.Drawing.Point(3, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(175, 30);
>>>>>>> parent of 6941f8d (E)
            this.treeView1.TabIndex = 1;
            this.treeView1.Visible = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // roomInfoPanel
            // 
            this.panel2.BackgroundImage = global::RoomResPlusPlus.Properties.Resources.CampusMap;
            this.panel2.Controls.Add(this.dateCalendar);
            this.panel2.Controls.Add(this.roomInfoPanel);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 692);
            this.panel2.TabIndex = 3;
            this.roomInfoPanel.Controls.Add(this.reservationList);
            this.roomInfoPanel.Controls.Add(this.errorLabel);
            this.roomInfoPanel.Controls.Add(this.label5);
            this.roomInfoPanel.Controls.Add(this.label4);
            this.roomInfoPanel.Controls.Add(this.dateTimePicker2);
            this.roomInfoPanel.Controls.Add(this.button5);
            this.roomInfoPanel.Controls.Add(this.dateTimePicker1);
            this.roomInfoPanel.Location = new System.Drawing.Point(127, 0);
            this.roomInfoPanel.Name = "roomInfoPanel";
            this.roomInfoPanel.Size = new System.Drawing.Size(385, 193);
            this.roomInfoPanel.TabIndex = 4;
            this.roomInfoPanel.Visible = false;
            // 
            // reservationList
            // 
            this.reservationList.FormattingEnabled = true;
            this.reservationList.Items.AddRange(new object[] {
            "Ligma Balls"});
            this.reservationList.Location = new System.Drawing.Point(4, 12);
            this.reservationList.Name = "reservationList";
            this.reservationList.Size = new System.Drawing.Size(367, 95);
            this.reservationList.TabIndex = 6;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Coral;
            this.errorLabel.Location = new System.Drawing.Point(3, 108);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(369, 15);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "Error: Conflict with existing reservation.  Please pick a different time";
            this.errorLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(145, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(145, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "From";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(178, 130);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 49);
            this.button5.TabIndex = 1;
            this.button5.Text = "Make Reservation";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateCalendar
            // 
            this.dateCalendar.Location = new System.Drawing.Point(9, 430);
            this.dateCalendar.Name = "dateCalendar";
            this.dateCalendar.TabIndex = 0;
            this.dateCalendar.Visible = false;
            // 
            // roomInfoPanel
            // 
            this.roomInfoPanel.Location = new System.Drawing.Point(190, 0);
            this.roomInfoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomInfoPanel.Name = "roomInfoPanel";
            this.roomInfoPanel.Size = new System.Drawing.Size(578, 297);
            this.roomInfoPanel.TabIndex = 4;
            this.roomInfoPanel.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button4.FlatAppearance.BorderSize = 5;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< HEAD
            this.button4.Location = new System.Drawing.Point(258, 325);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 83);

=======
            this.button4.Location = new System.Drawing.Point(172, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 54);
>>>>>>> parent of 6941f8d (E)
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Building_selected);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button3.FlatAppearance.BorderSize = 5;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< HEAD
            this.button3.Location = new System.Drawing.Point(369, 338);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 97);

=======
            this.button3.Location = new System.Drawing.Point(246, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 63);
>>>>>>> parent of 6941f8d (E)
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Building_selected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 697);

=======
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 453);
>>>>>>> parent of 6941f8d (E)
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.displayMonth);
            this.panel1.Controls.Add(this.displayDay);
            this.panel1.Controls.Add(this.displayYear);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.datePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 692);

=======
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 389);
>>>>>>> parent of 6941f8d (E)
            this.panel1.TabIndex = 0;
            // 
            // displayMonth
            // 
            this.displayMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.displayMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.displayMonth.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMonth.ForeColor = System.Drawing.SystemColors.Window;
            this.displayMonth.Location = new System.Drawing.Point(25, 450);
            this.displayMonth.Name = "displayMonth";
            this.displayMonth.Size = new System.Drawing.Size(56, 34);
            this.displayMonth.TabIndex = 7;
            this.displayMonth.Text = "1";
            this.displayMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayDay
            // 
            this.displayDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.displayDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.displayDay.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDay.ForeColor = System.Drawing.SystemColors.Window;
            this.displayDay.Location = new System.Drawing.Point(25, 500);
            this.displayDay.Name = "displayDay";
            this.displayDay.Size = new System.Drawing.Size(56, 34);
            this.displayDay.TabIndex = 6;
            this.displayDay.Text = "1";
            this.displayDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.displayDay.Click += new System.EventHandler(this.label4_Click);
            // 
            // displayYear
            // 
            this.displayYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.displayYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.displayYear.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayYear.ForeColor = System.Drawing.SystemColors.Window;
            this.displayYear.Location = new System.Drawing.Point(25, 550);
            this.displayYear.Name = "displayYear";
            this.displayYear.Size = new System.Drawing.Size(56, 34);
            this.displayYear.TabIndex = 5;
            this.displayYear.Text = "84";
            this.displayYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.displayYear.Click += new System.EventHandler(this.displayDate_Click);
            // 
            // datePicker
            // 
            this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.datePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.datePicker.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.ForeColor = System.Drawing.Color.White;
            this.datePicker.Location = new System.Drawing.Point(3, 602);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(99, 87);
            this.datePicker.TabIndex = 0;
            this.datePicker.Text = "Change Date";
            this.datePicker.UseVisualStyleBackColor = false;
            this.datePicker.Click += new System.EventHandler(this.datePicker_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "Tree_Butt";
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 108);

=======
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
>>>>>>> parent of 6941f8d (E)
            this.button2.TabIndex = 0;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datePanel
            // 
            this.datePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.datePanel.BackColor = System.Drawing.Color.Transparent;
            this.datePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datePanel.Location = new System.Drawing.Point(12, 414);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(80, 182);
            this.datePanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(12, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(RoomResPlusPlus.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.roomInfoPanel.ResumeLayout(false);
            this.roomInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel roomInfoPanel;
        private System.Windows.Forms.FlowLayoutPanel roomFlowPanel;
        private System.Windows.Forms.MonthCalendar dateCalendar;
        private System.Windows.Forms.Button datePicker;
        private System.Windows.Forms.Label displayYear;
        private System.Windows.Forms.Label displayMonth;
        private System.Windows.Forms.Label displayDay;
        private Panel datePanel;
        private Label label4;
        private System.Windows.Forms.ListBox reservationList;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

