
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
            this.TicketDetailsGridView.AllowUserToAddRows = false;
            this.TicketDetailsGridView.AllowUserToDeleteRows = false;
            this.TicketDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDetailsGridView.Location = new System.Drawing.Point(119, 109);
            this.TicketDetailsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TicketDetailsGridView.Name = "TicketDetailsGridView";
            this.TicketDetailsGridView.ReadOnly = true;
            this.TicketDetailsGridView.RowHeadersWidth = 62;
            this.TicketDetailsGridView.RowTemplate.Height = 28;
            this.TicketDetailsGridView.Size = new System.Drawing.Size(771, 406);
            this.TicketDetailsGridView.TabIndex = 0;
            // 
            // Ticket_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 592);
            this.Controls.Add(this.TicketDetailsGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ticket_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket_Details";
            this.Load += new System.EventHandler(this.Ticket_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketDetailsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TicketDetailsGridView;
    }
}