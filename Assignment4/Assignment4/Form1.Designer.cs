﻿namespace Assignment4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sqFtUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.bathUpDown = new System.Windows.Forms.NumericUpDown();
            this.bedUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.attachedCheckBox = new System.Windows.Forms.CheckBox();
            this.garageCheckBox = new System.Windows.Forms.CheckBox();
            this.apartmentCheckBox = new System.Windows.Forms.CheckBox();
            this.houseCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.residenceDistanceUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.For_Sale_Residence_ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.schoolDistanceUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.schoolComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarMax = new System.Windows.Forms.TrackBar();
            this.trackBarMin = new System.Windows.Forms.TrackBar();
            this.businessCheckBox = new System.Windows.Forms.CheckBox();
            this.schoolCheckBox = new System.Windows.Forms.CheckBox();
            this.residentialCheckBox = new System.Windows.Forms.CheckBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqFtUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residenceDistanceUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDistanceUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1434, 770);
            this.panel1.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(661, 484);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(437, 69);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Location = new System.Drawing.Point(460, 19);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 400);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.test);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 770);
            this.panel2.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchButton.Location = new System.Drawing.Point(4, 570);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(432, 35);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sqFtUpDown);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.bathUpDown);
            this.groupBox4.Controls.Add(this.bedUpDown);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.attachedCheckBox);
            this.groupBox4.Controls.Add(this.garageCheckBox);
            this.groupBox4.Controls.Add(this.apartmentCheckBox);
            this.groupBox4.Controls.Add(this.houseCheckBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(4, 438);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(432, 122);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Specific Residence Paraemeters";
            // 
            // sqFtUpDown
            // 
            this.sqFtUpDown.Increment = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.sqFtUpDown.Location = new System.Drawing.Point(320, 46);
            this.sqFtUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sqFtUpDown.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.sqFtUpDown.Minimum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.sqFtUpDown.Name = "sqFtUpDown";
            this.sqFtUpDown.Size = new System.Drawing.Size(104, 26);
            this.sqFtUpDown.TabIndex = 7;
            this.sqFtUpDown.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Min Sq.Ft.";
            // 
            // bathUpDown
            // 
            this.bathUpDown.Location = new System.Drawing.Point(252, 46);
            this.bathUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bathUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.bathUpDown.Name = "bathUpDown";
            this.bathUpDown.Size = new System.Drawing.Size(52, 26);
            this.bathUpDown.TabIndex = 6;
            this.bathUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bedUpDown
            // 
            this.bedUpDown.Location = new System.Drawing.Point(183, 46);
            this.bedUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bedUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.bedUpDown.Name = "bedUpDown";
            this.bedUpDown.Size = new System.Drawing.Size(52, 26);
            this.bedUpDown.TabIndex = 5;
            this.bedUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bath";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bed";
            // 
            // attachedCheckBox
            // 
            this.attachedCheckBox.AutoSize = true;
            this.attachedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachedCheckBox.Location = new System.Drawing.Point(286, 82);
            this.attachedCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.attachedCheckBox.Name = "attachedCheckBox";
            this.attachedCheckBox.Size = new System.Drawing.Size(110, 24);
            this.attachedCheckBox.TabIndex = 4;
            this.attachedCheckBox.Text = "Attached?";
            this.attachedCheckBox.UseVisualStyleBackColor = true;
            this.attachedCheckBox.Visible = false;
            // 
            // garageCheckBox
            // 
            this.garageCheckBox.AutoSize = true;
            this.garageCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garageCheckBox.Location = new System.Drawing.Point(142, 82);
            this.garageCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.garageCheckBox.Name = "garageCheckBox";
            this.garageCheckBox.Size = new System.Drawing.Size(90, 24);
            this.garageCheckBox.TabIndex = 3;
            this.garageCheckBox.Text = "Garage";
            this.garageCheckBox.UseVisualStyleBackColor = true;
            this.garageCheckBox.CheckedChanged += new System.EventHandler(this.garageCheckBox_CheckedChanged);
            // 
            // apartmentCheckBox
            // 
            this.apartmentCheckBox.AutoSize = true;
            this.apartmentCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentCheckBox.Location = new System.Drawing.Point(4, 46);
            this.apartmentCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.apartmentCheckBox.Name = "apartmentCheckBox";
            this.apartmentCheckBox.Size = new System.Drawing.Size(112, 24);
            this.apartmentCheckBox.TabIndex = 2;
            this.apartmentCheckBox.Text = "Apartment";
            this.apartmentCheckBox.UseVisualStyleBackColor = true;
            this.apartmentCheckBox.CheckedChanged += new System.EventHandler(this.apartmentCheckBox_CheckedChanged);
            // 
            // houseCheckBox
            // 
            this.houseCheckBox.AutoSize = true;
            this.houseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseCheckBox.Location = new System.Drawing.Point(4, 82);
            this.houseCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.houseCheckBox.Name = "houseCheckBox";
            this.houseCheckBox.Size = new System.Drawing.Size(84, 24);
            this.houseCheckBox.TabIndex = 1;
            this.houseCheckBox.Text = "House";
            this.houseCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.residenceDistanceUpDown);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.For_Sale_Residence_ComboBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(4, 335);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(432, 94);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiring Business(es) Close to For Sale Residence";
            // 
            // residenceDistanceUpDown
            // 
            this.residenceDistanceUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.residenceDistanceUpDown.Location = new System.Drawing.Point(310, 50);
            this.residenceDistanceUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.residenceDistanceUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.residenceDistanceUpDown.Name = "residenceDistanceUpDown";
            this.residenceDistanceUpDown.Size = new System.Drawing.Size(112, 27);
            this.residenceDistanceUpDown.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Distance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "For-Sale Residence";
            // 
            // For_Sale_Residence_ComboBox
            // 
            this.For_Sale_Residence_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.For_Sale_Residence_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.For_Sale_Residence_ComboBox.FormattingEnabled = true;
            this.For_Sale_Residence_ComboBox.Location = new System.Drawing.Point(4, 50);
            this.For_Sale_Residence_ComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.For_Sale_Residence_ComboBox.Name = "For_Sale_Residence_ComboBox";
            this.For_Sale_Residence_ComboBox.Size = new System.Drawing.Size(298, 28);
            this.For_Sale_Residence_ComboBox.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.schoolDistanceUpDown);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.schoolComboBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(4, 228);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(432, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "For Sale Residence Close to a School";
            // 
            // schoolDistanceUpDown
            // 
            this.schoolDistanceUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.schoolDistanceUpDown.Location = new System.Drawing.Point(314, 50);
            this.schoolDistanceUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schoolDistanceUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.schoolDistanceUpDown.Name = "schoolDistanceUpDown";
            this.schoolDistanceUpDown.Size = new System.Drawing.Size(112, 26);
            this.schoolDistanceUpDown.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "School";
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schoolComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Location = new System.Drawing.Point(4, 50);
            this.schoolComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(298, 28);
            this.schoolComboBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.trackBarMax);
            this.groupBox1.Controls.Add(this.trackBarMin);
            this.groupBox1.Controls.Add(this.businessCheckBox);
            this.groupBox1.Controls.Add(this.schoolCheckBox);
            this.groupBox1.Controls.Add(this.residentialCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(4, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(432, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "For Sale Properties Within Price Range";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Min Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Max Price";
            // 
            // trackBarMax
            // 
            this.trackBarMax.Location = new System.Drawing.Point(172, 130);
            this.trackBarMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBarMax.Name = "trackBarMax";
            this.trackBarMax.Size = new System.Drawing.Size(156, 69);
            this.trackBarMax.TabIndex = 4;
            this.trackBarMax.Scroll += new System.EventHandler(this.scrollMaxPrice);
            // 
            // trackBarMin
            // 
            this.trackBarMin.Location = new System.Drawing.Point(172, 52);
            this.trackBarMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBarMin.Name = "trackBarMin";
            this.trackBarMin.Size = new System.Drawing.Size(156, 69);
            this.trackBarMin.TabIndex = 3;
            this.trackBarMin.Scroll += new System.EventHandler(this.scrollMinPrice);
            // 
            // businessCheckBox
            // 
            this.businessCheckBox.AutoSize = true;
            this.businessCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessCheckBox.Location = new System.Drawing.Point(9, 74);
            this.businessCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.businessCheckBox.Name = "businessCheckBox";
            this.businessCheckBox.Size = new System.Drawing.Size(105, 24);
            this.businessCheckBox.TabIndex = 2;
            this.businessCheckBox.Text = "Business";
            this.businessCheckBox.UseVisualStyleBackColor = true;
            // 
            // schoolCheckBox
            // 
            this.schoolCheckBox.AutoSize = true;
            this.schoolCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolCheckBox.Location = new System.Drawing.Point(9, 118);
            this.schoolCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schoolCheckBox.Name = "schoolCheckBox";
            this.schoolCheckBox.Size = new System.Drawing.Size(86, 24);
            this.schoolCheckBox.TabIndex = 1;
            this.schoolCheckBox.Text = "School";
            this.schoolCheckBox.UseVisualStyleBackColor = true;
            // 
            // residentialCheckBox
            // 
            this.residentialCheckBox.AutoSize = true;
            this.residentialCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residentialCheckBox.Location = new System.Drawing.Point(9, 30);
            this.residentialCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.residentialCheckBox.Name = "residentialCheckBox";
            this.residentialCheckBox.Size = new System.Drawing.Size(118, 24);
            this.residentialCheckBox.TabIndex = 0;
            this.residentialCheckBox.Text = "Residential";
            this.residentialCheckBox.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(460, 421);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(750, 26);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1212, 19);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 400);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1434, 770);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASX Real Estate Map";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqFtUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bathUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.residenceDistanceUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDistanceUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox attachedCheckBox;
        private System.Windows.Forms.CheckBox garageCheckBox;
        private System.Windows.Forms.CheckBox apartmentCheckBox;
        private System.Windows.Forms.CheckBox houseCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox For_Sale_Residence_ComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBarMax;
        private System.Windows.Forms.TrackBar trackBarMin;
        private System.Windows.Forms.CheckBox businessCheckBox;
        private System.Windows.Forms.CheckBox schoolCheckBox;
        private System.Windows.Forms.CheckBox residentialCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.NumericUpDown sqFtUpDown;
        private System.Windows.Forms.NumericUpDown bathUpDown;
        private System.Windows.Forms.NumericUpDown bedUpDown;
        private System.Windows.Forms.NumericUpDown residenceDistanceUpDown;
        private System.Windows.Forms.NumericUpDown schoolDistanceUpDown;
        private System.Windows.Forms.ComboBox schoolComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}
