
namespace TrainStation
{
    partial class Ticket_booking
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
            this.sourceComboBox = new System.Windows.Forms.ComboBox();
            this.destinantionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passengerSSNTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.bookButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourceComboBox
            // 
            this.sourceComboBox.FormattingEnabled = true;
            this.sourceComboBox.Location = new System.Drawing.Point(268, 122);
            this.sourceComboBox.Name = "sourceComboBox";
            this.sourceComboBox.Size = new System.Drawing.Size(151, 29);
            this.sourceComboBox.TabIndex = 0;
            this.sourceComboBox.SelectedIndexChanged += new System.EventHandler(this.sourceComboBox_SelectedIndexChanged);
            // 
            // destinantionComboBox
            // 
            this.destinantionComboBox.FormattingEnabled = true;
            this.destinantionComboBox.Location = new System.Drawing.Point(500, 122);
            this.destinantionComboBox.Name = "destinantionComboBox";
            this.destinantionComboBox.Size = new System.Drawing.Size(151, 29);
            this.destinantionComboBox.TabIndex = 1;
            this.destinantionComboBox.SelectedIndexChanged += new System.EventHandler(this.destinantionComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(268, 341);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(146, 29);
            this.classComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "SSN";
            // 
            // passengerSSNTextBox
            // 
            this.passengerSSNTextBox.Location = new System.Drawing.Point(268, 430);
            this.passengerSSNTextBox.Name = "passengerSSNTextBox";
            this.passengerSSNTextBox.Size = new System.Drawing.Size(231, 29);
            this.passengerSSNTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Day";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.monthComboBox.Location = new System.Drawing.Point(500, 247);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(151, 29);
            this.monthComboBox.TabIndex = 5;
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayComboBox.Location = new System.Drawing.Point(268, 247);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(152, 29);
            this.dayComboBox.TabIndex = 4;
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.SystemColors.Control;
            this.bookButton.Location = new System.Drawing.Point(379, 489);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(183, 45);
            this.bookButton.TabIndex = 6;
            this.bookButton.Text = "Book ticket";
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Class";
            // 
            // Ticket_booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 635);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passengerSSNTextBox);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinantionComboBox);
            this.Controls.Add(this.sourceComboBox);
            this.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Ticket_booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket_booking";
            this.Load += new System.EventHandler(this.Ticket_booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sourceComboBox;
        private System.Windows.Forms.ComboBox destinantionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passengerSSNTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Label label4;
    }
}