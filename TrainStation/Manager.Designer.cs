
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
            this.Change_rate = new System.Windows.Forms.Button();
            this.Change_Salary = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Hire_E = new System.Windows.Forms.Button();
            this.Schedule_trips = new System.Windows.Forms.Button();
            this.view_Employee = new System.Windows.Forms.Button();
            this.view_passenger = new System.Windows.Forms.Button();
            this.Change_Dep = new System.Windows.Forms.Button();
            this.Fire_Employee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Change_rate
            // 
            this.Change_rate.Location = new System.Drawing.Point(433, 110);
            this.Change_rate.Name = "Change_rate";
            this.Change_rate.Size = new System.Drawing.Size(178, 51);
            this.Change_rate.TabIndex = 2;
            this.Change_rate.Text = "Change rate of employee";
            this.Change_rate.UseVisualStyleBackColor = true;
            this.Change_rate.Click += new System.EventHandler(this.Change_rate_Click);
            // 
            // Change_Salary
            // 
            this.Change_Salary.Location = new System.Drawing.Point(216, 104);
            this.Change_Salary.Name = "Change_Salary";
            this.Change_Salary.Size = new System.Drawing.Size(178, 51);
            this.Change_Salary.TabIndex = 10;
            this.Change_Salary.Text = "Change salary of employee";
            this.Change_Salary.UseVisualStyleBackColor = true;
            this.Change_Salary.Click += new System.EventHandler(this.Change_Salary_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Hire_E
            // 
            this.Hire_E.Location = new System.Drawing.Point(17, 45);
            this.Hire_E.Name = "Hire_E";
            this.Hire_E.Size = new System.Drawing.Size(177, 40);
            this.Hire_E.TabIndex = 19;
            this.Hire_E.Text = "Hire Employee";
            this.Hire_E.UseVisualStyleBackColor = true;
            this.Hire_E.Click += new System.EventHandler(this.Hire_E_Click);
            // 
            // Schedule_trips
            // 
            this.Schedule_trips.Location = new System.Drawing.Point(6, 37);
            this.Schedule_trips.Name = "Schedule_trips";
            this.Schedule_trips.Size = new System.Drawing.Size(177, 42);
            this.Schedule_trips.TabIndex = 18;
            this.Schedule_trips.Text = "Schedule trips";
            this.Schedule_trips.UseVisualStyleBackColor = true;
            this.Schedule_trips.Click += new System.EventHandler(this.Schedule_trips_Click_1);
            // 
            // view_Employee
            // 
            this.view_Employee.Location = new System.Drawing.Point(217, 45);
            this.view_Employee.Name = "view_Employee";
            this.view_Employee.Size = new System.Drawing.Size(177, 40);
            this.view_Employee.TabIndex = 17;
            this.view_Employee.Text = "View Employess\'s data";
            this.view_Employee.UseVisualStyleBackColor = true;
            this.view_Employee.Click += new System.EventHandler(this.view_Employee_Click_1);
            // 
            // view_passenger
            // 
            this.view_passenger.Location = new System.Drawing.Point(17, 37);
            this.view_passenger.Name = "view_passenger";
            this.view_passenger.Size = new System.Drawing.Size(177, 40);
            this.view_passenger.TabIndex = 16;
            this.view_passenger.Text = "View Passenger\'s data";
            this.view_passenger.UseVisualStyleBackColor = true;
            this.view_passenger.Click += new System.EventHandler(this.view_passenger_Click_1);
            // 
            // Change_Dep
            // 
            this.Change_Dep.Location = new System.Drawing.Point(17, 104);
            this.Change_Dep.Name = "Change_Dep";
            this.Change_Dep.Size = new System.Drawing.Size(178, 51);
            this.Change_Dep.TabIndex = 20;
            this.Change_Dep.Text = "Change Departrment of employee";
            this.Change_Dep.UseVisualStyleBackColor = true;
            this.Change_Dep.Click += new System.EventHandler(this.Change_Dep_Click);
            // 
            // Fire_Employee
            // 
            this.Fire_Employee.Location = new System.Drawing.Point(434, 45);
            this.Fire_Employee.Name = "Fire_Employee";
            this.Fire_Employee.Size = new System.Drawing.Size(177, 40);
            this.Fire_Employee.TabIndex = 16;
            this.Fire_Employee.Text = "Fire Employee";
            this.Fire_Employee.UseVisualStyleBackColor = true;
            this.Fire_Employee.Click += new System.EventHandler(this.Fire_Employee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.view_Employee);
            this.groupBox1.Controls.Add(this.Hire_E);
            this.groupBox1.Controls.Add(this.Fire_Employee);
            this.groupBox1.Controls.Add(this.Change_rate);
            this.groupBox1.Controls.Add(this.Change_Salary);
            this.groupBox1.Controls.Add(this.Change_Dep);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 161);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.view_passenger);
            this.groupBox2.Location = new System.Drawing.Point(41, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Passenger";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Schedule_trips);
            this.groupBox3.Location = new System.Drawing.Point(351, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trips";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 343);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Change_rate;
        private System.Windows.Forms.Button Change_Salary;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Hire_E;
        private System.Windows.Forms.Button Schedule_trips;
        private System.Windows.Forms.Button view_Employee;
        private System.Windows.Forms.Button view_passenger;
        private System.Windows.Forms.Button Change_Dep;
        private System.Windows.Forms.Button Fire_Employee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}