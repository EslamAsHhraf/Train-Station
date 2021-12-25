
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
            this.passengerSSNComboBox.Location = new System.Drawing.Point(303, 68);
            this.passengerSSNComboBox.Name = "passengerSSNComboBox";
            this.passengerSSNComboBox.Size = new System.Drawing.Size(155, 24);
            this.passengerSSNComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passenger\'s SSN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 57);
            this.dataGridView1.TabIndex = 2;
            // 
            // viewDetialsBtn
            // 
            this.viewDetialsBtn.Location = new System.Drawing.Point(303, 110);
            this.viewDetialsBtn.Name = "viewDetialsBtn";
            this.viewDetialsBtn.Size = new System.Drawing.Size(155, 23);
            this.viewDetialsBtn.TabIndex = 3;
            this.viewDetialsBtn.Text = "View details";
            this.viewDetialsBtn.UseVisualStyleBackColor = true;
            // 
            // ViewPassengerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 243);
            this.Controls.Add(this.viewDetialsBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passengerSSNComboBox);
            this.Name = "ViewPassengerData";
            this.Text = "ViewPassengerData";
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