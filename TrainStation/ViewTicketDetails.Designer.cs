
namespace TrainStation
{
    partial class ViewTicketDetails
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
            this.ticketSerialNoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewTicketDetailsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketSerialNoComboBox
            // 
            this.ticketSerialNoComboBox.FormattingEnabled = true;
            this.ticketSerialNoComboBox.Location = new System.Drawing.Point(215, 78);
            this.ticketSerialNoComboBox.Name = "ticketSerialNoComboBox";
            this.ticketSerialNoComboBox.Size = new System.Drawing.Size(186, 24);
            this.ticketSerialNoComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticket Serial Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(579, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // viewTicketDetailsBtn
            // 
            this.viewTicketDetailsBtn.Location = new System.Drawing.Point(215, 126);
            this.viewTicketDetailsBtn.Name = "viewTicketDetailsBtn";
            this.viewTicketDetailsBtn.Size = new System.Drawing.Size(186, 34);
            this.viewTicketDetailsBtn.TabIndex = 3;
            this.viewTicketDetailsBtn.Text = "View Ticket Details";
            this.viewTicketDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // ViewTicketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 367);
            this.Controls.Add(this.viewTicketDetailsBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketSerialNoComboBox);
            this.Name = "ViewTicketDetails";
            this.Text = "ViewTicketDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ticketSerialNoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewTicketDetailsBtn;
    }
}