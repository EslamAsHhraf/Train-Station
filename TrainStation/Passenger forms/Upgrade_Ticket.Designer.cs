
namespace TrainStation.Passenger_forms
{
    partial class Upgrade_Ticket
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
            this.Upgrade_Ticket_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpgradeTicket_CB = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Upgrade_Ticket_Button
            // 
            this.Upgrade_Ticket_Button.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Upgrade_Ticket_Button.Location = new System.Drawing.Point(298, 285);
            this.Upgrade_Ticket_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Upgrade_Ticket_Button.Name = "Upgrade_Ticket_Button";
            this.Upgrade_Ticket_Button.Size = new System.Drawing.Size(238, 53);
            this.Upgrade_Ticket_Button.TabIndex = 8;
            this.Upgrade_Ticket_Button.Text = "Upgrade Ticket";
            this.Upgrade_Ticket_Button.UseVisualStyleBackColor = true;
            this.Upgrade_Ticket_Button.Click += new System.EventHandler(this.Upgrade_Ticket_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(220, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ticket Number";
            // 
            // UpgradeTicket_CB
            // 
            this.UpgradeTicket_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpgradeTicket_CB.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.UpgradeTicket_CB.FormattingEnabled = true;
            this.UpgradeTicket_CB.Location = new System.Drawing.Point(455, 174);
            this.UpgradeTicket_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpgradeTicket_CB.Name = "UpgradeTicket_CB";
            this.UpgradeTicket_CB.Size = new System.Drawing.Size(168, 42);
            this.UpgradeTicket_CB.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(525, 405);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 59);
            this.Back.TabIndex = 64;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(651, 405);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 63;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Upgrade_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Upgrade_Ticket_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpgradeTicket_CB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Upgrade_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upgrade_Ticket";
            this.Load += new System.EventHandler(this.Upgrade_Ticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Upgrade_Ticket_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UpgradeTicket_CB;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}