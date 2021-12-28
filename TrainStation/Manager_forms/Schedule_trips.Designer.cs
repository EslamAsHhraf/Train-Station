
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Insert_trip = new System.Windows.Forms.Button();
            this.MA = new System.Windows.Forms.ComboBox();
            this.HA = new System.Windows.Forms.ComboBox();
            this.HD = new System.Windows.Forms.ComboBox();
            this.MD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trainNum = new System.Windows.Forms.ComboBox();
            this.comestation = new System.Windows.Forms.ComboBox();
            this.Gostation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Trip_code
            // 
            this.Trip_code.Location = new System.Drawing.Point(460, 90);
            this.Trip_code.Margin = new System.Windows.Forms.Padding(4);
            this.Trip_code.Name = "Trip_code";
            this.Trip_code.Size = new System.Drawing.Size(204, 29);
            this.Trip_code.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arrival Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trip code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Train platenumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Come station";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 431);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Go station";
            // 
            // Insert_trip
            // 
            this.Insert_trip.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_trip.Location = new System.Drawing.Point(460, 530);
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
            this.MA.Location = new System.Drawing.Point(572, 190);
            this.MA.Margin = new System.Windows.Forms.Padding(4);
            this.MA.Name = "MA";
            this.MA.Size = new System.Drawing.Size(82, 29);
            this.MA.TabIndex = 10;
            // 
            // HA
            // 
            this.HA.DropDownHeight = 100;
            this.HA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HA.DropDownWidth = 53;
            this.HA.FormattingEnabled = true;
            this.HA.IntegralHeight = false;
            this.HA.Location = new System.Drawing.Point(469, 193);
            this.HA.Margin = new System.Windows.Forms.Padding(4);
            this.HA.Name = "HA";
            this.HA.Size = new System.Drawing.Size(83, 29);
            this.HA.TabIndex = 11;
            // 
            // HD
            // 
            this.HD.DropDownHeight = 100;
            this.HD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HD.FormattingEnabled = true;
            this.HD.IntegralHeight = false;
            this.HD.Location = new System.Drawing.Point(469, 242);
            this.HD.Margin = new System.Windows.Forms.Padding(4);
            this.HD.Name = "HD";
            this.HD.Size = new System.Drawing.Size(83, 29);
            this.HD.TabIndex = 15;
            // 
            // MD
            // 
            this.MD.DropDownHeight = 150;
            this.MD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MD.DropDownWidth = 53;
            this.MD.FormattingEnabled = true;
            this.MD.IntegralHeight = false;
            this.MD.Location = new System.Drawing.Point(572, 242);
            this.MD.Margin = new System.Windows.Forms.Padding(4);
            this.MD.Name = "MD";
            this.MD.Size = new System.Drawing.Size(82, 29);
            this.MD.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Departure Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(568, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Minutes";
            // 
            // trainNum
            // 
            this.trainNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainNum.FormattingEnabled = true;
            this.trainNum.Location = new System.Drawing.Point(460, 305);
            this.trainNum.Margin = new System.Windows.Forms.Padding(4);
            this.trainNum.Name = "trainNum";
            this.trainNum.Size = new System.Drawing.Size(213, 29);
            this.trainNum.TabIndex = 20;
            // 
            // comestation
            // 
            this.comestation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comestation.FormattingEnabled = true;
            this.comestation.Location = new System.Drawing.Point(460, 369);
            this.comestation.Margin = new System.Windows.Forms.Padding(4);
            this.comestation.Name = "comestation";
            this.comestation.Size = new System.Drawing.Size(213, 29);
            this.comestation.TabIndex = 21;
            // 
            // Gostation
            // 
            this.Gostation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gostation.FormattingEnabled = true;
            this.Gostation.Location = new System.Drawing.Point(460, 431);
            this.Gostation.Margin = new System.Windows.Forms.Padding(4);
            this.Gostation.Name = "Gostation";
            this.Gostation.Size = new System.Drawing.Size(213, 29);
            this.Gostation.TabIndex = 22;
            // 
            // Schedule_trips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 652);
            this.Controls.Add(this.Gostation);
            this.Controls.Add(this.comestation);
            this.Controls.Add(this.trainNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HD);
            this.Controls.Add(this.MD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HA);
            this.Controls.Add(this.MA);
            this.Controls.Add(this.Insert_trip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Trip_code);
            this.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Schedule_trips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule_trips";
            this.Load += new System.EventHandler(this.Schedule_trips_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Trip_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Insert_trip;
        private System.Windows.Forms.ComboBox MA;
        private System.Windows.Forms.ComboBox HA;
        private System.Windows.Forms.ComboBox HD;
        private System.Windows.Forms.ComboBox MD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox trainNum;
        private System.Windows.Forms.ComboBox comestation;
        private System.Windows.Forms.ComboBox Gostation;
    }
}