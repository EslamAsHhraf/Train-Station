
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
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(261, 279);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(372, 72);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel Ticket";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ticket Serial Number";
            // 
            // ticketSerialNoComboBox
            // 
            this.ticketSerialNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ticketSerialNoComboBox.FormattingEnabled = true;
            this.ticketSerialNoComboBox.Location = new System.Drawing.Point(261, 177);
            this.ticketSerialNoComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.ticketSerialNoComboBox.Name = "ticketSerialNoComboBox";
            this.ticketSerialNoComboBox.Size = new System.Drawing.Size(368, 42);
            this.ticketSerialNoComboBox.TabIndex = 4;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(637, 383);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 59);
            this.Back.TabIndex = 64;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(763, 383);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 63;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CancelTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 455);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketSerialNoComboBox);
            this.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CancelTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelTicket";
            this.Load += new System.EventHandler(this.CancelTicket_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ticketSerialNoComboBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}