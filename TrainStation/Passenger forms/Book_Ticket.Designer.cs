
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
            this.View_Trips_Grid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Book_Ticket2 = new System.Windows.Forms.Button();
            this.Trip_Code_CB = new System.Windows.Forms.ComboBox();
            this.Class_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View_Trips_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // View_Trips_Grid
            // 
            this.View_Trips_Grid.AllowUserToAddRows = false;
            this.View_Trips_Grid.AllowUserToDeleteRows = false;
            this.View_Trips_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Trips_Grid.Location = new System.Drawing.Point(71, 115);
            this.View_Trips_Grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.View_Trips_Grid.Name = "View_Trips_Grid";
            this.View_Trips_Grid.ReadOnly = true;
            this.View_Trips_Grid.RowHeadersWidth = 62;
            this.View_Trips_Grid.RowTemplate.Height = 28;
            this.View_Trips_Grid.Size = new System.Drawing.Size(690, 207);
            this.View_Trips_Grid.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(92, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trip Code";
            // 
            // Book_Ticket2
            // 
            this.Book_Ticket2.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.Book_Ticket2.Location = new System.Drawing.Point(566, 335);
            this.Book_Ticket2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Book_Ticket2.Name = "Book_Ticket2";
            this.Book_Ticket2.Size = new System.Drawing.Size(195, 42);
            this.Book_Ticket2.TabIndex = 9;
            this.Book_Ticket2.Text = "Book Ticket";
            this.Book_Ticket2.UseVisualStyleBackColor = true;
            this.Book_Ticket2.Click += new System.EventHandler(this.Book_Ticket2_Click);
            // 
            // Trip_Code_CB
            // 
            this.Trip_Code_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Trip_Code_CB.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Trip_Code_CB.FormattingEnabled = true;
            this.Trip_Code_CB.Location = new System.Drawing.Point(244, 335);
            this.Trip_Code_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Trip_Code_CB.Name = "Trip_Code_CB";
            this.Trip_Code_CB.Size = new System.Drawing.Size(163, 42);
            this.Trip_Code_CB.TabIndex = 10;
            // 
            // Class_CB
            // 
            this.Class_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class_CB.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Class_CB.FormattingEnabled = true;
            this.Class_CB.Items.AddRange(new object[] {
            "G",
            "V"});
            this.Class_CB.Location = new System.Drawing.Point(244, 390);
            this.Class_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Class_CB.Name = "Class_CB";
            this.Class_CB.Size = new System.Drawing.Size(163, 42);
            this.Class_CB.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(151, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Class";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(658, 431);
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
            this.Exit.Location = new System.Drawing.Point(784, 431);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 59;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Book_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 520);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Class_CB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Trip_Code_CB);
            this.Controls.Add(this.Book_Ticket2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.View_Trips_Grid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Book_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Ticket";
            this.Load += new System.EventHandler(this.Book_Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_Trips_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView View_Trips_Grid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Book_Ticket2;
        private System.Windows.Forms.ComboBox Trip_Code_CB;
        private System.Windows.Forms.ComboBox Class_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}