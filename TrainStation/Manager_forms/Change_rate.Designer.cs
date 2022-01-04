
namespace TrainStation.Manager_forms
{
    partial class Change_rate
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
            this.Rate = new System.Windows.Forms.NumericUpDown();
            this.label_rate = new System.Windows.Forms.Label();
            this.label_ssn = new System.Windows.Forms.Label();
            this.Rate_employee = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).BeginInit();
            this.SuspendLayout();
            // 
            // SSN
            // 
            this.SSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSN.FormattingEnabled = true;
            this.SSN.Location = new System.Drawing.Point(217, 189);
            this.SSN.Margin = new System.Windows.Forms.Padding(4);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(150, 29);
            this.SSN.TabIndex = 35;
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(417, 189);
            this.Rate.Margin = new System.Windows.Forms.Padding(4);
            this.Rate.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(150, 29);
            this.Rate.TabIndex = 34;
            // 
            // label_rate
            // 
            this.label_rate.AutoSize = true;
            this.label_rate.Location = new System.Drawing.Point(413, 155);
            this.label_rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_rate.Name = "label_rate";
            this.label_rate.Size = new System.Drawing.Size(50, 21);
            this.label_rate.TabIndex = 33;
            this.label_rate.Text = "Rate";
            // 
            // label_ssn
            // 
            this.label_ssn.AutoSize = true;
            this.label_ssn.Location = new System.Drawing.Point(213, 155);
            this.label_ssn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ssn.Name = "label_ssn";
            this.label_ssn.Size = new System.Drawing.Size(43, 21);
            this.label_ssn.TabIndex = 32;
            this.label_ssn.Text = "SSN";
            // 
            // Rate_employee
            // 
            this.Rate_employee.Location = new System.Drawing.Point(288, 277);
            this.Rate_employee.Margin = new System.Windows.Forms.Padding(4);
            this.Rate_employee.Name = "Rate_employee";
            this.Rate_employee.Size = new System.Drawing.Size(222, 67);
            this.Rate_employee.TabIndex = 31;
            this.Rate_employee.Text = "Change rate of employee";
            this.Rate_employee.UseVisualStyleBackColor = true;
            this.Rate_employee.Click += new System.EventHandler(this.Rate_employee_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(558, 368);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 59);
            this.Back.TabIndex = 60;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(684, 368);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 59;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Change_rate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 454);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.label_rate);
            this.Controls.Add(this.label_ssn);
            this.Controls.Add(this.Rate_employee);
            this.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Change_rate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_rate";
            this.Load += new System.EventHandler(this.Change_rate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SSN;
        private System.Windows.Forms.NumericUpDown Rate;
        private System.Windows.Forms.Label label_rate;
        private System.Windows.Forms.Label label_ssn;
        private System.Windows.Forms.Button Rate_employee;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}