
namespace TrainStation.Passenger_forms
{
    partial class Edit_Profile
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
            this.Change_Phone_Number = new System.Windows.Forms.Button();
            this.Change_Email = new System.Windows.Forms.Button();
            this.Change_Password = new System.Windows.Forms.Button();
            this.Add_Phone_Number = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Change_Phone_Number
            // 
            this.Change_Phone_Number.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.Change_Phone_Number.Location = new System.Drawing.Point(255, 106);
            this.Change_Phone_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Change_Phone_Number.Name = "Change_Phone_Number";
            this.Change_Phone_Number.Size = new System.Drawing.Size(333, 42);
            this.Change_Phone_Number.TabIndex = 5;
            this.Change_Phone_Number.Text = "Change Phone Number";
            this.Change_Phone_Number.UseVisualStyleBackColor = true;
            this.Change_Phone_Number.Click += new System.EventHandler(this.Change_Phone_Number_Click);
            // 
            // Change_Email
            // 
            this.Change_Email.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.Change_Email.Location = new System.Drawing.Point(255, 217);
            this.Change_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Change_Email.Name = "Change_Email";
            this.Change_Email.Size = new System.Drawing.Size(333, 42);
            this.Change_Email.TabIndex = 6;
            this.Change_Email.Text = "Change Email";
            this.Change_Email.UseVisualStyleBackColor = true;
            this.Change_Email.Click += new System.EventHandler(this.Change_Email_Click);
            // 
            // Change_Password
            // 
            this.Change_Password.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.Change_Password.Location = new System.Drawing.Point(255, 272);
            this.Change_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Change_Password.Name = "Change_Password";
            this.Change_Password.Size = new System.Drawing.Size(333, 42);
            this.Change_Password.TabIndex = 7;
            this.Change_Password.Text = "Change Password";
            this.Change_Password.UseVisualStyleBackColor = true;
            this.Change_Password.Click += new System.EventHandler(this.Change_Password_Click);
            // 
            // Add_Phone_Number
            // 
            this.Add_Phone_Number.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.Add_Phone_Number.Location = new System.Drawing.Point(255, 162);
            this.Add_Phone_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Phone_Number.Name = "Add_Phone_Number";
            this.Add_Phone_Number.Size = new System.Drawing.Size(333, 42);
            this.Add_Phone_Number.TabIndex = 8;
            this.Add_Phone_Number.Text = "Add Phone Number";
            this.Add_Phone_Number.UseVisualStyleBackColor = true;
            this.Add_Phone_Number.Click += new System.EventHandler(this.Add_Phone_Number_Click);
            // 
            // Edit_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 443);
            this.Controls.Add(this.Add_Phone_Number);
            this.Controls.Add(this.Change_Phone_Number);
            this.Controls.Add(this.Change_Password);
            this.Controls.Add(this.Change_Email);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Edit_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Profile";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Change_Phone_Number;
        private System.Windows.Forms.Button Change_Email;
        private System.Windows.Forms.Button Change_Password;
        private System.Windows.Forms.Button Add_Phone_Number;
    }
}