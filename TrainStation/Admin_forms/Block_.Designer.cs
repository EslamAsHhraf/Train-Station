
namespace TrainStation.Admin_forms
{
    partial class Block_
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pass_SSN_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BlackList_Reason_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Blockbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passenger SSN";
            // 
            // Pass_SSN_ComboBox
            // 
            this.Pass_SSN_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pass_SSN_ComboBox.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Pass_SSN_ComboBox.FormattingEnabled = true;
            this.Pass_SSN_ComboBox.Location = new System.Drawing.Point(199, 51);
            this.Pass_SSN_ComboBox.Name = "Pass_SSN_ComboBox";
            this.Pass_SSN_ComboBox.Size = new System.Drawing.Size(121, 35);
            this.Pass_SSN_ComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(98, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(116, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 34);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // BlackList_Reason_richTextBox
            // 
            this.BlackList_Reason_richTextBox.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.BlackList_Reason_richTextBox.Location = new System.Drawing.Point(199, 160);
            this.BlackList_Reason_richTextBox.Name = "BlackList_Reason_richTextBox";
            this.BlackList_Reason_richTextBox.Size = new System.Drawing.Size(210, 96);
            this.BlackList_Reason_richTextBox.TabIndex = 6;
            this.BlackList_Reason_richTextBox.Text = "";
            // 
            // Blockbutton
            // 
            this.Blockbutton.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Blockbutton.Location = new System.Drawing.Point(234, 283);
            this.Blockbutton.Name = "Blockbutton";
            this.Blockbutton.Size = new System.Drawing.Size(140, 43);
            this.Blockbutton.TabIndex = 7;
            this.Blockbutton.Text = "Block";
            this.Blockbutton.UseVisualStyleBackColor = true;
            // 
            // Block_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 362);
            this.Controls.Add(this.Blockbutton);
            this.Controls.Add(this.BlackList_Reason_richTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pass_SSN_ComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Block_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Block User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Pass_SSN_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox BlackList_Reason_richTextBox;
        private System.Windows.Forms.Button Blockbutton;
    }
}