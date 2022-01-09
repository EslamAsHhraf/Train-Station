
namespace TrainStation
{
    partial class TrainStatus
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
            this.trainPlateNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowMaintenanceStatusButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trainPlateNumberComboBox
            // 
            this.trainPlateNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainPlateNumberComboBox.FormattingEnabled = true;
            this.trainPlateNumberComboBox.Location = new System.Drawing.Point(432, 159);
            this.trainPlateNumberComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.trainPlateNumberComboBox.Name = "trainPlateNumberComboBox";
            this.trainPlateNumberComboBox.Size = new System.Drawing.Size(238, 42);
            this.trainPlateNumberComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Train\'s plate number";
            // 
            // ShowMaintenanceStatusButton
            // 
            this.ShowMaintenanceStatusButton.Location = new System.Drawing.Point(193, 334);
            this.ShowMaintenanceStatusButton.Name = "ShowMaintenanceStatusButton";
            this.ShowMaintenanceStatusButton.Size = new System.Drawing.Size(392, 58);
            this.ShowMaintenanceStatusButton.TabIndex = 4;
            this.ShowMaintenanceStatusButton.Text = "Show Maintenance Status";
            this.ShowMaintenanceStatusButton.UseVisualStyleBackColor = true;
            this.ShowMaintenanceStatusButton.Click += new System.EventHandler(this.ShowMaintenanceStatusButton_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(523, 548);
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
            this.Exit.Location = new System.Drawing.Point(649, 548);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 63;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TrainStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.ClientSize = new System.Drawing.Size(780, 620);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ShowMaintenanceStatusButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainPlateNumberComboBox);
            this.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TrainStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainStatus";
            this.Load += new System.EventHandler(this.TrainStatus_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox trainPlateNumberComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowMaintenanceStatusButton;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}