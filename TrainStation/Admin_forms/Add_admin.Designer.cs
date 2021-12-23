
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
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // AddAdminEmailtextBox
            // 
            this.AddAdminEmailtextBox.Location = new System.Drawing.Point(83, 33);
            this.AddAdminEmailtextBox.Name = "AddAdminEmailtextBox";
            this.AddAdminEmailtextBox.Size = new System.Drawing.Size(194, 20);
            this.AddAdminEmailtextBox.TabIndex = 1;
            // 
            // AddAdminButton
            // 
            this.AddAdminButton.Location = new System.Drawing.Point(128, 102);
            this.AddAdminButton.Name = "AddAdminButton";
            this.AddAdminButton.Size = new System.Drawing.Size(75, 23);
            this.AddAdminButton.TabIndex = 2;
            this.AddAdminButton.Text = "Add Admin";
            this.AddAdminButton.UseVisualStyleBackColor = true;
            // 
            // Add_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 193);
            this.Controls.Add(this.AddAdminButton);
            this.Controls.Add(this.AddAdminEmailtextBox);
            this.Controls.Add(this.label1);
            this.Name = "Add_admin";
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