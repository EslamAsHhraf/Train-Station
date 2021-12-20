
namespace TrainStation.Manager_forms
{
    partial class Hire_Emplotee
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
            this.New_Employee = new System.Windows.Forms.Button();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Mname = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BD = new System.Windows.Forms.ComboBox();
            this.BY = new System.Windows.Forms.ComboBox();
            this.BM = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // New_Employee
            // 
            this.New_Employee.Location = new System.Drawing.Point(275, 379);
            this.New_Employee.Name = "New_Employee";
            this.New_Employee.Size = new System.Drawing.Size(171, 47);
            this.New_Employee.TabIndex = 0;
            this.New_Employee.Text = "Insert new employee";
            this.New_Employee.UseVisualStyleBackColor = true;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(125, 72);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(135, 22);
            this.Fname.TabIndex = 1;
            // 
            // Mname
            // 
            this.Mname.Location = new System.Drawing.Point(122, 114);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(138, 22);
            this.Mname.TabIndex = 2;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(123, 163);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(137, 22);
            this.Lname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Middle name";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(122, 39);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(138, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "SSN";
            // 
            // Gender
            // 
            this.Gender.AutoCompleteCustomSource.AddRange(new string[] {
            "Male ",
            "Female"});
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(125, 208);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 24);
            this.Gender.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date of birth";
            // 
            // BD
            // 
            this.BD.DropDownHeight = 100;
            this.BD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BD.FormattingEnabled = true;
            this.BD.IntegralHeight = false;
            this.BD.Location = new System.Drawing.Point(125, 277);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(80, 24);
            this.BD.TabIndex = 12;
            // 
            // BY
            // 
            this.BY.AutoCompleteCustomSource.AddRange(new string[] {
            "Male ",
            "Female"});
            this.BY.DropDownHeight = 100;
            this.BY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BY.FormattingEnabled = true;
            this.BY.IntegralHeight = false;
            this.BY.Location = new System.Drawing.Point(325, 277);
            this.BY.Name = "BY";
            this.BY.Size = new System.Drawing.Size(69, 24);
            this.BY.TabIndex = 13;
            // 
            // BM
            // 
            this.BM.DropDownHeight = 100;
            this.BM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BM.FormattingEnabled = true;
            this.BM.IntegralHeight = false;
            this.BM.Location = new System.Drawing.Point(225, 277);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(70, 24);
            this.BM.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Day ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Year";
            // 
            // Hire_Emplotee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 482);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BM);
            this.Controls.Add(this.BY);
            this.Controls.Add(this.BD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Mname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.New_Employee);
            this.Name = "Hire_Emplotee";
            this.Text = "Hire_Emplotee";
            this.Load += new System.EventHandler(this.Hire_Emplotee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button New_Employee;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BD;
        private System.Windows.Forms.ComboBox BY;
        private System.Windows.Forms.ComboBox BM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}