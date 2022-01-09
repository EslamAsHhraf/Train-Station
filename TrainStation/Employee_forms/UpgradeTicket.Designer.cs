
namespace TrainStation
{
    partial class UpgradeTicket
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
            this.ticketSerialNoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.newClassComboBox = new System.Windows.Forms.ComboBox();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ticketSerialNoComboBox
            // 
            this.ticketSerialNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ticketSerialNoComboBox.FormattingEnabled = true;
            this.ticketSerialNoComboBox.Location = new System.Drawing.Point(210, 111);
            this.ticketSerialNoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ticketSerialNoComboBox.Name = "ticketSerialNoComboBox";
            this.ticketSerialNoComboBox.Size = new System.Drawing.Size(258, 29);
            this.ticketSerialNoComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticket\'s Serial Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Class";
            // 
            // newClassComboBox
            // 
            this.newClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newClassComboBox.FormattingEnabled = true;
            this.newClassComboBox.Items.AddRange(new object[] {
            "VIP",
            "General"});
            this.newClassComboBox.Location = new System.Drawing.Point(210, 225);
            this.newClassComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.newClassComboBox.Name = "newClassComboBox";
            this.newClassComboBox.Size = new System.Drawing.Size(258, 29);
            this.newClassComboBox.TabIndex = 2;
            // 
            // upgradeButton
            // 
            this.upgradeButton.Location = new System.Drawing.Point(271, 398);
            this.upgradeButton.Margin = new System.Windows.Forms.Padding(4);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(148, 46);
            this.upgradeButton.TabIndex = 7;
            this.upgradeButton.Text = "Upgrade";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(445, 452);
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
            this.Exit.Location = new System.Drawing.Point(571, 452);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 63;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UpgradeTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 524);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newClassComboBox);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketSerialNoComboBox);
            this.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpgradeTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpgradeTicket";
            this.Load += new System.EventHandler(this.UpgradeTicket_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ticketSerialNoComboBox;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox newClassComboBox;
        private System.Windows.Forms.Button upgradeButton;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}