
namespace TrainStation.Passenger_forms
{
    partial class Cancel_Ticket
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelTicket_CB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel Ticket";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticket Number";
            // 
            // CancelTicket_CB
            // 
            this.CancelTicket_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CancelTicket_CB.FormattingEnabled = true;
            this.CancelTicket_CB.Location = new System.Drawing.Point(246, 73);
            this.CancelTicket_CB.Name = "CancelTicket_CB";
            this.CancelTicket_CB.Size = new System.Drawing.Size(121, 28);
            this.CancelTicket_CB.TabIndex = 3;
            // 
            // Cancel_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelTicket_CB);
            this.Name = "Cancel_Ticket";
            this.Text = "Cancel_Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CancelTicket_CB;
    }
}