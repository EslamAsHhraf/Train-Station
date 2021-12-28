
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rate_employee = new System.Windows.Forms.Button();
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
            10,
            0,
            0,
            0});
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(150, 29);
            this.Rate.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "SSN";
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
            // Change_rate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 454);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rate_employee);
            this.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Change_rate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_rate";
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SSN;
        private System.Windows.Forms.NumericUpDown Rate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rate_employee;
    }
}