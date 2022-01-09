
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
            this.label3 = new System.Windows.Forms.Label();
            this.bookButton = new System.Windows.Forms.Button();
            this.Class_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Trip_Code_CB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.View_Trips_Grid = new System.Windows.Forms.DataGridView();
            this.SSN_CB = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View_Trips_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(200, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "SSN";
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
            // Class_CB
            // 
            this.Class_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class_CB.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Class_CB.FormattingEnabled = true;
            this.Class_CB.Items.AddRange(new object[] {
            "VIP",
            "General"});
            this.Class_CB.Location = new System.Drawing.Point(282, 351);
            this.Class_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Class_CB.Name = "Class_CB";
            this.Class_CB.Size = new System.Drawing.Size(163, 42);
            this.Class_CB.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(189, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Class";
            // 
            // Trip_Code_CB
            // 
            this.Trip_Code_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Trip_Code_CB.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Trip_Code_CB.FormattingEnabled = true;
            this.Trip_Code_CB.Location = new System.Drawing.Point(282, 296);
            this.Trip_Code_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Trip_Code_CB.Name = "Trip_Code_CB";
            this.Trip_Code_CB.Size = new System.Drawing.Size(163, 42);
            this.Trip_Code_CB.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(130, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 34);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trip Code";
            // 
            // View_Trips_Grid
            // 
            this.View_Trips_Grid.AllowUserToAddRows = false;
            this.View_Trips_Grid.AllowUserToDeleteRows = false;
            this.View_Trips_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Trips_Grid.Location = new System.Drawing.Point(120, 62);
            this.View_Trips_Grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.View_Trips_Grid.Name = "View_Trips_Grid";
            this.View_Trips_Grid.ReadOnly = true;
            this.View_Trips_Grid.RowHeadersWidth = 62;
            this.View_Trips_Grid.RowTemplate.Height = 28;
            this.View_Trips_Grid.Size = new System.Drawing.Size(690, 207);
            this.View_Trips_Grid.TabIndex = 16;
            // 
            // SSN_CB
            // 
            this.SSN_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSN_CB.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.SSN_CB.FormattingEnabled = true;
            this.SSN_CB.Location = new System.Drawing.Point(282, 404);
            this.SSN_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SSN_CB.Name = "SSN_CB";
            this.SSN_CB.Size = new System.Drawing.Size(163, 42);
            this.SSN_CB.TabIndex = 23;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(668, 550);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 59);
            this.Back.TabIndex = 64;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(794, 550);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 63;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Ticket_booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 635);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SSN_CB);
            this.Controls.Add(this.Class_CB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Trip_Code_CB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.View_Trips_Grid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookButton);
            this.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Ticket_booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket_booking";
            this.Load += new System.EventHandler(this.Ticket_booking_load);
            ((System.ComponentModel.ISupportInitialize)(this.View_Trips_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.ComboBox Class_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Trip_Code_CB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView View_Trips_Grid;
        private System.Windows.Forms.ComboBox SSN_CB;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}