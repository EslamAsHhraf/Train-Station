
namespace TrainStation.Passenger_forms
{
    partial class Make_Complaint
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
            this.Complaint_Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit_Complaint = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Complaint_Description
            // 
            this.Complaint_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Complaint_Description.BackColor = System.Drawing.Color.Silver;
            this.Complaint_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Complaint_Description.Location = new System.Drawing.Point(45, 181);
            this.Complaint_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Complaint_Description.MaxLength = 200;
            this.Complaint_Description.Multiline = true;
            this.Complaint_Description.Name = "Complaint_Description";
            this.Complaint_Description.Size = new System.Drawing.Size(833, 206);
            this.Complaint_Description.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complaint Description";
            // 
            // Submit_Complaint
            // 
            this.Submit_Complaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Submit_Complaint.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.Submit_Complaint.Location = new System.Drawing.Point(700, 406);
            this.Submit_Complaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Submit_Complaint.Name = "Submit_Complaint";
            this.Submit_Complaint.Size = new System.Drawing.Size(168, 50);
            this.Submit_Complaint.TabIndex = 2;
            this.Submit_Complaint.Text = "Submit";
            this.Submit_Complaint.UseVisualStyleBackColor = true;
            this.Submit_Complaint.Click += new System.EventHandler(this.Submit_Complaint_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(624, 477);
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
            this.Exit.Location = new System.Drawing.Point(750, 477);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 61;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Make_Complaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 549);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Submit_Complaint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Complaint_Description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Make_Complaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make_Complaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Complaint_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit_Complaint;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}