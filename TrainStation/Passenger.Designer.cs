
namespace TrainStation
{
    partial class Passenger
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
            this.Edit_Profile = new System.Windows.Forms.Button();
            this.Cancel_Ticket = new System.Windows.Forms.Button();
            this.Ticket_Num_L = new System.Windows.Forms.Label();
            this.Upgrade_Ticket = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Ticket_Details = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Make_Complaint = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Edit_Profile
            // 
            this.Edit_Profile.Location = new System.Drawing.Point(15, 24);
            this.Edit_Profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit_Profile.Name = "Edit_Profile";
            this.Edit_Profile.Size = new System.Drawing.Size(234, 60);
            this.Edit_Profile.TabIndex = 0;
            this.Edit_Profile.Text = "Edit Profile";
            this.Edit_Profile.UseVisualStyleBackColor = true;
            // 
            // Cancel_Ticket
            // 
            this.Cancel_Ticket.Location = new System.Drawing.Point(215, 89);
            this.Cancel_Ticket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel_Ticket.Name = "Cancel_Ticket";
            this.Cancel_Ticket.Size = new System.Drawing.Size(179, 60);
            this.Cancel_Ticket.TabIndex = 3;
            this.Cancel_Ticket.Text = "Cancel Ticket";
            this.Cancel_Ticket.UseVisualStyleBackColor = true;
            // 
            // Ticket_Num_L
            // 
            this.Ticket_Num_L.AutoSize = true;
            this.Ticket_Num_L.Location = new System.Drawing.Point(514, 296);
            this.Ticket_Num_L.Name = "Ticket_Num_L";
            this.Ticket_Num_L.Size = new System.Drawing.Size(0, 20);
            this.Ticket_Num_L.TabIndex = 11;
            // 
            // Upgrade_Ticket
            // 
            this.Upgrade_Ticket.Location = new System.Drawing.Point(15, 89);
            this.Upgrade_Ticket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Upgrade_Ticket.Name = "Upgrade_Ticket";
            this.Upgrade_Ticket.Size = new System.Drawing.Size(179, 60);
            this.Upgrade_Ticket.TabIndex = 12;
            this.Upgrade_Ticket.Text = "Upgrade Ticket";
            this.Upgrade_Ticket.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 60);
            this.button1.TabIndex = 15;
            this.button1.Text = "Book Ticket";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Ticket_Details
            // 
            this.Ticket_Details.Location = new System.Drawing.Point(215, 25);
            this.Ticket_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ticket_Details.Name = "Ticket_Details";
            this.Ticket_Details.Size = new System.Drawing.Size(179, 60);
            this.Ticket_Details.TabIndex = 9;
            this.Ticket_Details.Text = "View Ticket Details";
            this.Ticket_Details.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Edit_Profile);
            this.groupBox1.Location = new System.Drawing.Point(25, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 104);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Make_Complaint);
            this.groupBox3.Location = new System.Drawing.Point(335, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 104);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Complaints";
            // 
            // Make_Complaint
            // 
            this.Make_Complaint.Location = new System.Drawing.Point(20, 24);
            this.Make_Complaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Make_Complaint.Name = "Make_Complaint";
            this.Make_Complaint.Size = new System.Drawing.Size(232, 60);
            this.Make_Complaint.TabIndex = 2;
            this.Make_Complaint.Text = "Make a Complaint";
            this.Make_Complaint.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Ticket_Details);
            this.groupBox2.Controls.Add(this.Upgrade_Ticket);
            this.groupBox2.Controls.Add(this.Cancel_Ticket);
            this.groupBox2.Location = new System.Drawing.Point(114, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 166);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket";
            // 
            // Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Ticket_Num_L);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Passenger";
            this.Text = "Passenger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Edit_Profile;
        private System.Windows.Forms.Button Cancel_Ticket;
        private System.Windows.Forms.Label Ticket_Num_L;
        private System.Windows.Forms.Button Upgrade_Ticket;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Ticket_Details;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Make_Complaint;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}