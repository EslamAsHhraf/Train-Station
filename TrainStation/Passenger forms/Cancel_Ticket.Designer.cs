﻿
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
            this.Cancel_Ticket_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelTicket_CB = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cancel_Ticket_Button
            // 
            this.Cancel_Ticket_Button.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.Cancel_Ticket_Button.Location = new System.Drawing.Point(308, 214);
            this.Cancel_Ticket_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel_Ticket_Button.Name = "Cancel_Ticket_Button";
            this.Cancel_Ticket_Button.Size = new System.Drawing.Size(248, 49);
            this.Cancel_Ticket_Button.TabIndex = 5;
            this.Cancel_Ticket_Button.Text = "Cancel Ticket";
            this.Cancel_Ticket_Button.UseVisualStyleBackColor = true;
            this.Cancel_Ticket_Button.Click += new System.EventHandler(this.Cancel_Ticket_Button_Click);
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
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(567, 320);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 59);
            this.Back.TabIndex = 62;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(693, 320);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 61;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Cancel_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 406);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Cancel_Ticket_Button);
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

        private System.Windows.Forms.Button Cancel_Ticket_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CancelTicket_CB;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}