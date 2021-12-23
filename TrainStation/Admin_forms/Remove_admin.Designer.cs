
namespace TrainStation.Admin_forms
{
    partial class Remove_admin
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
            this.RemoveAdminButton = new System.Windows.Forms.Button();
            this.RemoveAdminEmailtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveAdminButton
            // 
            this.RemoveAdminButton.Location = new System.Drawing.Point(115, 107);
            this.RemoveAdminButton.Name = "RemoveAdminButton";
            this.RemoveAdminButton.Size = new System.Drawing.Size(107, 23);
            this.RemoveAdminButton.TabIndex = 5;
            this.RemoveAdminButton.Text = "Remove Admin";
            this.RemoveAdminButton.UseVisualStyleBackColor = true;
            // 
            // RemoveAdminEmailtextBox
            // 
            this.RemoveAdminEmailtextBox.Location = new System.Drawing.Point(101, 36);
            this.RemoveAdminEmailtextBox.Name = "RemoveAdminEmailtextBox";
            this.RemoveAdminEmailtextBox.Size = new System.Drawing.Size(194, 20);
            this.RemoveAdminEmailtextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // Remove_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 221);
            this.Controls.Add(this.RemoveAdminButton);
            this.Controls.Add(this.RemoveAdminEmailtextBox);
            this.Controls.Add(this.label1);
            this.Name = "Remove_admin";
            this.Text = "Remove Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveAdminButton;
        private System.Windows.Forms.TextBox RemoveAdminEmailtextBox;
        private System.Windows.Forms.Label label1;
    }
}