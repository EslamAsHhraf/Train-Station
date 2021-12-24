
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
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.Salary = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(79, 46);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 34;
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(260, 47);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(120, 22);
            this.Salary.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "SSN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 51);
            this.button1.TabIndex = 30;
            this.button1.Text = "Change salary of employee";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Change_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 209);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Name = "Change_Salary";
            this.Text = "Change_Salary";
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.NumericUpDown Salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}