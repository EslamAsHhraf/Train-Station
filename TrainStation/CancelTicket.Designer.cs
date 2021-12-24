
namespace TrainStation
{
    partial class CancelTicket
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketSerialNoComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(60, 155);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(186, 34);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel Ticket";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ticket Serial Number";
            // 
            // ticketSerialNoComboBox
            // 
            this.ticketSerialNoComboBox.FormattingEnabled = true;
            this.ticketSerialNoComboBox.Location = new System.Drawing.Point(60, 107);
            this.ticketSerialNoComboBox.Name = "ticketSerialNoComboBox";
            this.ticketSerialNoComboBox.Size = new System.Drawing.Size(186, 24);
            this.ticketSerialNoComboBox.TabIndex = 4;
            // 
            // CancelTicketBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 242);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketSerialNoComboBox);
            this.Name = "CancelTicketBtn";
            this.Text = "CancelTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ticketSerialNoComboBox;
    }
}