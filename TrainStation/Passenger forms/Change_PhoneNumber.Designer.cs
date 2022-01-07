
namespace TrainStation.Passenger_forms
{
    partial class Change_PhoneNumber
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
            this.Change_Phone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.New_Phone_Num_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Old_Phone_Num_TB = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Change_Phone
            // 
            this.Change_Phone.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.Change_Phone.Location = new System.Drawing.Point(272, 266);
            this.Change_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Change_Phone.Name = "Change_Phone";
            this.Change_Phone.Size = new System.Drawing.Size(324, 47);
            this.Change_Phone.TabIndex = 16;
            this.Change_Phone.Text = "Change Phone Number";
            this.Change_Phone.UseVisualStyleBackColor = true;
            this.Change_Phone.Click += new System.EventHandler(this.Change_Phone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(116, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "New Phone Number";
            // 
            // New_Phone_Num_TB
            // 
            this.New_Phone_Num_TB.BackColor = System.Drawing.SystemColors.Control;
            this.New_Phone_Num_TB.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.New_Phone_Num_TB.Location = new System.Drawing.Point(451, 187);
            this.New_Phone_Num_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.New_Phone_Num_TB.Name = "New_Phone_Num_TB";
            this.New_Phone_Num_TB.Size = new System.Drawing.Size(249, 41);
            this.New_Phone_Num_TB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(131, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 34);
            this.label5.TabIndex = 18;
            this.label5.Text = "Old Phone Number";
            // 
            // Old_Phone_Num_TB
            // 
            this.Old_Phone_Num_TB.BackColor = System.Drawing.SystemColors.Control;
            this.Old_Phone_Num_TB.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Old_Phone_Num_TB.Location = new System.Drawing.Point(451, 136);
            this.Old_Phone_Num_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Old_Phone_Num_TB.Name = "Old_Phone_Num_TB";
            this.Old_Phone_Num_TB.Size = new System.Drawing.Size(249, 41);
            this.Old_Phone_Num_TB.TabIndex = 17;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(555, 373);
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
            this.Exit.Location = new System.Drawing.Point(681, 373);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 61;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Change_PhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 445);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Old_Phone_Num_TB);
            this.Controls.Add(this.Change_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.New_Phone_Num_TB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Change_PhoneNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_PhoneNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Change_Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox New_Phone_Num_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Old_Phone_Num_TB;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}