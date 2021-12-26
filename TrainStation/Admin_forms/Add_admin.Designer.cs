
namespace TrainStation.Admin_forms
{
    partial class Add_admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddAdminEmailtextBox = new System.Windows.Forms.TextBox();
            this.AddAdminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(107, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // AddAdminEmailtextBox
            // 
            this.AddAdminEmailtextBox.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.AddAdminEmailtextBox.Location = new System.Drawing.Point(208, 144);
            this.AddAdminEmailtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddAdminEmailtextBox.Name = "AddAdminEmailtextBox";
            this.AddAdminEmailtextBox.Size = new System.Drawing.Size(257, 31);
            this.AddAdminEmailtextBox.TabIndex = 1;
            // 
            // AddAdminButton
            // 
            this.AddAdminButton.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.AddAdminButton.Location = new System.Drawing.Point(279, 195);
            this.AddAdminButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddAdminButton.Name = "AddAdminButton";
            this.AddAdminButton.Size = new System.Drawing.Size(113, 44);
            this.AddAdminButton.TabIndex = 2;
            this.AddAdminButton.Text = "Add Admin";
            this.AddAdminButton.UseVisualStyleBackColor = true;
            this.AddAdminButton.Click += new System.EventHandler(this.AddAdminButton_Click);
            // 
            // Add_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 336);
            this.Controls.Add(this.AddAdminButton);
            this.Controls.Add(this.AddAdminEmailtextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddAdminEmailtextBox;
        private System.Windows.Forms.Button AddAdminButton;
    }
}