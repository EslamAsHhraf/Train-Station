
namespace TrainStation.Admin_forms
{
    partial class Change_Deb
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.DNum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(406, 47);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 33;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(124, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 32;
            // 
            // DNum
            // 
            this.DNum.AutoSize = true;
            this.DNum.Location = new System.Drawing.Point(251, 53);
            this.DNum.Name = "DNum";
            this.DNum.Size = new System.Drawing.Size(134, 17);
            this.DNum.TabIndex = 31;
            this.DNum.Text = "Department number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "SSN";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 51);
            this.button3.TabIndex = 29;
            this.button3.Text = "Change Departrment of employee";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Change_Deb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 230);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.DNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Name = "Change_Deb";
            this.Text = "Change_Deb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label DNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
    }
}