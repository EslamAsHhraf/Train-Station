
namespace TrainStation
{
    partial class UserLog
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
            this.label2 = new System.Windows.Forms.Label();
            this.LogIn_Email_TextBox = new System.Windows.Forms.TextBox();
            this.LogIn_Pass_TextBox = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.Create_acc = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(148, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(148, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // LogIn_Email_TextBox
            // 
            this.LogIn_Email_TextBox.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.LogIn_Email_TextBox.Location = new System.Drawing.Point(269, 84);
            this.LogIn_Email_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogIn_Email_TextBox.Name = "LogIn_Email_TextBox";
            this.LogIn_Email_TextBox.Size = new System.Drawing.Size(175, 34);
            this.LogIn_Email_TextBox.TabIndex = 2;
            // 
            // LogIn_Pass_TextBox
            // 
            this.LogIn_Pass_TextBox.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.LogIn_Pass_TextBox.Location = new System.Drawing.Point(269, 128);
            this.LogIn_Pass_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogIn_Pass_TextBox.Name = "LogIn_Pass_TextBox";
            this.LogIn_Pass_TextBox.PasswordChar = '*';
            this.LogIn_Pass_TextBox.Size = new System.Drawing.Size(175, 34);
            this.LogIn_Pass_TextBox.TabIndex = 3;
            // 
            // LogInButton
            // 
            this.LogInButton.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.LogInButton.Location = new System.Drawing.Point(221, 188);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(222, 37);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Log in";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click_1);
            // 
            // Create_acc
            // 
            this.Create_acc.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Create_acc.Location = new System.Drawing.Point(221, 240);
            this.Create_acc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Create_acc.Name = "Create_acc";
            this.Create_acc.Size = new System.Drawing.Size(226, 36);
            this.Create_acc.TabIndex = 5;
            this.Create_acc.Text = "Creat new account";
            this.Create_acc.UseVisualStyleBackColor = true;
            this.Create_acc.Click += new System.EventHandler(this.Create_acc_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Close.Location = new System.Drawing.Point(430, 325);
            this.Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(188, 37);
            this.Close.TabIndex = 6;
            this.Close.Text = "Close program";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // UserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 412);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Create_acc);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.LogIn_Pass_TextBox);
            this.Controls.Add(this.LogIn_Email_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LogIn_Email_TextBox;
        private System.Windows.Forms.TextBox LogIn_Pass_TextBox;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button Create_acc;
        private System.Windows.Forms.Button Close;
    }
}

