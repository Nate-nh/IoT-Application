namespace Lab2
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
            this.PanelConcection = new System.Windows.Forms.Panel();
            this.BaudBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OffLed = new System.Windows.Forms.Button();
            this.OnLed = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OffFan = new System.Windows.Forms.Button();
            this.OnFan = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.nt = new System.Windows.Forms.Label();
            this.dm = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelConcection.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelConcection
            // 
            this.PanelConcection.BackColor = System.Drawing.Color.White;
            this.PanelConcection.Controls.Add(this.BaudBox);
            this.PanelConcection.Controls.Add(this.label3);
            this.PanelConcection.Controls.Add(this.BTConnect);
            this.PanelConcection.Controls.Add(this.label2);
            this.PanelConcection.Controls.Add(this.PortBox);
            this.PanelConcection.Controls.Add(this.label1);
            this.PanelConcection.Location = new System.Drawing.Point(15, 14);
            this.PanelConcection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelConcection.Name = "PanelConcection";
            this.PanelConcection.Size = new System.Drawing.Size(547, 176);
            this.PanelConcection.TabIndex = 1;
            // 
            // BaudBox
            // 
            this.BaudBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BaudBox.Cursor = System.Windows.Forms.Cursors.No;
            this.BaudBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaudBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudBox.FormattingEnabled = true;
            this.BaudBox.Location = new System.Drawing.Point(372, 67);
            this.BaudBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BaudBox.Name = "BaudBox";
            this.BaudBox.Size = new System.Drawing.Size(163, 28);
            this.BaudBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "COM:";
            // 
            // BTConnect
            // 
            this.BTConnect.BackColor = System.Drawing.Color.SeaGreen;
            this.BTConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConnect.ForeColor = System.Drawing.Color.White;
            this.BTConnect.Location = new System.Drawing.Point(125, 111);
            this.BTConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTConnect.Name = "BTConnect";
            this.BTConnect.Size = new System.Drawing.Size(232, 46);
            this.BTConnect.TabIndex = 5;
            this.BTConnect.Text = "Connect";
            this.BTConnect.UseVisualStyleBackColor = false;
            this.BTConnect.Click += new System.EventHandler(this.BTConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate:";
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(84, 67);
            this.PortBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(163, 28);
            this.PortBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(185, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection Panel";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.OffLed);
            this.panel1.Controls.Add(this.OnLed);
            this.panel1.Location = new System.Drawing.Point(15, 217);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 263);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Disconnect";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(33, 225);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Living room lights";
            // 
            // OffLed
            // 
            this.OffLed.BackColor = System.Drawing.Color.Red;
            this.OffLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffLed.ForeColor = System.Drawing.Color.White;
            this.OffLed.Location = new System.Drawing.Point(25, 155);
            this.OffLed.Margin = new System.Windows.Forms.Padding(4);
            this.OffLed.Name = "OffLed";
            this.OffLed.Size = new System.Drawing.Size(116, 46);
            this.OffLed.TabIndex = 1;
            this.OffLed.Text = "OFF";
            this.OffLed.UseVisualStyleBackColor = false;
            this.OffLed.Click += new System.EventHandler(this.OffLed_Click);
            // 
            // OnLed
            // 
            this.OnLed.BackColor = System.Drawing.Color.Lime;
            this.OnLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnLed.ForeColor = System.Drawing.Color.White;
            this.OnLed.Location = new System.Drawing.Point(25, 79);
            this.OnLed.Margin = new System.Windows.Forms.Padding(4);
            this.OnLed.Name = "OnLed";
            this.OnLed.Size = new System.Drawing.Size(116, 46);
            this.OnLed.TabIndex = 0;
            this.OnLed.Text = "ON";
            this.OnLed.UseVisualStyleBackColor = false;
            this.OnLed.Click += new System.EventHandler(this.OnLed_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.OffFan);
            this.panel2.Controls.Add(this.OnFan);
            this.panel2.Location = new System.Drawing.Point(332, 217);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 263);
            this.panel2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(46, 225);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Disconnect";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Electric fan";
            // 
            // OffFan
            // 
            this.OffFan.BackColor = System.Drawing.Color.Red;
            this.OffFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffFan.ForeColor = System.Drawing.Color.White;
            this.OffFan.Location = new System.Drawing.Point(16, 155);
            this.OffFan.Margin = new System.Windows.Forms.Padding(4);
            this.OffFan.Name = "OffFan";
            this.OffFan.Size = new System.Drawing.Size(116, 46);
            this.OffFan.TabIndex = 1;
            this.OffFan.Text = "OFF";
            this.OffFan.UseVisualStyleBackColor = false;
            this.OffFan.Click += new System.EventHandler(this.OffFan_Click);
            // 
            // OnFan
            // 
            this.OnFan.BackColor = System.Drawing.Color.Lime;
            this.OnFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnFan.ForeColor = System.Drawing.Color.White;
            this.OnFan.Location = new System.Drawing.Point(16, 79);
            this.OnFan.Margin = new System.Windows.Forms.Padding(4);
            this.OnFan.Name = "OnFan";
            this.OnFan.Size = new System.Drawing.Size(116, 46);
            this.OnFan.TabIndex = 0;
            this.OnFan.Text = "ON";
            this.OnFan.UseVisualStyleBackColor = false;
            this.OnFan.Click += new System.EventHandler(this.OnFan_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Gray;
            this.lbDate.Location = new System.Drawing.Point(19, 80);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(284, 24);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "Thursday, December 28,2023";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.lbTime);
            this.panel3.Controls.Add(this.lbDate);
            this.panel3.Location = new System.Drawing.Point(750, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 176);
            this.panel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(64, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ho Chi Minh City";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(16, 29);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(220, 39);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "00:00:00 PM";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 5000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // nt
            // 
            this.nt.AutoSize = true;
            this.nt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nt.Location = new System.Drawing.Point(194, 65);
            this.nt.Name = "nt";
            this.nt.Size = new System.Drawing.Size(55, 39);
            this.nt.TabIndex = 8;
            this.nt.Text = "00";
            // 
            // dm
            // 
            this.dm.AutoSize = true;
            this.dm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dm.Location = new System.Drawing.Point(202, 47);
            this.dm.Name = "dm";
            this.dm.Size = new System.Drawing.Size(55, 39);
            this.dm.TabIndex = 9;
            this.dm.Text = "00";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.nt);
            this.panel4.Location = new System.Drawing.Point(658, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 125);
            this.panel4.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(252, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "o";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(268, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 39);
            this.label13.TabIndex = 11;
            this.label13.Text = "C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(155, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "Temperature";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.pictureBox7);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.dm);
            this.panel5.Location = new System.Drawing.Point(658, 372);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(398, 108);
            this.panel5.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(258, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 39);
            this.label14.TabIndex = 12;
            this.label14.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(192, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 26);
            this.label12.TabIndex = 10;
            this.label12.Text = "Humidity";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Lab2.Properties.Resources.logoitc100;
            this.pictureBox8.Location = new System.Drawing.Point(585, 45);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(149, 126);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Lab2.Properties.Resources.humidity_9342439;
            this.pictureBox7.Location = new System.Drawing.Point(23, 21);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 84);
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.ErrorImage = global::Lab2.Properties.Resources.icons8_temperature_64;
            this.pictureBox6.Image = global::Lab2.Properties.Resources.icons8_temperature_64;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(23, 29);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(77, 81);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Lab2.Properties.Resources.location__1_;
            this.pictureBox5.Location = new System.Drawing.Point(23, 118);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 55);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(167, 101);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 83);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(187, 225);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 16);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Lab2.Properties.Resources.On;
            this.pictureBox3.Location = new System.Drawing.Point(166, 101);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 83);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(171, 225);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 16);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1068, 504);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelConcection);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelConcection.ResumeLayout(false);
            this.PanelConcection.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelConcection;
        private System.Windows.Forms.Button BTConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OffLed;
        private System.Windows.Forms.Button OnLed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button OffFan;
        private System.Windows.Forms.Button OnFan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox BaudBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label nt;
        private System.Windows.Forms.Label dm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

