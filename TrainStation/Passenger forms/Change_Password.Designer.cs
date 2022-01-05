
namespace TrainStation.Passenger_forms
{
    partial class Change_Password
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
            this.label4 = new System.Windows.Forms.Label();
            this.New_Pass_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Old_Pass_TB = new System.Windows.Forms.TextBox();
            this.Change_Pass_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(286, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 39);
            this.label4.TabIndex = 14;
            this.label4.Text = "New Password";
            // 
            // New_Pass_TB
            // 
            this.New_Pass_TB.BackColor = System.Drawing.SystemColors.Control;
            this.New_Pass_TB.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.New_Pass_TB.Location = new System.Drawing.Point(543, 201);
            this.New_Pass_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.New_Pass_TB.Name = "New_Pass_TB";
            this.New_Pass_TB.Size = new System.Drawing.Size(289, 48);
            this.New_Pass_TB.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(286, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Old Password";
            // 
            // Old_Pass_TB
            // 
            this.Old_Pass_TB.BackColor = System.Drawing.SystemColors.Control;
            this.Old_Pass_TB.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Old_Pass_TB.Location = new System.Drawing.Point(543, 132);
            this.Old_Pass_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Old_Pass_TB.Name = "Old_Pass_TB";
            this.Old_Pass_TB.Size = new System.Drawing.Size(289, 48);
            this.Old_Pass_TB.TabIndex = 15;
            // 
            // Change_Pass_Button
            // 
            this.Change_Pass_Button.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.Change_Pass_Button.Location = new System.Drawing.Point(377, 315);
            this.Change_Pass_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Change_Pass_Button.Name = "Change_Pass_Button";
            this.Change_Pass_Button.Size = new System.Drawing.Size(300, 56);
            this.Change_Pass_Button.TabIndex = 17;
            this.Change_Pass_Button.Text = "Change Password";
            this.Change_Pass_Button.UseVisualStyleBackColor = true;
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 524);
            this.Controls.Add(this.Change_Pass_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Old_Pass_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.New_Pass_TB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox New_Pass_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Old_Pass_TB;
        private System.Windows.Forms.Button Change_Pass_Button;
    }
}