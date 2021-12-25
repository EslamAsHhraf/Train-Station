
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
            this.label2 = new System.Windows.Forms.Label();
            this.trainStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trainPlateNumberComboBox
            // 
            this.trainPlateNumberComboBox.FormattingEnabled = true;
            this.trainPlateNumberComboBox.Location = new System.Drawing.Point(216, 75);
            this.trainPlateNumberComboBox.Name = "trainPlateNumberComboBox";
            this.trainPlateNumberComboBox.Size = new System.Drawing.Size(121, 24);
            this.trainPlateNumberComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Train\'s plate number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maintenance status:";
            // 
            // trainStatusLabel
            // 
            this.trainStatusLabel.AutoSize = true;
            this.trainStatusLabel.Location = new System.Drawing.Point(213, 187);
            this.trainStatusLabel.Name = "trainStatusLabel";
            this.trainStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.trainStatusLabel.TabIndex = 3;
            this.trainStatusLabel.Text = "//To be chnaged";
            // 
            // TrainStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 292);
            this.Controls.Add(this.trainStatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainPlateNumberComboBox);
            this.Name = "TrainStatus";
            this.Text = "TrainStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox trainPlateNumberComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label trainStatusLabel;
    }
}