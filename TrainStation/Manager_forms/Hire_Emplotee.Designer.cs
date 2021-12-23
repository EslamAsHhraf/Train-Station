
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
            this.Salary = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.House_num = new System.Windows.Forms.NumericUpDown();
            this.Street = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Super_ssn = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.Dno = new System.Windows.Forms.NumericUpDown();
            this.SN_vacc = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.date_vacc = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.House_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Super_ssn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SN_vacc)).BeginInit();
            this.SuspendLayout();
            // 
            // New_Employee
            // 
            this.New_Employee.Location = new System.Drawing.Point(586, 233);
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
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(123, 336);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(138, 22);
            this.Salary.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Salary";
            // 
            // Rate
            // 
            this.Rate.Location = new System.Drawing.Point(122, 378);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(138, 22);
            this.Rate.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Rate";
            // 
            // House_num
            // 
            this.House_num.Location = new System.Drawing.Point(125, 446);
            this.House_num.Name = "House_num";
            this.House_num.Size = new System.Drawing.Size(67, 22);
            this.House_num.TabIndex = 22;
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(225, 445);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(135, 22);
            this.Street.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(385, 445);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 22);
            this.textBox2.TabIndex = 24;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(409, 415);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(31, 17);
            this.City.TabIndex = 27;
            this.City.Text = "City";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(122, 415);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "House Num ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(266, 415);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Street";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 450);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Adress";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 490);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "Super SSN";
            // 
            // Super_ssn
            // 
            this.Super_ssn.Location = new System.Drawing.Point(130, 485);
            this.Super_ssn.Name = "Super_ssn";
            this.Super_ssn.Size = new System.Drawing.Size(138, 22);
            this.Super_ssn.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(479, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = "Department Num";
            // 
            // Dno
            // 
            this.Dno.Location = new System.Drawing.Point(619, 39);
            this.Dno.Name = "Dno";
            this.Dno.Size = new System.Drawing.Size(138, 22);
            this.Dno.TabIndex = 32;
            // 
            // SN_vacc
            // 
            this.SN_vacc.Location = new System.Drawing.Point(619, 73);
            this.SN_vacc.Name = "SN_vacc";
            this.SN_vacc.Size = new System.Drawing.Size(138, 22);
            this.SN_vacc.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(409, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(189, 17);
            this.label18.TabIndex = 33;
            this.label18.Text = "Serial Number of vaccination";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(465, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 17);
            this.label19.TabIndex = 35;
            this.label19.Text = "Date of vaccination";
            // 
            // date_vacc
            // 
            this.date_vacc.Location = new System.Drawing.Point(619, 112);
            this.date_vacc.Name = "date_vacc";
            this.date_vacc.Size = new System.Drawing.Size(200, 22);
            this.date_vacc.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(552, 166);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 17);
            this.label20.TabIndex = 38;
            this.label20.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(619, 163);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(135, 22);
            this.Email.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // Hire_Emplotee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 536);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.date_vacc);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.SN_vacc);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Dno);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Super_ssn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.House_num);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Salary);
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
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.House_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Super_ssn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SN_vacc)).EndInit();
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
        private System.Windows.Forms.NumericUpDown Salary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Rate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown House_num;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown Super_ssn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown Dno;
        private System.Windows.Forms.NumericUpDown SN_vacc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker date_vacc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}