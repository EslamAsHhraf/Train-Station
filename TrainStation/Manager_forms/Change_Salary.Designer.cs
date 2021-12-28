
namespace TrainStation.Manager_forms
{
    partial class Change_Salary
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
            this.Salary = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChangeSalary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).BeginInit();
            this.SuspendLayout();
            // 
            // SSN
            // 
            this.SSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSN.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.SSN.FormattingEnabled = true;
            this.SSN.Location = new System.Drawing.Point(269, 186);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(160, 29);
            this.SSN.TabIndex = 34;
            // 
            // Salary
            // 
            this.Salary.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.Salary.Location = new System.Drawing.Point(468, 186);
            this.Salary.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(144, 29);
            this.Salary.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(464, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(265, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "SSN";
            // 
            // ChangeSalary
            // 
            this.ChangeSalary.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.ChangeSalary.Location = new System.Drawing.Point(314, 273);
            this.ChangeSalary.Name = "ChangeSalary";
            this.ChangeSalary.Size = new System.Drawing.Size(264, 51);
            this.ChangeSalary.TabIndex = 30;
            this.ChangeSalary.Text = "Change salary of employee";
            this.ChangeSalary.UseVisualStyleBackColor = true;
            this.ChangeSalary.Click += new System.EventHandler(this.ChangeSalary_Click);
            // 
            // Change_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 479);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangeSalary);
            this.Name = "Change_Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_Salary";
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SSN;
        private System.Windows.Forms.NumericUpDown Salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChangeSalary;
    }
}