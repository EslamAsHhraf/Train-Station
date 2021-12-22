
namespace TrainStation
{
    partial class Manager
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
            this.view_Employee = new System.Windows.Forms.Button();
            this.view_passenger = new System.Windows.Forms.Button();
            this.Rate_employee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SSN_E = new System.Windows.Forms.NumericUpDown();
            this.Rate = new System.Windows.Forms.NumericUpDown();
            this.Schedule_trips = new System.Windows.Forms.Button();
            this.Salary = new System.Windows.Forms.NumericUpDown();
            this.SSN_E_S = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Change_Salary = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Hire_E = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button1 = new System.Windows.Forms.Button();
            this.SSN_Fire = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.SSN_E_D = new System.Windows.Forms.NumericUpDown();
            this.DNum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SSN_E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSN_E_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSN_Fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSN_E_D)).BeginInit();
            this.SuspendLayout();
            // 
            // view_Employee
            // 
            this.view_Employee.Location = new System.Drawing.Point(760, 125);
            this.view_Employee.Name = "view_Employee";
            this.view_Employee.Size = new System.Drawing.Size(177, 40);
            this.view_Employee.TabIndex = 0;
            this.view_Employee.Text = "View Employee\'s data";
            this.view_Employee.UseVisualStyleBackColor = true;
            this.view_Employee.Click += new System.EventHandler(this.view_Employee_Click);
            // 
            // view_passenger
            // 
            this.view_passenger.Location = new System.Drawing.Point(760, 189);
            this.view_passenger.Name = "view_passenger";
            this.view_passenger.Size = new System.Drawing.Size(177, 40);
            this.view_passenger.TabIndex = 1;
            this.view_passenger.Text = "View Passenger\'s data";
            this.view_passenger.UseVisualStyleBackColor = true;
            this.view_passenger.Click += new System.EventHandler(this.view_passenger_Click);
            // 
            // Rate_employee
            // 
            this.Rate_employee.Location = new System.Drawing.Point(393, 290);
            this.Rate_employee.Name = "Rate_employee";
            this.Rate_employee.Size = new System.Drawing.Size(178, 51);
            this.Rate_employee.TabIndex = 2;
            this.Rate_employee.Text = "Change rate of employee";
            this.Rate_employee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rate";
            // 
            // SSN_E
            // 
            this.SSN_E.Location = new System.Drawing.Point(67, 305);
            this.SSN_E.Name = "SSN_E";
            this.SSN_E.Size = new System.Drawing.Size(120, 22);
            this.SSN_E.TabIndex = 7;
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(253, 305);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(120, 22);
            this.Rate.TabIndex = 8;
            // 
            // Schedule_trips
            // 
            this.Schedule_trips.Location = new System.Drawing.Point(760, 244);
            this.Schedule_trips.Name = "Schedule_trips";
            this.Schedule_trips.Size = new System.Drawing.Size(177, 42);
            this.Schedule_trips.TabIndex = 9;
            this.Schedule_trips.Text = "Schedule trips";
            this.Schedule_trips.UseVisualStyleBackColor = true;
            this.Schedule_trips.Click += new System.EventHandler(this.Schedule_trips_Click);
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(253, 229);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(120, 22);
            this.Salary.TabIndex = 14;
            // 
            // SSN_E_S
            // 
            this.SSN_E_S.Location = new System.Drawing.Point(67, 229);
            this.SSN_E_S.Name = "SSN_E_S";
            this.SSN_E_S.Size = new System.Drawing.Size(120, 22);
            this.SSN_E_S.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "SSN";
            // 
            // Change_Salary
            // 
            this.Change_Salary.Location = new System.Drawing.Point(393, 214);
            this.Change_Salary.Name = "Change_Salary";
            this.Change_Salary.Size = new System.Drawing.Size(178, 51);
            this.Change_Salary.TabIndex = 10;
            this.Change_Salary.Text = "Change salary of employee";
            this.Change_Salary.UseVisualStyleBackColor = true;
            // 
            // Hire_E
            // 
            this.Hire_E.Location = new System.Drawing.Point(760, 57);
            this.Hire_E.Name = "Hire_E";
            this.Hire_E.Size = new System.Drawing.Size(177, 40);
            this.Hire_E.TabIndex = 15;
            this.Hire_E.Text = "Hire Employee";
            this.Hire_E.UseVisualStyleBackColor = true;
            this.Hire_E.Click += new System.EventHandler(this.Hire_E_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Fire Employee";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SSN_Fire
            // 
            this.SSN_Fire.Location = new System.Drawing.Point(96, 67);
            this.SSN_Fire.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.SSN_Fire.Name = "SSN_Fire";
            this.SSN_Fire.Size = new System.Drawing.Size(120, 22);
            this.SSN_Fire.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "SSN";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(368, 151);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 24;
            // 
            // SSN_E_D
            // 
            this.SSN_E_D.Location = new System.Drawing.Point(67, 154);
            this.SSN_E_D.Name = "SSN_E_D";
            this.SSN_E_D.Size = new System.Drawing.Size(120, 22);
            this.SSN_E_D.TabIndex = 23;
            // 
            // DNum
            // 
            this.DNum.AutoSize = true;
            this.DNum.Location = new System.Drawing.Point(209, 156);
            this.DNum.Name = "DNum";
            this.DNum.Size = new System.Drawing.Size(134, 17);
            this.DNum.TabIndex = 22;
            this.DNum.Text = "Department number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "SSN";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(522, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 51);
            this.button3.TabIndex = 20;
            this.button3.Text = "Change Departrment of employee";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 392);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.SSN_E_D);
            this.Controls.Add(this.DNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SSN_Fire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Hire_E);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.SSN_E_S);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Change_Salary);
            this.Controls.Add(this.Schedule_trips);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.SSN_E);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rate_employee);
            this.Controls.Add(this.view_passenger);
            this.Controls.Add(this.view_Employee);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.SSN_E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSN_E_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSN_Fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSN_E_D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view_Employee;
        private System.Windows.Forms.Button view_passenger;
        private System.Windows.Forms.Button Rate_employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SSN_E;
        private System.Windows.Forms.NumericUpDown Rate;
        private System.Windows.Forms.Button Schedule_trips;
        private System.Windows.Forms.NumericUpDown Salary;
        private System.Windows.Forms.NumericUpDown SSN_E_S;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Change_Salary;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Hire_E;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.NumericUpDown SSN_Fire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown SSN_E_D;
        private System.Windows.Forms.Label DNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
    }
}