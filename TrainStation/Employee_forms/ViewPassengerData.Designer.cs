
namespace TrainStation
{
    partial class ViewPassengerData
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
            this.passengerSSNComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewDetialsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // passengerSSNComboBox
            // 
            this.passengerSSNComboBox.FormattingEnabled = true;
            this.passengerSSNComboBox.Location = new System.Drawing.Point(404, 220);
            this.passengerSSNComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.passengerSSNComboBox.Name = "passengerSSNComboBox";
            this.passengerSSNComboBox.Size = new System.Drawing.Size(193, 29);
            this.passengerSSNComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passenger\'s SSN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 336);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(970, 75);
            this.dataGridView1.TabIndex = 2;
            // 
            // viewDetialsBtn
            // 
            this.viewDetialsBtn.Location = new System.Drawing.Point(404, 275);
            this.viewDetialsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewDetialsBtn.Name = "viewDetialsBtn";
            this.viewDetialsBtn.Size = new System.Drawing.Size(194, 30);
            this.viewDetialsBtn.TabIndex = 3;
            this.viewDetialsBtn.Text = "View details";
            this.viewDetialsBtn.UseVisualStyleBackColor = true;
            // 
            // ViewPassengerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 535);
            this.Controls.Add(this.viewDetialsBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passengerSSNComboBox);
            this.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewPassengerData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPassengerData";
            this.Load += new System.EventHandler(this.ViewPassengerData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox passengerSSNComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewDetialsBtn;
    }
}