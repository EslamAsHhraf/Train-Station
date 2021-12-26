
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(566, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Book Ticket";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(244, 335);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 42);
            this.comboBox1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(312, 54);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "View Available Trips";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Book_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 452);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.View_Trips_Grid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Book_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.View_Trips_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView View_Trips_Grid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}