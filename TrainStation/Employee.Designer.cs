
namespace TrainStation
{
    partial class Employee
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
            this.viewAvailableSeatsBtn = new System.Windows.Forms.Button();
            this.upgradeTicketBtn = new System.Windows.Forms.Button();
            this.bookTicketBtn = new System.Windows.Forms.Button();
            this.viewAvailableTripsBtn = new System.Windows.Forms.Button();
            this.upgradePassengerDataBtn = new System.Windows.Forms.Button();
            this.viewTicketDetailsBtn = new System.Windows.Forms.Button();
            this.viewPassengersDataBtn = new System.Windows.Forms.Button();
            this.cancelTicketBtn = new System.Windows.Forms.Button();
            this.checkTrainStatusBtn = new System.Windows.Forms.Button();
            this.Ticket = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Ticket.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewAvailableSeatsBtn
            // 
            this.viewAvailableSeatsBtn.Location = new System.Drawing.Point(25, 31);
            this.viewAvailableSeatsBtn.Name = "viewAvailableSeatsBtn";
            this.viewAvailableSeatsBtn.Size = new System.Drawing.Size(222, 41);
            this.viewAvailableSeatsBtn.TabIndex = 0;
            this.viewAvailableSeatsBtn.Text = "View a trip\'s available seats ";
            this.viewAvailableSeatsBtn.UseVisualStyleBackColor = true;
            this.viewAvailableSeatsBtn.Click += new System.EventHandler(this.viewAvailableSeatsBtn_Click);
            // 
            // upgradeTicketBtn
            // 
            this.upgradeTicketBtn.Location = new System.Drawing.Point(278, 33);
            this.upgradeTicketBtn.Name = "upgradeTicketBtn";
            this.upgradeTicketBtn.Size = new System.Drawing.Size(222, 41);
            this.upgradeTicketBtn.TabIndex = 1;
            this.upgradeTicketBtn.Text = "Upgrade a ticket";
            this.upgradeTicketBtn.UseVisualStyleBackColor = true;
            this.upgradeTicketBtn.Click += new System.EventHandler(this.upgradeTicketBtn_Click);
            // 
            // bookTicketBtn
            // 
            this.bookTicketBtn.Location = new System.Drawing.Point(27, 33);
            this.bookTicketBtn.Name = "bookTicketBtn";
            this.bookTicketBtn.Size = new System.Drawing.Size(222, 41);
            this.bookTicketBtn.TabIndex = 2;
            this.bookTicketBtn.Text = "Book a ticket";
            this.bookTicketBtn.UseVisualStyleBackColor = true;
            this.bookTicketBtn.Click += new System.EventHandler(this.bookTicketBtn_Click);
            // 
            // viewAvailableTripsBtn
            // 
            this.viewAvailableTripsBtn.Location = new System.Drawing.Point(276, 31);
            this.viewAvailableTripsBtn.Name = "viewAvailableTripsBtn";
            this.viewAvailableTripsBtn.Size = new System.Drawing.Size(222, 41);
            this.viewAvailableTripsBtn.TabIndex = 3;
            this.viewAvailableTripsBtn.Text = "View available trips";
            this.viewAvailableTripsBtn.UseVisualStyleBackColor = true;
            this.viewAvailableTripsBtn.Click += new System.EventHandler(this.viewAvailableTripsBtn_Click);
            // 
            // upgradePassengerDataBtn
            // 
            this.upgradePassengerDataBtn.Location = new System.Drawing.Point(274, 36);
            this.upgradePassengerDataBtn.Name = "upgradePassengerDataBtn";
            this.upgradePassengerDataBtn.Size = new System.Drawing.Size(222, 41);
            this.upgradePassengerDataBtn.TabIndex = 7;
            this.upgradePassengerDataBtn.Text = "Update passenger\'s data";
            this.upgradePassengerDataBtn.UseVisualStyleBackColor = true;
            this.upgradePassengerDataBtn.Click += new System.EventHandler(this.upgradePassengerDataBtn_Click);
            // 
            // viewTicketDetailsBtn
            // 
            this.viewTicketDetailsBtn.Location = new System.Drawing.Point(27, 90);
            this.viewTicketDetailsBtn.Name = "viewTicketDetailsBtn";
            this.viewTicketDetailsBtn.Size = new System.Drawing.Size(222, 41);
            this.viewTicketDetailsBtn.TabIndex = 6;
            this.viewTicketDetailsBtn.Text = "View ticket details";
            this.viewTicketDetailsBtn.UseVisualStyleBackColor = true;
            this.viewTicketDetailsBtn.Click += new System.EventHandler(this.viewTicketDetailsBtn_Click);
            // 
            // viewPassengersDataBtn
            // 
            this.viewPassengersDataBtn.Location = new System.Drawing.Point(23, 36);
            this.viewPassengersDataBtn.Name = "viewPassengersDataBtn";
            this.viewPassengersDataBtn.Size = new System.Drawing.Size(222, 41);
            this.viewPassengersDataBtn.TabIndex = 5;
            this.viewPassengersDataBtn.Text = "View passenger\'s data";
            this.viewPassengersDataBtn.UseVisualStyleBackColor = true;
            this.viewPassengersDataBtn.Click += new System.EventHandler(this.viewPassengersDataBtn_Click);
            // 
            // cancelTicketBtn
            // 
            this.cancelTicketBtn.Location = new System.Drawing.Point(278, 90);
            this.cancelTicketBtn.Name = "cancelTicketBtn";
            this.cancelTicketBtn.Size = new System.Drawing.Size(222, 41);
            this.cancelTicketBtn.TabIndex = 4;
            this.cancelTicketBtn.Text = "Cancel a ticket";
            this.cancelTicketBtn.UseVisualStyleBackColor = true;
            this.cancelTicketBtn.Click += new System.EventHandler(this.cancelTicketBtn_Click);
            // 
            // checkTrainStatusBtn
            // 
            this.checkTrainStatusBtn.Location = new System.Drawing.Point(27, 31);
            this.checkTrainStatusBtn.Name = "checkTrainStatusBtn";
            this.checkTrainStatusBtn.Size = new System.Drawing.Size(222, 41);
            this.checkTrainStatusBtn.TabIndex = 8;
            this.checkTrainStatusBtn.Text = "Check train\'s status";
            this.checkTrainStatusBtn.UseVisualStyleBackColor = true;
            this.checkTrainStatusBtn.Click += new System.EventHandler(this.checkTrainStatusBtn_Click);
            // 
            // Ticket
            // 
            this.Ticket.Controls.Add(this.viewTicketDetailsBtn);
            this.Ticket.Controls.Add(this.cancelTicketBtn);
            this.Ticket.Controls.Add(this.bookTicketBtn);
            this.Ticket.Controls.Add(this.upgradeTicketBtn);
            this.Ticket.Location = new System.Drawing.Point(10, 35);
            this.Ticket.Name = "Ticket";
            this.Ticket.Size = new System.Drawing.Size(524, 154);
            this.Ticket.TabIndex = 9;
            this.Ticket.TabStop = false;
            this.Ticket.Text = "Ticket";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upgradePassengerDataBtn);
            this.groupBox1.Controls.Add(this.viewPassengersDataBtn);
            this.groupBox1.Location = new System.Drawing.Point(14, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 112);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passenger";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewAvailableTripsBtn);
            this.groupBox2.Controls.Add(this.viewAvailableSeatsBtn);
            this.groupBox2.Location = new System.Drawing.Point(10, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 94);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trip";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkTrainStatusBtn);
            this.groupBox3.Location = new System.Drawing.Point(10, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 91);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Train";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 575);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Ticket);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Ticket.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button viewAvailableSeatsBtn;
        private System.Windows.Forms.Button upgradeTicketBtn;
        private System.Windows.Forms.Button bookTicketBtn;
        private System.Windows.Forms.Button viewAvailableTripsBtn;
        private System.Windows.Forms.Button upgradePassengerDataBtn;
        private System.Windows.Forms.Button viewTicketDetailsBtn;
        private System.Windows.Forms.Button viewPassengersDataBtn;
        private System.Windows.Forms.Button cancelTicketBtn;
        private System.Windows.Forms.Button checkTrainStatusBtn;
        private System.Windows.Forms.GroupBox Ticket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}