
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpgradeTicket_CB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(298, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Upgrade Ticket";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(220, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 34);
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
            // Upgrade_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpgradeTicket_CB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Upgrade_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upgrade_Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UpgradeTicket_CB;
    }
}