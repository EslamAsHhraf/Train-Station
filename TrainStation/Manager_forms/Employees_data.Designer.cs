
namespace TrainStation.Manager_s_forms
{
    partial class Employees__data
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
            this.data = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SSN = new System.Windows.Forms.ComboBox();
            this.label_ssn = new System.Windows.Forms.Label();
            this.Get_phone = new System.Windows.Forms.Button();
            this.SSN_PHONE = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSN_PHONE)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(92, 12);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(956, 395);
            this.data.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(804, 567);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 59);
            this.Back.TabIndex = 60;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(930, 567);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 59;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SSN
            // 
            this.SSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSN.FormattingEnabled = true;
            this.SSN.Location = new System.Drawing.Point(92, 487);
            this.SSN.Margin = new System.Windows.Forms.Padding(4);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(150, 24);
            this.SSN.TabIndex = 62;
            // 
            // label_ssn
            // 
            this.label_ssn.AutoSize = true;
            this.label_ssn.Location = new System.Drawing.Point(88, 452);
            this.label_ssn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ssn.Name = "label_ssn";
            this.label_ssn.Size = new System.Drawing.Size(36, 17);
            this.label_ssn.TabIndex = 61;
            this.label_ssn.Text = "SSN";
            // 
            // Get_phone
            // 
            this.Get_phone.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_phone.Location = new System.Drawing.Point(286, 468);
            this.Get_phone.Margin = new System.Windows.Forms.Padding(4);
            this.Get_phone.Name = "Get_phone";
            this.Get_phone.Size = new System.Drawing.Size(213, 59);
            this.Get_phone.TabIndex = 63;
            this.Get_phone.Text = "Get Phone Number";
            this.Get_phone.UseVisualStyleBackColor = true;
            this.Get_phone.Click += new System.EventHandler(this.Get_phone_Click);
            // 
            // SSN_PHONE
            // 
            this.SSN_PHONE.AllowUserToAddRows = false;
            this.SSN_PHONE.AllowUserToDeleteRows = false;
            this.SSN_PHONE.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.SSN_PHONE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SSN_PHONE.Location = new System.Drawing.Point(506, 452);
            this.SSN_PHONE.Name = "SSN_PHONE";
            this.SSN_PHONE.ReadOnly = true;
            this.SSN_PHONE.RowHeadersWidth = 51;
            this.SSN_PHONE.RowTemplate.Height = 24;
            this.SSN_PHONE.Size = new System.Drawing.Size(215, 186);
            this.SSN_PHONE.TabIndex = 64;
            // 
            // Employees__data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1090, 665);
            this.Controls.Add(this.SSN_PHONE);
            this.Controls.Add(this.Get_phone);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label_ssn);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.data);
            this.Name = "Employees__data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees__data";
            this.Load += new System.EventHandler(this.Employees__data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSN_PHONE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox SSN;
        private System.Windows.Forms.Label label_ssn;
        private System.Windows.Forms.Button Get_phone;
        private System.Windows.Forms.DataGridView SSN_PHONE;
    }
}