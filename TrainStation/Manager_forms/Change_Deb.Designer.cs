
namespace TrainStation.Admin_forms
{
    partial class Change_Deb
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
            this.Department_num = new System.Windows.Forms.ComboBox();
            this.SSN = new System.Windows.Forms.ComboBox();
            this.DNum = new System.Windows.Forms.Label();
            this.label_ssn = new System.Windows.Forms.Label();
            this.Change_department = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Department_num
            // 
            this.Department_num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Department_num.FormattingEnabled = true;
            this.Department_num.Location = new System.Drawing.Point(474, 155);
            this.Department_num.Margin = new System.Windows.Forms.Padding(4);
            this.Department_num.Name = "Department_num";
            this.Department_num.Size = new System.Drawing.Size(150, 29);
            this.Department_num.TabIndex = 33;
            // 
            // SSN
            // 
            this.SSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSN.FormattingEnabled = true;
            this.SSN.Location = new System.Drawing.Point(194, 155);
            this.SSN.Margin = new System.Windows.Forms.Padding(4);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(150, 29);
            this.SSN.TabIndex = 32;
            // 
            // DNum
            // 
            this.DNum.AutoSize = true;
            this.DNum.Location = new System.Drawing.Point(470, 120);
            this.DNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DNum.Name = "DNum";
            this.DNum.Size = new System.Drawing.Size(174, 21);
            this.DNum.TabIndex = 31;
            this.DNum.Text = "Department number";
            // 
            // label_ssn
            // 
            this.label_ssn.AutoSize = true;
            this.label_ssn.Location = new System.Drawing.Point(190, 120);
            this.label_ssn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ssn.Name = "label_ssn";
            this.label_ssn.Size = new System.Drawing.Size(43, 21);
            this.label_ssn.TabIndex = 30;
            this.label_ssn.Text = "SSN";
            // 
            // Change_department
            // 
            this.Change_department.Location = new System.Drawing.Point(237, 260);
            this.Change_department.Margin = new System.Windows.Forms.Padding(4);
            this.Change_department.Name = "Change_department";
            this.Change_department.Size = new System.Drawing.Size(350, 67);
            this.Change_department.TabIndex = 29;
            this.Change_department.Text = "Change Departrment of employee";
            this.Change_department.UseVisualStyleBackColor = true;
            this.Change_department.Click += new System.EventHandler(this.Change_department_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(540, 370);
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
            this.Exit.Location = new System.Drawing.Point(666, 370);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 59;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Change_Deb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 455);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Department_num);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.DNum);
            this.Controls.Add(this.label_ssn);
            this.Controls.Add(this.Change_department);
            this.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Change_Deb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_Deb";
            this.Load += new System.EventHandler(this.Change_Deb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Department_num;
        private System.Windows.Forms.ComboBox SSN;
        private System.Windows.Forms.Label DNum;
        private System.Windows.Forms.Label label_ssn;
        private System.Windows.Forms.Button Change_department;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}