
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
            this.button1.Location = new System.Drawing.Point(123, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Upgrade Ticket";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ticket Number";
            // 
            // UpgradeTicket_CB
            // 
            this.UpgradeTicket_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpgradeTicket_CB.FormattingEnabled = true;
            this.UpgradeTicket_CB.Location = new System.Drawing.Point(257, 63);
            this.UpgradeTicket_CB.Name = "UpgradeTicket_CB";
            this.UpgradeTicket_CB.Size = new System.Drawing.Size(121, 28);
            this.UpgradeTicket_CB.TabIndex = 6;
            // 
            // Upgrade_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpgradeTicket_CB);
            this.Name = "Upgrade_Ticket";
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