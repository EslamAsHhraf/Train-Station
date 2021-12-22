
namespace TrainStation.Passenger_forms
{
    partial class Ticket_Details
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
            this.TicketDetailsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketDetailsGridView
            // 
            this.TicketDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDetailsGridView.Location = new System.Drawing.Point(28, 23);
            this.TicketDetailsGridView.Name = "TicketDetailsGridView";
            this.TicketDetailsGridView.RowHeadersWidth = 62;
            this.TicketDetailsGridView.RowTemplate.Height = 28;
            this.TicketDetailsGridView.Size = new System.Drawing.Size(743, 401);
            this.TicketDetailsGridView.TabIndex = 0;
            // 
            // Ticket_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TicketDetailsGridView);
            this.Name = "Ticket_Details";
            this.Text = "Ticket_Details";
            ((System.ComponentModel.ISupportInitialize)(this.TicketDetailsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TicketDetailsGridView;
    }
}