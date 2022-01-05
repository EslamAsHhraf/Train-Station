
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
            this.AddAdminButton = new System.Windows.Forms.Button();
            this.AddAdminEmailComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(80, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // AddAdminButton
            // 
            this.AddAdminButton.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.AddAdminButton.Location = new System.Drawing.Point(209, 158);
            this.AddAdminButton.Name = "AddAdminButton";
            this.AddAdminButton.Size = new System.Drawing.Size(85, 36);
            this.AddAdminButton.TabIndex = 2;
            this.AddAdminButton.Text = "Add Admin";
            this.AddAdminButton.UseVisualStyleBackColor = true;
            this.AddAdminButton.Click += new System.EventHandler(this.AddAdminButton_Click);
            // 
            // AddAdminEmailComboBox
            // 
            this.AddAdminEmailComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddAdminEmailComboBox.FormattingEnabled = true;
            this.AddAdminEmailComboBox.Location = new System.Drawing.Point(164, 121);
            this.AddAdminEmailComboBox.Name = "AddAdminEmailComboBox";
            this.AddAdminEmailComboBox.Size = new System.Drawing.Size(226, 21);
            this.AddAdminEmailComboBox.TabIndex = 3;
            // 
            // Add_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 273);
            this.Controls.Add(this.AddAdminEmailComboBox);
            this.Controls.Add(this.AddAdminButton);
            this.Controls.Add(this.label1);
            this.Name = "Add_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAdminButton;
        private System.Windows.Forms.ComboBox AddAdminEmailComboBox;
    }
}