
namespace TrainStation
{
    partial class Admin
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
            this.AddAdminButton = new System.Windows.Forms.Button();
            this.RemoveAdminbutton = new System.Windows.Forms.Button();
            this.BlockUserbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAdminButton
            // 
            this.AddAdminButton.Location = new System.Drawing.Point(305, 34);
            this.AddAdminButton.Name = "AddAdminButton";
            this.AddAdminButton.Size = new System.Drawing.Size(106, 33);
            this.AddAdminButton.TabIndex = 0;
            this.AddAdminButton.Text = "Add an admin";
            this.AddAdminButton.UseVisualStyleBackColor = true;
            this.AddAdminButton.Click += new System.EventHandler(this.AddAdminButton_Click);
            // 
            // RemoveAdminbutton
            // 
            this.RemoveAdminbutton.Location = new System.Drawing.Point(116, 34);
            this.RemoveAdminbutton.Name = "RemoveAdminbutton";
            this.RemoveAdminbutton.Size = new System.Drawing.Size(106, 33);
            this.RemoveAdminbutton.TabIndex = 1;
            this.RemoveAdminbutton.Text = "Remove an admin";
            this.RemoveAdminbutton.UseVisualStyleBackColor = true;
            this.RemoveAdminbutton.Click += new System.EventHandler(this.RemoveAdminbutton_Click);
            // 
            // BlockUserbutton
            // 
            this.BlockUserbutton.Location = new System.Drawing.Point(209, 101);
            this.BlockUserbutton.Name = "BlockUserbutton";
            this.BlockUserbutton.Size = new System.Drawing.Size(106, 33);
            this.BlockUserbutton.TabIndex = 2;
            this.BlockUserbutton.Text = "Block User";
            this.BlockUserbutton.UseVisualStyleBackColor = true;
            this.BlockUserbutton.Click += new System.EventHandler(this.BlockUserbutton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 343);
            this.Controls.Add(this.BlockUserbutton);
            this.Controls.Add(this.RemoveAdminbutton);
            this.Controls.Add(this.AddAdminButton);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddAdminButton;
        private System.Windows.Forms.Button RemoveAdminbutton;
        private System.Windows.Forms.Button BlockUserbutton;
    }
}