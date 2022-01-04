
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
            this.label_salary = new System.Windows.Forms.Label();
            this.label_ssn = new System.Windows.Forms.Label();
            this.ChangeSalary = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
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
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_salary.Location = new System.Drawing.Point(464, 152);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(60, 21);
            this.label_salary.TabIndex = 32;
            this.label_salary.Text = "Salary";
            // 
            // label_ssn
            // 
            this.label_ssn.AutoSize = true;
            this.label_ssn.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_ssn.Location = new System.Drawing.Point(265, 152);
            this.label_ssn.Name = "label_ssn";
            this.label_ssn.Size = new System.Drawing.Size(43, 21);
            this.label_ssn.TabIndex = 31;
            this.label_ssn.Text = "SSN";
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
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(583, 391);
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
            this.Exit.Location = new System.Drawing.Point(709, 391);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 59;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Change_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 479);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.label_ssn);
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
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.Label label_ssn;
        private System.Windows.Forms.Button ChangeSalary;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}