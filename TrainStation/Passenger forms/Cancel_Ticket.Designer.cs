
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
            this.button1.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(308, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel Ticket";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(224, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticket Number";
            // 
            // CancelTicket_CB
            // 
            this.CancelTicket_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CancelTicket_CB.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.CancelTicket_CB.FormattingEnabled = true;
            this.CancelTicket_CB.Location = new System.Drawing.Point(457, 131);
            this.CancelTicket_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelTicket_CB.Name = "CancelTicket_CB";
            this.CancelTicket_CB.Size = new System.Drawing.Size(217, 42);
            this.CancelTicket_CB.TabIndex = 3;
            // 
            // Cancel_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelTicket_CB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cancel_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel_Ticket";
            this.Load += new System.EventHandler(this.Cancel_Ticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CancelTicket_CB;
    }
}