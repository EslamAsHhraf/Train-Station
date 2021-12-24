
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
            this.Come_station = new System.Windows.Forms.NumericUpDown();
            this.Train_platenumber = new System.Windows.Forms.NumericUpDown();
            this.Go_station = new System.Windows.Forms.NumericUpDown();
            this.Trip_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MA = new System.Windows.Forms.ComboBox();
            this.HA = new System.Windows.Forms.ComboBox();
            this.SA = new System.Windows.Forms.ComboBox();
            this.SD = new System.Windows.Forms.ComboBox();
            this.HD = new System.Windows.Forms.ComboBox();
            this.MD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Come_station)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Train_platenumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Go_station)).BeginInit();
            this.SuspendLayout();
            // 
            // Come_station
            // 
            this.Come_station.Location = new System.Drawing.Point(188, 297);
            this.Come_station.Name = "Come_station";
            this.Come_station.Size = new System.Drawing.Size(161, 22);
            this.Come_station.TabIndex = 0;
            // 
            // Train_platenumber
            // 
            this.Train_platenumber.Location = new System.Drawing.Point(188, 245);
            this.Train_platenumber.Name = "Train_platenumber";
            this.Train_platenumber.Size = new System.Drawing.Size(161, 22);
            this.Train_platenumber.TabIndex = 1;
            // 
            // Go_station
            // 
            this.Go_station.Location = new System.Drawing.Point(188, 346);
            this.Go_station.Name = "Go_station";
            this.Go_station.Size = new System.Drawing.Size(161, 22);
            this.Go_station.TabIndex = 2;
            // 
            // Trip_code
            // 
            this.Trip_code.Location = new System.Drawing.Point(170, 49);
            this.Trip_code.Name = "Trip_code";
            this.Trip_code.Size = new System.Drawing.Size(164, 22);
            this.Trip_code.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arrival Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trip code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Train platenumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Come station";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Go station";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Inset Trip";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MA
            // 
            this.MA.DropDownHeight = 150;
            this.MA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MA.DropDownWidth = 53;
            this.MA.FormattingEnabled = true;
            this.MA.IntegralHeight = false;
            this.MA.Location = new System.Drawing.Point(238, 143);
            this.MA.Name = "MA";
            this.MA.Size = new System.Drawing.Size(66, 24);
            this.MA.TabIndex = 10;
            // 
            // HA
            // 
            this.HA.DropDownHeight = 100;
            this.HA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HA.DropDownWidth = 53;
            this.HA.FormattingEnabled = true;
            this.HA.IntegralHeight = false;
            this.HA.Location = new System.Drawing.Point(156, 143);
            this.HA.Name = "HA";
            this.HA.Size = new System.Drawing.Size(67, 24);
            this.HA.TabIndex = 11;
            // 
            // SA
            // 
            this.SA.DropDownHeight = 150;
            this.SA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SA.FormattingEnabled = true;
            this.SA.IntegralHeight = false;
            this.SA.Location = new System.Drawing.Point(319, 143);
            this.SA.Name = "SA";
            this.SA.Size = new System.Drawing.Size(75, 24);
            this.SA.TabIndex = 12;
            // 
            // SD
            // 
            this.SD.DropDownHeight = 150;
            this.SD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SD.FormattingEnabled = true;
            this.SD.IntegralHeight = false;
            this.SD.Location = new System.Drawing.Point(319, 198);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(75, 24);
            this.SD.TabIndex = 16;
            // 
            // HD
            // 
            this.HD.DropDownHeight = 100;
            this.HD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HD.FormattingEnabled = true;
            this.HD.IntegralHeight = false;
            this.HD.Location = new System.Drawing.Point(156, 198);
            this.HD.Name = "HD";
            this.HD.Size = new System.Drawing.Size(67, 24);
            this.HD.TabIndex = 15;
            // 
            // MD
            // 
            this.MD.DropDownHeight = 150;
            this.MD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MD.DropDownWidth = 53;
            this.MD.FormattingEnabled = true;
            this.MD.IntegralHeight = false;
            this.MD.Location = new System.Drawing.Point(238, 198);
            this.MD.Name = "MD";
            this.MD.Size = new System.Drawing.Size(66, 24);
            this.MD.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Departure Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Minutes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Seconds";
            // 
            // Schedule_trips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 510);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SD);
            this.Controls.Add(this.HD);
            this.Controls.Add(this.MD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SA);
            this.Controls.Add(this.HA);
            this.Controls.Add(this.MA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Trip_code);
            this.Controls.Add(this.Go_station);
            this.Controls.Add(this.Train_platenumber);
            this.Controls.Add(this.Come_station);
            this.Name = "Schedule_trips";
            this.Text = "Schedule_trips";
            this.Load += new System.EventHandler(this.Schedule_trips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Come_station)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Train_platenumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Go_station)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Come_station;
        private System.Windows.Forms.NumericUpDown Train_platenumber;
        private System.Windows.Forms.NumericUpDown Go_station;
        private System.Windows.Forms.TextBox Trip_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox MA;
        private System.Windows.Forms.ComboBox HA;
        private System.Windows.Forms.ComboBox SA;
        private System.Windows.Forms.ComboBox SD;
        private System.Windows.Forms.ComboBox HD;
        private System.Windows.Forms.ComboBox MD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}