
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
            this.label_ssn = new System.Windows.Forms.Label();
            this.Fireemployee = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
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
            // label_ssn
            // 
            this.label_ssn.AutoSize = true;
            this.label_ssn.Location = new System.Drawing.Point(128, 155);
            this.label_ssn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ssn.Name = "label_ssn";
            this.label_ssn.Size = new System.Drawing.Size(43, 21);
            this.label_ssn.TabIndex = 28;
            this.label_ssn.Text = "SSN";
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
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(526, 353);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 59);
            this.Back.TabIndex = 58;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(652, 353);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 57;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Fire_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 425);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label_ssn);
            this.Controls.Add(this.Fireemployee);
            this.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fire_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fire_employee";
            this.Load += new System.EventHandler(this.Fire_employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SSN;
        private System.Windows.Forms.Label label_ssn;
        private System.Windows.Forms.Button Fireemployee;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}