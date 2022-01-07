
namespace TrainStation.Passenger_forms
{
    partial class Change_Email
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
            this.label3 = new System.Windows.Forms.Label();
            this.New_Email_TB = new System.Windows.Forms.TextBox();
            this.Change_Email_Button = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(222, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "New Email";
            // 
            // New_Email_TB
            // 
            this.New_Email_TB.BackColor = System.Drawing.SystemColors.Control;
            this.New_Email_TB.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.New_Email_TB.Location = new System.Drawing.Point(413, 150);
            this.New_Email_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.New_Email_TB.Name = "New_Email_TB";
            this.New_Email_TB.Size = new System.Drawing.Size(254, 41);
            this.New_Email_TB.TabIndex = 12;
            // 
            // Change_Email_Button
            // 
            this.Change_Email_Button.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.Change_Email_Button.Location = new System.Drawing.Point(292, 224);
            this.Change_Email_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Change_Email_Button.Name = "Change_Email_Button";
            this.Change_Email_Button.Size = new System.Drawing.Size(216, 59);
            this.Change_Email_Button.TabIndex = 14;
            this.Change_Email_Button.Text = "Change Email";
            this.Change_Email_Button.UseVisualStyleBackColor = true;
            this.Change_Email_Button.Click += new System.EventHandler(this.Change_Email_Button_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(601, 335);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 59);
            this.Back.TabIndex = 62;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(727, 335);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 61;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Change_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 407);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Change_Email_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.New_Email_TB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Change_Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox New_Email_TB;
        private System.Windows.Forms.Button Change_Email_Button;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}