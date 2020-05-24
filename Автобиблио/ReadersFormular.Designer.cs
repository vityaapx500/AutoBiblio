namespace Автобиблио
{
    partial class ReadersFormular
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblDateCreation = new System.Windows.Forms.Label();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvIssuesBooks = new System.Windows.Forms.DataGridView();
            this.btnGive = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuesBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 169);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(151, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(384, 48);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Формуляр читателя";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.Location = new System.Drawing.Point(28, 50);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(48, 35);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "№";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateCreation
            // 
            this.lblDateCreation.AutoSize = true;
            this.lblDateCreation.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateCreation.Location = new System.Drawing.Point(309, 57);
            this.lblDateCreation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateCreation.Name = "lblDateCreation";
            this.lblDateCreation.Size = new System.Drawing.Size(198, 31);
            this.lblDateCreation.TabIndex = 3;
            this.lblDateCreation.Text = "Дата создания: ";
            this.lblDateCreation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTitle
            // 
            this.pnTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTitle.Controls.Add(this.label1);
            this.pnTitle.Controls.Add(this.label2);
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Controls.Add(this.lblDateCreation);
            this.pnTitle.Controls.Add(this.lblNum);
            this.pnTitle.Location = new System.Drawing.Point(208, 15);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(687, 169);
            this.pnTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Домашний адрес: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер телефона: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvIssuesBooks
            // 
            this.dgvIssuesBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuesBooks.Location = new System.Drawing.Point(16, 192);
            this.dgvIssuesBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvIssuesBooks.Name = "dgvIssuesBooks";
            this.dgvIssuesBooks.Size = new System.Drawing.Size(880, 299);
            this.dgvIssuesBooks.TabIndex = 5;
            // 
            // btnGive
            // 
            this.btnGive.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGive.Enabled = false;
            this.btnGive.Location = new System.Drawing.Point(0, 0);
            this.btnGive.Name = "btnGive";
            this.btnGive.Size = new System.Drawing.Size(451, 40);
            this.btnGive.TabIndex = 6;
            this.btnGive.Text = "Выдать книгу";
            this.btnGive.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnGive);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 40);
            this.panel1.TabIndex = 7;
            // 
            // btnReturn
            // 
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(449, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(463, 40);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Вернуть книгу";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // ReadersFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvIssuesBooks);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ReadersFormular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формуляр читателя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuesBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblDateCreation;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIssuesBooks;
        private System.Windows.Forms.Button btnGive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
    }
}