
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
            this.BeEmployeebutton = new System.Windows.Forms.Button();
            this.BeManagerbutton = new System.Windows.Forms.Button();
            this.sign_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAdminButton
            // 
            this.AddAdminButton.BackColor = System.Drawing.Color.Transparent;
            this.AddAdminButton.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.AddAdminButton.ForeColor = System.Drawing.Color.Black;
            this.AddAdminButton.Location = new System.Drawing.Point(301, 144);
            this.AddAdminButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddAdminButton.Name = "AddAdminButton";
            this.AddAdminButton.Size = new System.Drawing.Size(304, 41);
            this.AddAdminButton.TabIndex = 0;
            this.AddAdminButton.Text = "Add an admin";
            this.AddAdminButton.UseVisualStyleBackColor = false;
            this.AddAdminButton.Click += new System.EventHandler(this.AddAdminButton_Click);
            // 
            // RemoveAdminbutton
            // 
            this.RemoveAdminbutton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveAdminbutton.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.RemoveAdminbutton.ForeColor = System.Drawing.Color.Black;
            this.RemoveAdminbutton.Location = new System.Drawing.Point(301, 191);
            this.RemoveAdminbutton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveAdminbutton.Name = "RemoveAdminbutton";
            this.RemoveAdminbutton.Size = new System.Drawing.Size(304, 41);
            this.RemoveAdminbutton.TabIndex = 1;
            this.RemoveAdminbutton.Text = "Remove an admin";
            this.RemoveAdminbutton.UseVisualStyleBackColor = false;
            this.RemoveAdminbutton.Click += new System.EventHandler(this.RemoveAdminbutton_Click);
            // 
            // BlockUserbutton
            // 
            this.BlockUserbutton.BackColor = System.Drawing.Color.Transparent;
            this.BlockUserbutton.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.BlockUserbutton.ForeColor = System.Drawing.Color.Black;
            this.BlockUserbutton.Location = new System.Drawing.Point(301, 289);
            this.BlockUserbutton.Margin = new System.Windows.Forms.Padding(4);
            this.BlockUserbutton.Name = "BlockUserbutton";
            this.BlockUserbutton.Size = new System.Drawing.Size(304, 41);
            this.BlockUserbutton.TabIndex = 2;
            this.BlockUserbutton.Text = "Block User";
            this.BlockUserbutton.UseVisualStyleBackColor = false;
            this.BlockUserbutton.Click += new System.EventHandler(this.BlockUserbutton_Click);
            // 
            // BeEmployeebutton
            // 
            this.BeEmployeebutton.BackColor = System.Drawing.Color.Transparent;
            this.BeEmployeebutton.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.BeEmployeebutton.ForeColor = System.Drawing.Color.Black;
            this.BeEmployeebutton.Location = new System.Drawing.Point(301, 338);
            this.BeEmployeebutton.Margin = new System.Windows.Forms.Padding(4);
            this.BeEmployeebutton.Name = "BeEmployeebutton";
            this.BeEmployeebutton.Size = new System.Drawing.Size(304, 41);
            this.BeEmployeebutton.TabIndex = 3;
            this.BeEmployeebutton.Text = "Act as Employee";
            this.BeEmployeebutton.UseVisualStyleBackColor = false;
            this.BeEmployeebutton.Click += new System.EventHandler(this.BeEmployeebutton_Click);
            // 
            // BeManagerbutton
            // 
            this.BeManagerbutton.BackColor = System.Drawing.Color.Transparent;
            this.BeManagerbutton.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.BeManagerbutton.ForeColor = System.Drawing.Color.Black;
            this.BeManagerbutton.Location = new System.Drawing.Point(301, 240);
            this.BeManagerbutton.Margin = new System.Windows.Forms.Padding(4);
            this.BeManagerbutton.Name = "BeManagerbutton";
            this.BeManagerbutton.Size = new System.Drawing.Size(304, 41);
            this.BeManagerbutton.TabIndex = 4;
            this.BeManagerbutton.Text = "Act as Manager";
            this.BeManagerbutton.UseVisualStyleBackColor = false;
            this.BeManagerbutton.Click += new System.EventHandler(this.BeManagerbutton_Click);
            // 
            // sign_out
            // 
            this.sign_out.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.sign_out.Location = new System.Drawing.Point(659, 451);
            this.sign_out.Name = "sign_out";
            this.sign_out.Size = new System.Drawing.Size(160, 52);
            this.sign_out.TabIndex = 22;
            this.sign_out.Text = "Sign Out";
            this.sign_out.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sign_out.UseVisualStyleBackColor = true;
            this.sign_out.Click += new System.EventHandler(this.sign_out_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 528);
            this.Controls.Add(this.sign_out);
            this.Controls.Add(this.BeManagerbutton);
            this.Controls.Add(this.BeEmployeebutton);
            this.Controls.Add(this.BlockUserbutton);
            this.Controls.Add(this.RemoveAdminbutton);
            this.Controls.Add(this.AddAdminButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddAdminButton;
        private System.Windows.Forms.Button RemoveAdminbutton;
        private System.Windows.Forms.Button BlockUserbutton;
        private System.Windows.Forms.Button BeEmployeebutton;
        private System.Windows.Forms.Button BeManagerbutton;
        private System.Windows.Forms.Button sign_out;
    }
}