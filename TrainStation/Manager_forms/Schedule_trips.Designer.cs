
namespace TrainStation.Manager_forms
{
    partial class Schedule_trips
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
            this.Trip_code = new System.Windows.Forms.TextBox();
            this.label_arr_time = new System.Windows.Forms.Label();
            this.label_trip = new System.Windows.Forms.Label();
            this.label_plate = new System.Windows.Forms.Label();
            this.label_come_station = new System.Windows.Forms.Label();
            this.label_go_station = new System.Windows.Forms.Label();
            this.Insert_trip = new System.Windows.Forms.Button();
            this.MA = new System.Windows.Forms.ComboBox();
            this.HA = new System.Windows.Forms.ComboBox();
            this.HD = new System.Windows.Forms.ComboBox();
            this.MD = new System.Windows.Forms.ComboBox();
            this.label_deptime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trainNum = new System.Windows.Forms.ComboBox();
            this.comestation = new System.Windows.Forms.ComboBox();
            this.Gostation = new System.Windows.Forms.ComboBox();
            this.Date_Of_trip = new System.Windows.Forms.DateTimePicker();
            this.label_date = new System.Windows.Forms.Label();
            this.label_Pv = new System.Windows.Forms.Label();
            this.label_pg = new System.Windows.Forms.Label();
            this.VIP = new System.Windows.Forms.NumericUpDown();
            this.GENERAL = new System.Windows.Forms.NumericUpDown();
            this.Exit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Num_VIP = new System.Windows.Forms.NumericUpDown();
            this.NUM_G = new System.Windows.Forms.NumericUpDown();
            this.numvip = new System.Windows.Forms.Label();
            this.numgen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GENERAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_VIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_G)).BeginInit();
            this.SuspendLayout();
            // 
            // Trip_code
            // 
            this.Trip_code.Location = new System.Drawing.Point(469, 28);
            this.Trip_code.Margin = new System.Windows.Forms.Padding(4);
            this.Trip_code.Name = "Trip_code";
            this.Trip_code.Size = new System.Drawing.Size(204, 24);
            this.Trip_code.TabIndex = 3;
            // 
            // label_arr_time
            // 
            this.label_arr_time.AutoSize = true;
            this.label_arr_time.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_arr_time.Location = new System.Drawing.Point(259, 115);
            this.label_arr_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_arr_time.Name = "label_arr_time";
            this.label_arr_time.Size = new System.Drawing.Size(106, 20);
            this.label_arr_time.TabIndex = 4;
            this.label_arr_time.Text = "Arrival Time";
            // 
            // label_trip
            // 
            this.label_trip.AutoSize = true;
            this.label_trip.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trip.Location = new System.Drawing.Point(268, 32);
            this.label_trip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_trip.Name = "label_trip";
            this.label_trip.Size = new System.Drawing.Size(80, 20);
            this.label_trip.TabIndex = 5;
            this.label_trip.Text = "Trip code";
            // 
            // label_plate
            // 
            this.label_plate.AutoSize = true;
            this.label_plate.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_plate.Location = new System.Drawing.Point(223, 411);
            this.label_plate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_plate.Name = "label_plate";
            this.label_plate.Size = new System.Drawing.Size(150, 20);
            this.label_plate.TabIndex = 6;
            this.label_plate.Text = "Train platenumber";
            // 
            // label_come_station
            // 
            this.label_come_station.AutoSize = true;
            this.label_come_station.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_come_station.Location = new System.Drawing.Point(243, 455);
            this.label_come_station.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_come_station.Name = "label_come_station";
            this.label_come_station.Size = new System.Drawing.Size(109, 20);
            this.label_come_station.TabIndex = 7;
            this.label_come_station.Text = "Come station";
            // 
            // label_go_station
            // 
            this.label_go_station.AutoSize = true;
            this.label_go_station.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_go_station.Location = new System.Drawing.Point(259, 517);
            this.label_go_station.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_go_station.Name = "label_go_station";
            this.label_go_station.Size = new System.Drawing.Size(91, 20);
            this.label_go_station.TabIndex = 8;
            this.label_go_station.Text = "Go station";
            // 
            // Insert_trip
            // 
            this.Insert_trip.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_trip.Location = new System.Drawing.Point(460, 571);
            this.Insert_trip.Margin = new System.Windows.Forms.Padding(4);
            this.Insert_trip.Name = "Insert_trip";
            this.Insert_trip.Size = new System.Drawing.Size(145, 59);
            this.Insert_trip.TabIndex = 9;
            this.Insert_trip.Text = "Inset Trip";
            this.Insert_trip.UseVisualStyleBackColor = true;
            this.Insert_trip.Click += new System.EventHandler(this.Insert_trip_Click);
            // 
            // MA
            // 
            this.MA.DropDownHeight = 150;
            this.MA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MA.DropDownWidth = 53;
            this.MA.FormattingEnabled = true;
            this.MA.IntegralHeight = false;
            this.MA.Location = new System.Drawing.Point(578, 112);
            this.MA.Margin = new System.Windows.Forms.Padding(4);
            this.MA.Name = "MA";
            this.MA.Size = new System.Drawing.Size(82, 26);
            this.MA.TabIndex = 10;
            // 
            // HA
            // 
            this.HA.DropDownHeight = 100;
            this.HA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HA.DropDownWidth = 53;
            this.HA.FormattingEnabled = true;
            this.HA.IntegralHeight = false;
            this.HA.Location = new System.Drawing.Point(475, 115);
            this.HA.Margin = new System.Windows.Forms.Padding(4);
            this.HA.Name = "HA";
            this.HA.Size = new System.Drawing.Size(83, 26);
            this.HA.TabIndex = 11;
            // 
            // HD
            // 
            this.HD.DropDownHeight = 100;
            this.HD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HD.FormattingEnabled = true;
            this.HD.IntegralHeight = false;
            this.HD.Location = new System.Drawing.Point(475, 164);
            this.HD.Margin = new System.Windows.Forms.Padding(4);
            this.HD.Name = "HD";
            this.HD.Size = new System.Drawing.Size(83, 26);
            this.HD.TabIndex = 15;
            // 
            // MD
            // 
            this.MD.DropDownHeight = 150;
            this.MD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MD.DropDownWidth = 53;
            this.MD.FormattingEnabled = true;
            this.MD.IntegralHeight = false;
            this.MD.Location = new System.Drawing.Point(578, 164);
            this.MD.Margin = new System.Windows.Forms.Padding(4);
            this.MD.Name = "MD";
            this.MD.Size = new System.Drawing.Size(82, 26);
            this.MD.TabIndex = 14;
            // 
            // label_deptime
            // 
            this.label_deptime.AutoSize = true;
            this.label_deptime.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deptime.Location = new System.Drawing.Point(240, 167);
            this.label_deptime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_deptime.Name = "label_deptime";
            this.label_deptime.Size = new System.Drawing.Size(131, 20);
            this.label_deptime.TabIndex = 13;
            this.label_deptime.Text = "Departure Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(476, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(574, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Minutes";
            // 
            // trainNum
            // 
            this.trainNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainNum.FormattingEnabled = true;
            this.trainNum.Location = new System.Drawing.Point(460, 407);
            this.trainNum.Margin = new System.Windows.Forms.Padding(4);
            this.trainNum.Name = "trainNum";
            this.trainNum.Size = new System.Drawing.Size(213, 26);
            this.trainNum.TabIndex = 20;
            // 
            // comestation
            // 
            this.comestation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comestation.FormattingEnabled = true;
            this.comestation.Location = new System.Drawing.Point(460, 455);
            this.comestation.Margin = new System.Windows.Forms.Padding(4);
            this.comestation.Name = "comestation";
            this.comestation.Size = new System.Drawing.Size(213, 26);
            this.comestation.TabIndex = 21;
            // 
            // Gostation
            // 
            this.Gostation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gostation.FormattingEnabled = true;
            this.Gostation.Location = new System.Drawing.Point(460, 517);
            this.Gostation.Margin = new System.Windows.Forms.Padding(4);
            this.Gostation.Name = "Gostation";
            this.Gostation.Size = new System.Drawing.Size(213, 26);
            this.Gostation.TabIndex = 22;
            // 
            // Date_Of_trip
            // 
            this.Date_Of_trip.CustomFormat = "yyyy-MM-dd";
            this.Date_Of_trip.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Of_trip.Location = new System.Drawing.Point(490, 212);
            this.Date_Of_trip.Name = "Date_Of_trip";
            this.Date_Of_trip.Size = new System.Drawing.Size(144, 24);
            this.Date_Of_trip.TabIndex = 48;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(274, 215);
            this.label_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(104, 20);
            this.label_date.TabIndex = 50;
            this.label_date.Text = "Date of trip";
            // 
            // label_Pv
            // 
            this.label_Pv.AutoSize = true;
            this.label_Pv.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pv.Location = new System.Drawing.Point(528, 298);
            this.label_Pv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Pv.Name = "label_Pv";
            this.label_Pv.Size = new System.Drawing.Size(110, 20);
            this.label_Pv.TabIndex = 51;
            this.label_Pv.Text = "Price Of VIP";
            // 
            // label_pg
            // 
            this.label_pg.AutoSize = true;
            this.label_pg.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pg.Location = new System.Drawing.Point(529, 346);
            this.label_pg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pg.Name = "label_pg";
            this.label_pg.Size = new System.Drawing.Size(136, 20);
            this.label_pg.TabIndex = 52;
            this.label_pg.Text = "Price Of General";
            // 
            // VIP
            // 
            this.VIP.Location = new System.Drawing.Point(717, 298);
            this.VIP.Margin = new System.Windows.Forms.Padding(4);
            this.VIP.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.VIP.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.VIP.Name = "VIP";
            this.VIP.Size = new System.Drawing.Size(150, 24);
            this.VIP.TabIndex = 53;
            this.VIP.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // GENERAL
            // 
            this.GENERAL.Location = new System.Drawing.Point(717, 347);
            this.GENERAL.Margin = new System.Windows.Forms.Padding(4);
            this.GENERAL.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.GENERAL.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.GENERAL.Name = "GENERAL";
            this.GENERAL.Size = new System.Drawing.Size(150, 24);
            this.GENERAL.TabIndex = 54;
            this.GENERAL.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(896, 571);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 55;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(770, 571);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 59);
            this.Back.TabIndex = 56;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Num_VIP
            // 
            this.Num_VIP.Location = new System.Drawing.Point(331, 294);
            this.Num_VIP.Margin = new System.Windows.Forms.Padding(4);
            this.Num_VIP.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Num_VIP.Name = "Num_VIP";
            this.Num_VIP.Size = new System.Drawing.Size(150, 24);
            this.Num_VIP.TabIndex = 57;
            // 
            // NUM_G
            // 
            this.NUM_G.Location = new System.Drawing.Point(331, 346);
            this.NUM_G.Margin = new System.Windows.Forms.Padding(4);
            this.NUM_G.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NUM_G.Name = "NUM_G";
            this.NUM_G.Size = new System.Drawing.Size(150, 24);
            this.NUM_G.TabIndex = 58;
            // 
            // numvip
            // 
            this.numvip.AutoSize = true;
            this.numvip.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numvip.Location = new System.Drawing.Point(98, 298);
            this.numvip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numvip.Name = "numvip";
            this.numvip.Size = new System.Drawing.Size(183, 20);
            this.numvip.TabIndex = 59;
            this.numvip.Text = "Number of VIP Ticket";
            // 
            // numgen
            // 
            this.numgen.AutoSize = true;
            this.numgen.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numgen.Location = new System.Drawing.Point(72, 351);
            this.numgen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numgen.Name = "numgen";
            this.numgen.Size = new System.Drawing.Size(209, 20);
            this.numgen.TabIndex = 60;
            this.numgen.Text = "Number of General Ticket";
            // 
            // Schedule_trips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 652);
            this.Controls.Add(this.numgen);
            this.Controls.Add(this.numvip);
            this.Controls.Add(this.NUM_G);
            this.Controls.Add(this.Num_VIP);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.GENERAL);
            this.Controls.Add(this.VIP);
            this.Controls.Add(this.label_pg);
            this.Controls.Add(this.label_Pv);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.Date_Of_trip);
            this.Controls.Add(this.Gostation);
            this.Controls.Add(this.comestation);
            this.Controls.Add(this.trainNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HD);
            this.Controls.Add(this.MD);
            this.Controls.Add(this.label_deptime);
            this.Controls.Add(this.HA);
            this.Controls.Add(this.MA);
            this.Controls.Add(this.Insert_trip);
            this.Controls.Add(this.label_go_station);
            this.Controls.Add(this.label_come_station);
            this.Controls.Add(this.label_plate);
            this.Controls.Add(this.label_trip);
            this.Controls.Add(this.label_arr_time);
            this.Controls.Add(this.Trip_code);
            this.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Schedule_trips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule_trips";
            this.Load += new System.EventHandler(this.Schedule_trips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GENERAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_VIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_G)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Trip_code;
        private System.Windows.Forms.Label label_arr_time;
        private System.Windows.Forms.Label label_trip;
        private System.Windows.Forms.Label label_plate;
        private System.Windows.Forms.Label label_come_station;
        private System.Windows.Forms.Label label_go_station;
        private System.Windows.Forms.Button Insert_trip;
        private System.Windows.Forms.ComboBox MA;
        private System.Windows.Forms.ComboBox HA;
        private System.Windows.Forms.ComboBox HD;
        private System.Windows.Forms.ComboBox MD;
        private System.Windows.Forms.Label label_deptime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox trainNum;
        private System.Windows.Forms.ComboBox comestation;
        private System.Windows.Forms.ComboBox Gostation;
        private System.Windows.Forms.DateTimePicker Date_Of_trip;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_Pv;
        private System.Windows.Forms.Label label_pg;
        private System.Windows.Forms.NumericUpDown VIP;
        private System.Windows.Forms.NumericUpDown GENERAL;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.NumericUpDown Num_VIP;
        private System.Windows.Forms.NumericUpDown NUM_G;
        private System.Windows.Forms.Label numvip;
        private System.Windows.Forms.Label numgen;
    }
}