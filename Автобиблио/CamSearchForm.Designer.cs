namespace Автобиблио
{
    partial class CamSearchForm
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
            this.lblCaption = new System.Windows.Forms.Label();
            this.lbSources = new System.Windows.Forms.ListBox();
            this.pbCamImage = new System.Windows.Forms.PictureBox();
            this.btnAddIssuedBook = new System.Windows.Forms.Button();
            this.pnDates = new System.Windows.Forms.Panel();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.lblDateIssued = new System.Windows.Forms.Label();
            this.dtpDateIssued = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamImage)).BeginInit();
            this.pnDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaption.Location = new System.Drawing.Point(179, 9);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(418, 40);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "Просканируйте QR-код";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSources
            // 
            this.lbSources.FormattingEnabled = true;
            this.lbSources.ItemHeight = 16;
            this.lbSources.Location = new System.Drawing.Point(0, 57);
            this.lbSources.Name = "lbSources";
            this.lbSources.Size = new System.Drawing.Size(120, 84);
            this.lbSources.TabIndex = 2;
            this.lbSources.Visible = false;
            // 
            // pbCamImage
            // 
            this.pbCamImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbCamImage.Location = new System.Drawing.Point(0, 57);
            this.pbCamImage.Name = "pbCamImage";
            this.pbCamImage.Size = new System.Drawing.Size(786, 385);
            this.pbCamImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCamImage.TabIndex = 0;
            this.pbCamImage.TabStop = false;
            // 
            // btnAddIssuedBook
            // 
            this.btnAddIssuedBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddIssuedBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddIssuedBook.Location = new System.Drawing.Point(0, 442);
            this.btnAddIssuedBook.Name = "btnAddIssuedBook";
            this.btnAddIssuedBook.Size = new System.Drawing.Size(786, 43);
            this.btnAddIssuedBook.TabIndex = 3;
            this.btnAddIssuedBook.Text = "Выдать книгу";
            this.btnAddIssuedBook.UseVisualStyleBackColor = true;
            this.btnAddIssuedBook.Visible = false;
            this.btnAddIssuedBook.Click += new System.EventHandler(this.btnAddIssuedBook_Click);
            // 
            // pnDates
            // 
            this.pnDates.Controls.Add(this.dtpDateReturned);
            this.pnDates.Controls.Add(this.lblDateReturned);
            this.pnDates.Controls.Add(this.lblDateIssued);
            this.pnDates.Controls.Add(this.dtpDateIssued);
            this.pnDates.Location = new System.Drawing.Point(186, 231);
            this.pnDates.Name = "pnDates";
            this.pnDates.Size = new System.Drawing.Size(299, 78);
            this.pnDates.TabIndex = 4;
            this.pnDates.Visible = false;
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.CustomFormat = "dddd dd.mm.yyyy";
            this.dtpDateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateReturned.Location = new System.Drawing.Point(194, 49);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(101, 22);
            this.dtpDateReturned.TabIndex = 11;
            this.dtpDateReturned.Value = new System.DateTime(2020, 6, 2, 17, 48, 53, 0);
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateReturned.Location = new System.Drawing.Point(0, 49);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(148, 23);
            this.lblDateReturned.TabIndex = 10;
            this.lblDateReturned.Text = "Дата возврата";
            this.lblDateReturned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateIssued
            // 
            this.lblDateIssued.AutoSize = true;
            this.lblDateIssued.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateIssued.Location = new System.Drawing.Point(0, 3);
            this.lblDateIssued.Name = "lblDateIssued";
            this.lblDateIssued.Size = new System.Drawing.Size(135, 23);
            this.lblDateIssued.TabIndex = 9;
            this.lblDateIssued.Text = "Дата выдачи";
            this.lblDateIssued.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDateIssued
            // 
            this.dtpDateIssued.CustomFormat = "dddd dd.mm.yyyy";
            this.dtpDateIssued.Enabled = false;
            this.dtpDateIssued.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIssued.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDateIssued.Location = new System.Drawing.Point(194, 6);
            this.dtpDateIssued.Name = "dtpDateIssued";
            this.dtpDateIssued.Size = new System.Drawing.Size(101, 22);
            this.dtpDateIssued.TabIndex = 8;
            this.dtpDateIssued.Value = new System.DateTime(2020, 6, 2, 0, 0, 0, 0);
            // 
            // CamSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 485);
            this.ControlBox = false;
            this.Controls.Add(this.pnDates);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.lbSources);
            this.Controls.Add(this.pbCamImage);
            this.Controls.Add(this.btnAddIssuedBook);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CamSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сканирование";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CamSearchForm_FormClosing);
            this.Load += new System.EventHandler(this.CamSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamImage)).EndInit();
            this.pnDates.ResumeLayout(false);
            this.pnDates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.ListBox lbSources;
        private System.Windows.Forms.PictureBox pbCamImage;
        private System.Windows.Forms.Button btnAddIssuedBook;
        private System.Windows.Forms.Panel pnDates;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.Label lblDateIssued;
        private System.Windows.Forms.DateTimePicker dtpDateIssued;
    }
}