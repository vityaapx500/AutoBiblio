namespace Автобиблио
{
    partial class CreateQRCodeForm
    {
            /// <summary>
            /// Обязательная переменная конструктора.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Освободить все используемые ресурсы.
            /// </summary>
            /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Код, автоматически созданный конструктором форм Windows

            /// <summary>
            /// Требуемый метод для поддержки конструктора — не изменяйте 
            /// содержимое этого метода с помощью редактора кода.
            /// </summary>
            private void InitializeComponent()
            {
            this.pbBookCode = new System.Windows.Forms.PictureBox();
            this.btnSaveCode = new System.Windows.Forms.Button();
            this.tbBook = new System.Windows.Forms.TextBox();
            this.btnCreateCode = new System.Windows.Forms.Button();
            this.lblBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBookCode
            // 
            this.pbBookCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBookCode.Location = new System.Drawing.Point(0, 0);
            this.pbBookCode.Name = "pbBookCode";
            this.pbBookCode.Size = new System.Drawing.Size(350, 350);
            this.pbBookCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookCode.TabIndex = 12;
            this.pbBookCode.TabStop = false;
            // 
            // btnSaveCode
            // 
            this.btnSaveCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveCode.Location = new System.Drawing.Point(0, 433);
            this.btnSaveCode.Name = "btnSaveCode";
            this.btnSaveCode.Size = new System.Drawing.Size(350, 36);
            this.btnSaveCode.TabIndex = 16;
            this.btnSaveCode.Text = "Сохранить QR код";
            this.btnSaveCode.UseVisualStyleBackColor = true;
            this.btnSaveCode.Click += new System.EventHandler(this.btnSaveCode_Click);
            // 
            // tbBook
            // 
            this.tbBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBook.Location = new System.Drawing.Point(0, 375);
            this.tbBook.Name = "tbBook";
            this.tbBook.Size = new System.Drawing.Size(350, 22);
            this.tbBook.TabIndex = 14;
            // 
            // btnCreateCode
            // 
            this.btnCreateCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateCode.Location = new System.Drawing.Point(0, 397);
            this.btnCreateCode.Name = "btnCreateCode";
            this.btnCreateCode.Size = new System.Drawing.Size(350, 36);
            this.btnCreateCode.TabIndex = 15;
            this.btnCreateCode.Text = "Создать QR код";
            this.btnCreateCode.UseVisualStyleBackColor = true;
            this.btnCreateCode.Click += new System.EventHandler(this.btnCreateCode_Click);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBook.Location = new System.Drawing.Point(0, 350);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(156, 25);
            this.lblBook.TabIndex = 13;
            this.lblBook.Text = " Введите текст";
            this.lblBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateQRCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 468);
            this.Controls.Add(this.btnSaveCode);
            this.Controls.Add(this.btnCreateCode);
            this.Controls.Add(this.tbBook);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.pbBookCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateQRCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCode";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CreateQRCodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.PictureBox pbBookCode;
        private System.Windows.Forms.Button btnSaveCode;
        private System.Windows.Forms.TextBox tbBook;
        private System.Windows.Forms.Button btnCreateCode;
        private System.Windows.Forms.Label lblBook;
    }
    }