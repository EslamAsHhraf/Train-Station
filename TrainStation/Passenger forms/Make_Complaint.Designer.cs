
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Complaint_Description
            // 
            this.Complaint_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Complaint_Description.BackColor = System.Drawing.Color.Silver;
            this.Complaint_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Complaint_Description.Location = new System.Drawing.Point(45, 146);
            this.Complaint_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Complaint_Description.MaxLength = 200;
            this.Complaint_Description.Multiline = true;
            this.Complaint_Description.Name = "Complaint_Description";
            this.Complaint_Description.Size = new System.Drawing.Size(803, 206);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(680, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Make_Complaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 479);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}