
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_admin));
            this.RemoveAdminButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Remove_Admin_comboBox = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveAdminButton
            // 
            this.RemoveAdminButton.Location = new System.Drawing.Point(310, 214);
            this.RemoveAdminButton.Margin = new System.Windows.Forms.Padding(8);
            this.RemoveAdminButton.Name = "RemoveAdminButton";
            this.RemoveAdminButton.Size = new System.Drawing.Size(286, 60);
            this.RemoveAdminButton.TabIndex = 5;
            this.RemoveAdminButton.Text = "Remove Admin";
            this.RemoveAdminButton.UseVisualStyleBackColor = true;
            this.RemoveAdminButton.Click += new System.EventHandler(this.RemoveAdminButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 18.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(138, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // Remove_Admin_comboBox
            // 
            this.Remove_Admin_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Remove_Admin_comboBox.FormattingEnabled = true;
            this.Remove_Admin_comboBox.Location = new System.Drawing.Point(274, 115);
            this.Remove_Admin_comboBox.Margin = new System.Windows.Forms.Padding(8);
            this.Remove_Admin_comboBox.Name = "Remove_Admin_comboBox";
            this.Remove_Admin_comboBox.Size = new System.Drawing.Size(345, 42);
            this.Remove_Admin_comboBox.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(598, 303);
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
            this.Exit.Location = new System.Drawing.Point(724, 303);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 61;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Remove_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 384);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Remove_Admin_comboBox);
            this.Controls.Add(this.RemoveAdminButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Remove_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Admin";
            this.Load += new System.EventHandler(this.Remove_admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveAdminButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Remove_Admin_comboBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}