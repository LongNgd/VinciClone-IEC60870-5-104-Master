namespace VinciClone
{
    partial class VinciClone
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Gi = new System.Windows.Forms.Button();
            this.btn_addTag = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.cb_TI = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.tb_IOA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ASDU = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.lv_stats = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mode:";
            this.label2.UseWaitCursor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(79, 154);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 68);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Connect";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.UseWaitCursor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Protocol:";
            this.label1.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 27);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "IEC 60870-5-104";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 27);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Master";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(659, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 27);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "2404";
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(659, 55);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(166, 27);
            this.tb_IP.TabIndex = 18;
            this.tb_IP.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(611, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Port:";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(627, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "IP:";
            this.label4.UseWaitCursor = true;
            // 
            // btn_Gi
            // 
            this.btn_Gi.BackColor = System.Drawing.Color.White;
            this.btn_Gi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Gi.ForeColor = System.Drawing.Color.Black;
            this.btn_Gi.Location = new System.Drawing.Point(893, 73);
            this.btn_Gi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Gi.Name = "btn_Gi";
            this.btn_Gi.Size = new System.Drawing.Size(193, 32);
            this.btn_Gi.TabIndex = 20;
            this.btn_Gi.Text = "General interogation";
            this.btn_Gi.UseVisualStyleBackColor = false;
            this.btn_Gi.UseWaitCursor = true;
            this.btn_Gi.Click += new System.EventHandler(this.btn_Gi_Click);
            // 
            // btn_addTag
            // 
            this.btn_addTag.BackColor = System.Drawing.Color.White;
            this.btn_addTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addTag.ForeColor = System.Drawing.Color.Black;
            this.btn_addTag.Location = new System.Drawing.Point(132, 340);
            this.btn_addTag.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addTag.Name = "btn_addTag";
            this.btn_addTag.Size = new System.Drawing.Size(122, 32);
            this.btn_addTag.TabIndex = 23;
            this.btn_addTag.Text = "Add";
            this.btn_addTag.UseVisualStyleBackColor = false;
            this.btn_addTag.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.tabControl2);
            this.groupBox1.Controls.Add(this.checkBox14);
            this.groupBox1.Controls.Add(this.tb_value);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(1176, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 724);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add tag";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(26, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(393, 184);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(26, 305);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(393, 413);
            this.tabControl2.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.btn_addTag);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.cb_TI);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.tb_IOA);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.tb_ASDU);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(385, 380);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "IEC60870-5-101/104";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtp_date);
            this.groupBox6.Controls.Add(this.checkBox7);
            this.groupBox6.Location = new System.Drawing.Point(29, 273);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(335, 62);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Time";
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(111, 22);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(201, 27);
            this.dtp_date.TabIndex = 1;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(16, 26);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(48, 24);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "PC";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox9);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.checkBox8);
            this.groupBox7.Location = new System.Drawing.Point(29, 205);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(335, 62);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Commands";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(190, 24);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(60, 27);
            this.textBox9.TabIndex = 16;
            this.textBox9.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "QU/QL:";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(16, 26);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(53, 24);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "S/E";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // cb_TI
            // 
            this.cb_TI.FormattingEnabled = true;
            this.cb_TI.Items.AddRange(new object[] {
            "1",
            "3",
            "13",
            "30",
            "32",
            "45",
            "46",
            "60"});
            this.cb_TI.Location = new System.Drawing.Point(304, 18);
            this.cb_TI.Name = "cb_TI";
            this.cb_TI.Size = new System.Drawing.Size(60, 28);
            this.cb_TI.TabIndex = 14;
            this.cb_TI.Text = "1";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox10);
            this.groupBox8.Controls.Add(this.checkBox9);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.checkBox11);
            this.groupBox8.Location = new System.Drawing.Point(29, 137);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(335, 62);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Integrated totals";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(264, 24);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(60, 27);
            this.textBox10.TabIndex = 16;
            this.textBox10.Text = "0";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Location = new System.Drawing.Point(73, 26);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(48, 24);
            this.checkBox9.TabIndex = 2;
            this.checkBox9.Text = "CY";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sequence number:";
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Location = new System.Drawing.Point(16, 26);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(50, 24);
            this.checkBox11.TabIndex = 0;
            this.checkBox11.Text = "CA";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.checkBox6);
            this.groupBox9.Controls.Add(this.checkBox5);
            this.groupBox9.Controls.Add(this.checkBox10);
            this.groupBox9.Controls.Add(this.checkBox12);
            this.groupBox9.Controls.Add(this.checkBox13);
            this.groupBox9.Location = new System.Drawing.Point(29, 69);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(335, 62);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Status";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(261, 26);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(51, 24);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "OV";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(195, 26);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(47, 24);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "BL";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Location = new System.Drawing.Point(73, 26);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(50, 24);
            this.checkBox10.TabIndex = 2;
            this.checkBox10.Text = "NT";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Checked = true;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.Location = new System.Drawing.Point(135, 26);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(48, 24);
            this.checkBox12.TabIndex = 1;
            this.checkBox12.Text = "SB";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Checked = true;
            this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox13.Location = new System.Drawing.Point(16, 26);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(44, 24);
            this.checkBox13.TabIndex = 0;
            this.checkBox13.Text = "IV";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // tb_IOA
            // 
            this.tb_IOA.Location = new System.Drawing.Point(194, 19);
            this.tb_IOA.Name = "tb_IOA";
            this.tb_IOA.Size = new System.Drawing.Size(60, 27);
            this.tb_IOA.TabIndex = 11;
            this.tb_IOA.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "IOA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "TI:";
            // 
            // tb_ASDU
            // 
            this.tb_ASDU.Location = new System.Drawing.Point(86, 19);
            this.tb_ASDU.Name = "tb_ASDU";
            this.tb_ASDU.Size = new System.Drawing.Size(60, 27);
            this.tb_ASDU.TabIndex = 7;
            this.tb_ASDU.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "ASDU:";
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Checked = true;
            this.checkBox14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox14.Location = new System.Drawing.Point(247, 265);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(68, 24);
            this.checkBox14.TabIndex = 10;
            this.checkBox14.Text = "Reply";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // tb_value
            // 
            this.tb_value.Location = new System.Drawing.Point(120, 263);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(92, 27);
            this.tb_value.TabIndex = 9;
            this.tb_value.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Value:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(120, 216);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(266, 27);
            this.tb_name.TabIndex = 7;
            this.tb_name.Text = "name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 6;
            this.label16.Text = "Name:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_disconnect.FlatAppearance.BorderSize = 0;
            this.btn_disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disconnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_disconnect.ForeColor = System.Drawing.Color.White;
            this.btn_disconnect.Location = new System.Drawing.Point(267, 154);
            this.btn_disconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(122, 68);
            this.btn_disconnect.TabIndex = 26;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = false;
            this.btn_disconnect.UseWaitCursor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.button3_Click);
            // 
            // lv_stats
            // 
            this.lv_stats.Location = new System.Drawing.Point(12, 255);
            this.lv_stats.Name = "lv_stats";
            this.lv_stats.Size = new System.Drawing.Size(1158, 481);
            this.lv_stats.TabIndex = 27;
            this.lv_stats.UseCompatibleStateImageBehavior = false;
            this.lv_stats.View = System.Windows.Forms.View.Details;
            // 
            // VinciClone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 753);
            this.Controls.Add(this.lv_stats);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Gi);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tb_IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "VinciClone";
            this.Text = "Vinci Clone";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button btnStart;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox tb_IP;
        private Label label3;
        private Label label4;
        private Button btn_Gi;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox5;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private GroupBox groupBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label17;
        private Label label18;
        private GroupBox groupBox3;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label14;
        private Label label15;
        private GroupBox groupBox2;
        private ComboBox comboBox12;
        private ComboBox comboBox11;
        private Label label12;
        private ComboBox comboBox10;
        private Label label11;
        private Label lb_stats;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btn_addTag;
        private Button btn_clear;
        private GroupBox groupBox1;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private GroupBox groupBox6;
        private DateTimePicker dtp_date;
        private CheckBox checkBox7;
        private GroupBox groupBox7;
        private TextBox textBox9;
        private Label label7;
        private CheckBox checkBox8;
        private ComboBox cb_TI;
        private GroupBox groupBox8;
        private TextBox textBox10;
        private CheckBox checkBox9;
        private Label label6;
        private CheckBox checkBox11;
        private GroupBox groupBox9;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox10;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private TextBox tb_IOA;
        private Label label5;
        private Label label8;
        private TextBox tb_ASDU;
        private Label label9;
        private CheckBox checkBox14;
        private TextBox tb_value;
        private Label label13;
        private TextBox tb_name;
        private Label label16;
        private ListView listView1;
        private TextBox textBox14;
        private Label label23;
        private TextBox textBox11;
        private Label label20;
        private ContextMenuStrip contextMenuStrip1;
        private Button btn_disconnect;
        private DataGridViewTextBoxColumn tc_ti;
        private DataGridViewTextBoxColumn tc_course;
        private DataGridViewTextBoxColumn tc_asdu;
        private DataGridViewTextBoxColumn tc_ios;
        private DataGridViewTextBoxColumn tc_value;
        private DataGridViewTextBoxColumn tc_status;
        private DataGridViewTextBoxColumn tc_timetag;
        private DataGridViewTextBoxColumn tc_count;
        private DataGridViewTextBoxColumn tc_name;
        private DataGridViewTextBoxColumn tc_ioa;
        private ListView lv_stats;
    }
}