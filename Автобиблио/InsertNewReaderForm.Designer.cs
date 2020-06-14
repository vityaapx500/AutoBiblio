namespace Автобиблио
{
    partial class InsertNewReaderForm
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
            this.btnInsertFomular = new System.Windows.Forms.Button();
            this.tbCreationDate = new System.Windows.Forms.TextBox();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.pnComboBox = new System.Windows.Forms.Panel();
            this.lblReader = new System.Windows.Forms.Label();
            this.cbReader = new System.Windows.Forms.ComboBox();
            this.tbHomeAddress = new System.Windows.Forms.TextBox();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.pnComboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertFomular
            // 
            this.btnInsertFomular.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertFomular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsertFomular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInsertFomular.Location = new System.Drawing.Point(0, 0);
            this.btnInsertFomular.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertFomular.Name = "btnInsertFomular";
            this.btnInsertFomular.Size = new System.Drawing.Size(365, 48);
            this.btnInsertFomular.TabIndex = 6;
            this.btnInsertFomular.Text = "Создать новый формуляр";
            this.btnInsertFomular.UseVisualStyleBackColor = true;
            this.btnInsertFomular.Click += new System.EventHandler(this.btnInsertBook_Click);
            // 
            // tbCreationDate
            // 
            this.tbCreationDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCreationDate.Enabled = false;
            this.tbCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCreationDate.Location = new System.Drawing.Point(0, 25);
            this.tbCreationDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbCreationDate.Name = "tbCreationDate";
            this.tbCreationDate.Size = new System.Drawing.Size(365, 30);
            this.tbCreationDate.TabIndex = 1;
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreationDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCreationDate.Location = new System.Drawing.Point(0, 0);
            this.lblCreationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(269, 25);
            this.lblCreationDate.TabIndex = 0;
            this.lblCreationDate.Text = "Дата создания формуляра";
            // 
            // pnComboBox
            // 
            this.pnComboBox.Controls.Add(this.btnInsertFomular);
            this.pnComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnComboBox.Location = new System.Drawing.Point(0, 222);
            this.pnComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.pnComboBox.Name = "pnComboBox";
            this.pnComboBox.Size = new System.Drawing.Size(365, 50);
            this.pnComboBox.TabIndex = 61;
            // 
            // lblReader
            // 
            this.lblReader.AutoSize = true;
            this.lblReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblReader.Location = new System.Drawing.Point(0, 55);
            this.lblReader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReader.Name = "lblReader";
            this.lblReader.Size = new System.Drawing.Size(155, 25);
            this.lblReader.TabIndex = 62;
            this.lblReader.Text = "ФИО читателя";
            // 
            // cbReader
            // 
            this.cbReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbReader.FormattingEnabled = true;
            this.cbReader.Location = new System.Drawing.Point(0, 80);
            this.cbReader.Name = "cbReader";
            this.cbReader.Size = new System.Drawing.Size(365, 33);
            this.cbReader.TabIndex = 72;
            // 
            // tbHomeAddress
            // 
            this.tbHomeAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbHomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHomeAddress.Location = new System.Drawing.Point(0, 193);
            this.tbHomeAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbHomeAddress.Name = "tbHomeAddress";
            this.tbHomeAddress.Size = new System.Drawing.Size(365, 30);
            this.tbHomeAddress.TabIndex = 76;
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHomeAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHomeAddress.Location = new System.Drawing.Point(0, 168);
            this.lblHomeAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(175, 25);
            this.lblHomeAddress.TabIndex = 75;
            this.lblHomeAddress.Text = "Домашний адрес";
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbPhoneNumber.Location = new System.Drawing.Point(0, 138);
            this.mtbPhoneNumber.Mask = "9(999)999-99-99";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.Size = new System.Drawing.Size(365, 30);
            this.mtbPhoneNumber.TabIndex = 74;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhoneNumber.Location = new System.Drawing.Point(0, 113);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(177, 25);
            this.lblPhoneNumber.TabIndex = 73;
            this.lblPhoneNumber.Text = "Номер телефона";
            // 
            // InsertNewReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 272);
            this.Controls.Add(this.tbHomeAddress);
            this.Controls.Add(this.lblHomeAddress);
            this.Controls.Add(this.mtbPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.cbReader);
            this.Controls.Add(this.lblReader);
            this.Controls.Add(this.tbCreationDate);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.pnComboBox);
            this.Name = "InsertNewReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запись нового читателя";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InsertNewReaderForm_Load);
            this.pnComboBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnInsertFomular;
        private System.Windows.Forms.TextBox tbCreationDate;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Panel pnComboBox;
        private System.Windows.Forms.Label lblReader;
        private System.Windows.Forms.ComboBox cbReader;
        private System.Windows.Forms.TextBox tbHomeAddress;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
    }
}