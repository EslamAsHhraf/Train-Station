
namespace TrainStation.Admin_forms
{
    partial class Fire_employee
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
            this.SSN = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Fireemployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SSN
            // 
            this.SSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSN.FormattingEnabled = true;
            this.SSN.Location = new System.Drawing.Point(193, 151);
            this.SSN.Margin = new System.Windows.Forms.Padding(4);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(150, 29);
            this.SSN.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "SSN";
            // 
            // Fireemployee
            // 
            this.Fireemployee.Location = new System.Drawing.Point(268, 265);
            this.Fireemployee.Margin = new System.Windows.Forms.Padding(4);
            this.Fireemployee.Name = "Fireemployee";
            this.Fireemployee.Size = new System.Drawing.Size(221, 52);
            this.Fireemployee.TabIndex = 27;
            this.Fireemployee.Text = "Fire Employee";
            this.Fireemployee.UseVisualStyleBackColor = true;
            this.Fireemployee.Click += new System.EventHandler(this.Fireemployee_Click);
            // 
            // Fire_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 425);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fireemployee);
            this.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fire_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fire_employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SSN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Fireemployee;
    }
}