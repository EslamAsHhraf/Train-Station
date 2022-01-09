
namespace TrainStation.Manager_forms
{
    partial class Passengers_data
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
            this.SSN_PHONE = new System.Windows.Forms.DataGridView();
            this.Get_phone = new System.Windows.Forms.Button();
            this.SSN = new System.Windows.Forms.ComboBox();
            this.label_ssn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSN_PHONE)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(72, 12);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(946, 408);
            this.data.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(795, 560);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 59);
            this.Back.TabIndex = 58;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(921, 560);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(118, 59);
            this.Exit.TabIndex = 57;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SSN_PHONE
            // 
            this.SSN_PHONE.AllowUserToAddRows = false;
            this.SSN_PHONE.AllowUserToDeleteRows = false;
            this.SSN_PHONE.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.SSN_PHONE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SSN_PHONE.Location = new System.Drawing.Point(486, 433);
            this.SSN_PHONE.Name = "SSN_PHONE";
            this.SSN_PHONE.ReadOnly = true;
            this.SSN_PHONE.RowHeadersWidth = 51;
            this.SSN_PHONE.RowTemplate.Height = 24;
            this.SSN_PHONE.Size = new System.Drawing.Size(215, 186);
            this.SSN_PHONE.TabIndex = 68;
            // 
            // Get_phone
            // 
            this.Get_phone.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_phone.Location = new System.Drawing.Point(249, 449);
            this.Get_phone.Margin = new System.Windows.Forms.Padding(4);
            this.Get_phone.Name = "Get_phone";
            this.Get_phone.Size = new System.Drawing.Size(213, 59);
            this.Get_phone.TabIndex = 67;
            this.Get_phone.Text = "Get Phone Number";
            this.Get_phone.UseVisualStyleBackColor = true;
            this.Get_phone.Click += new System.EventHandler(this.Get_phone_Click);
            // 
            // SSN
            // 
            this.SSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSN.FormattingEnabled = true;
            this.SSN.Location = new System.Drawing.Point(72, 468);
            this.SSN.Margin = new System.Windows.Forms.Padding(4);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(150, 24);
            this.SSN.TabIndex = 66;
            // 
            // label_ssn
            // 
            this.label_ssn.AutoSize = true;
            this.label_ssn.Location = new System.Drawing.Point(68, 433);
            this.label_ssn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ssn.Name = "label_ssn";
            this.label_ssn.Size = new System.Drawing.Size(36, 17);
            this.label_ssn.TabIndex = 65;
            this.label_ssn.Text = "SSN";
            // 
            // Passengers_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainStation.Properties.Resources._1419767;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 644);
            this.Controls.Add(this.SSN_PHONE);
            this.Controls.Add(this.Get_phone);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label_ssn);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.data);
            this.Name = "Passengers_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passengers_data";
            this.Load += new System.EventHandler(this.Passengers_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSN_PHONE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView SSN_PHONE;
        private System.Windows.Forms.Button Get_phone;
        private System.Windows.Forms.ComboBox SSN;
        private System.Windows.Forms.Label label_ssn;
    }
}