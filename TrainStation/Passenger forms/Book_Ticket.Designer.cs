﻿
namespace TrainStation.Passenger_forms
{
    partial class Book_Ticket
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
            this.From_TB = new System.Windows.Forms.TextBox();
            this.To_TB = new System.Windows.Forms.TextBox();
            this.From_L = new System.Windows.Forms.Label();
            this.To_L = new System.Windows.Forms.Label();
            this.Departure_L = new System.Windows.Forms.Label();
            this.Departure_Date_Picker = new System.Windows.Forms.DateTimePicker();
            this.View_Trips_Grid = new System.Windows.Forms.DataGridView();
            this.Book_Ticket_Num_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View_Trips_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // From_TB
            // 
            this.From_TB.Location = new System.Drawing.Point(121, 54);
            this.From_TB.Name = "From_TB";
            this.From_TB.Size = new System.Drawing.Size(189, 26);
            this.From_TB.TabIndex = 0;
            // 
            // To_TB
            // 
            this.To_TB.Location = new System.Drawing.Point(506, 54);
            this.To_TB.Name = "To_TB";
            this.To_TB.Size = new System.Drawing.Size(189, 26);
            this.To_TB.TabIndex = 1;
            // 
            // From_L
            // 
            this.From_L.AutoSize = true;
            this.From_L.Location = new System.Drawing.Point(55, 57);
            this.From_L.Name = "From_L";
            this.From_L.Size = new System.Drawing.Size(46, 20);
            this.From_L.TabIndex = 2;
            this.From_L.Text = "From";
            // 
            // To_L
            // 
            this.To_L.AutoSize = true;
            this.To_L.Location = new System.Drawing.Point(458, 57);
            this.To_L.Name = "To_L";
            this.To_L.Size = new System.Drawing.Size(27, 20);
            this.To_L.TabIndex = 3;
            this.To_L.Text = "To";
            // 
            // Departure_L
            // 
            this.Departure_L.AutoSize = true;
            this.Departure_L.Location = new System.Drawing.Point(201, 124);
            this.Departure_L.Name = "Departure_L";
            this.Departure_L.Size = new System.Drawing.Size(120, 20);
            this.Departure_L.TabIndex = 4;
            this.Departure_L.Text = "Departure Date";
            // 
            // Departure_Date_Picker
            // 
            this.Departure_Date_Picker.Location = new System.Drawing.Point(327, 118);
            this.Departure_Date_Picker.Name = "Departure_Date_Picker";
            this.Departure_Date_Picker.Size = new System.Drawing.Size(265, 26);
            this.Departure_Date_Picker.TabIndex = 5;
            // 
            // View_Trips_Grid
            // 
            this.View_Trips_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Trips_Grid.Location = new System.Drawing.Point(21, 168);
            this.View_Trips_Grid.Name = "View_Trips_Grid";
            this.View_Trips_Grid.RowHeadersWidth = 62;
            this.View_Trips_Grid.RowTemplate.Height = 28;
            this.View_Trips_Grid.Size = new System.Drawing.Size(750, 197);
            this.View_Trips_Grid.TabIndex = 6;
            // 
            // Book_Ticket_Num_TB
            // 
            this.Book_Ticket_Num_TB.Location = new System.Drawing.Point(144, 399);
            this.Book_Ticket_Num_TB.Name = "Book_Ticket_Num_TB";
            this.Book_Ticket_Num_TB.Size = new System.Drawing.Size(189, 26);
            this.Book_Ticket_Num_TB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ticket Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Book Ticket";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Book_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Book_Ticket_Num_TB);
            this.Controls.Add(this.View_Trips_Grid);
            this.Controls.Add(this.Departure_Date_Picker);
            this.Controls.Add(this.Departure_L);
            this.Controls.Add(this.To_L);
            this.Controls.Add(this.From_L);
            this.Controls.Add(this.To_TB);
            this.Controls.Add(this.From_TB);
            this.Name = "Book_Ticket";
            this.Text = "Book_Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.View_Trips_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox From_TB;
        private System.Windows.Forms.TextBox To_TB;
        private System.Windows.Forms.Label From_L;
        private System.Windows.Forms.Label To_L;
        private System.Windows.Forms.Label Departure_L;
        private System.Windows.Forms.DateTimePicker Departure_Date_Picker;
        private System.Windows.Forms.DataGridView View_Trips_Grid;
        private System.Windows.Forms.TextBox Book_Ticket_Num_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}