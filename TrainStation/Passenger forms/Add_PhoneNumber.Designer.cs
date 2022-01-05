
namespace TrainStation.Passenger_forms
{
    partial class Add_PhoneNumber
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
            this.label2 = new System.Windows.Forms.Label();
            this.Add_Phone_Num_TB = new System.Windows.Forms.TextBox();
            this.Add_Phone_Number = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(67, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 41);
            this.label2.TabIndex = 12;
            this.label2.Text = "New Phone Number";
            // 
            // Add_Phone_Num_TB
            // 
            this.Add_Phone_Num_TB.BackColor = System.Drawing.SystemColors.Control;
            this.Add_Phone_Num_TB.Location = new System.Drawing.Point(413, 141);
            this.Add_Phone_Num_TB.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Add_Phone_Num_TB.Name = "Add_Phone_Num_TB";
            this.Add_Phone_Num_TB.Size = new System.Drawing.Size(266, 48);
            this.Add_Phone_Num_TB.TabIndex = 11;
            // 
            // Add_Phone_Number
            // 
            this.Add_Phone_Number.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Add_Phone_Number.Location = new System.Drawing.Point(217, 224);
            this.Add_Phone_Number.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Add_Phone_Number.Name = "Add_Phone_Number";
            this.Add_Phone_Number.Size = new System.Drawing.Size(336, 60);
            this.Add_Phone_Number.TabIndex = 13;
            this.Add_Phone_Number.Text = "Add Phone Number";
            this.Add_Phone_Number.UseVisualStyleBackColor = true;
            // 
            // Add_PhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 414);
            this.Controls.Add(this.Add_Phone_Number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_Phone_Num_TB);
            this.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Add_PhoneNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_PhoneNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Add_Phone_Num_TB;
        private System.Windows.Forms.Button Add_Phone_Number;
    }
}