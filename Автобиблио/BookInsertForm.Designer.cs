namespace Автобиблио
{
    partial class BookInsertForm
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
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
            this.pnComboBox = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnTextBox = new System.Windows.Forms.Panel();
            this.tbCostBook = new System.Windows.Forms.TextBox();
            this.lbCostBook = new System.Windows.Forms.Label();
            this.tbDateRegistration = new System.Windows.Forms.TextBox();
            this.lbDateRegisration = new System.Windows.Forms.Label();
            this.tbDatePublication = new System.Windows.Forms.TextBox();
            this.lbDatePublication = new System.Windows.Forms.Label();
            this.btnUpdatePublishing = new System.Windows.Forms.Button();
            this.cbPublishing = new System.Windows.Forms.ComboBox();
            this.lbPublishing = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.lbBookTitle = new System.Windows.Forms.Label();
            this.gbManipulationData.SuspendLayout();
            this.pnComboBox.SuspendLayout();
            this.pnTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbManipulationData
            // 
            this.gbManipulationData.Controls.Add(this.pnComboBox);
            this.gbManipulationData.Controls.Add(this.pnTextBox);
            this.gbManipulationData.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbManipulationData.Location = new System.Drawing.Point(0, 0);
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.Size = new System.Drawing.Size(185, 570);
            this.gbManipulationData.TabIndex = 17;
            this.gbManipulationData.TabStop = false;
            this.gbManipulationData.Text = "Манипулирование даннными:";
            // 
            // pnComboBox
            // 
            this.pnComboBox.Controls.Add(this.button2);
            this.pnComboBox.Controls.Add(this.button1);
            this.pnComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnComboBox.Location = new System.Drawing.Point(3, 482);
            this.pnComboBox.Name = "pnComboBox";
            this.pnComboBox.Size = new System.Drawing.Size(179, 85);
            this.pnComboBox.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Enabled = false;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(0, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "Списать книгу";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Enabled = false;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Внести новую книгу";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnTextBox
            // 
            this.pnTextBox.Controls.Add(this.tbCostBook);
            this.pnTextBox.Controls.Add(this.lbCostBook);
            this.pnTextBox.Controls.Add(this.tbDateRegistration);
            this.pnTextBox.Controls.Add(this.lbDateRegisration);
            this.pnTextBox.Controls.Add(this.tbDatePublication);
            this.pnTextBox.Controls.Add(this.lbDatePublication);
            this.pnTextBox.Controls.Add(this.btnUpdatePublishing);
            this.pnTextBox.Controls.Add(this.cbPublishing);
            this.pnTextBox.Controls.Add(this.lbPublishing);
            this.pnTextBox.Controls.Add(this.textBox1);
            this.pnTextBox.Controls.Add(this.label1);
            this.pnTextBox.Controls.Add(this.tbBookTitle);
            this.pnTextBox.Controls.Add(this.lbBookTitle);
            this.pnTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTextBox.Location = new System.Drawing.Point(3, 16);
            this.pnTextBox.Name = "pnTextBox";
            this.pnTextBox.Size = new System.Drawing.Size(179, 226);
            this.pnTextBox.TabIndex = 17;
            // 
            // tbCostBook
            // 
            this.tbCostBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCostBook.Location = new System.Drawing.Point(0, 199);
            this.tbCostBook.Name = "tbCostBook";
            this.tbCostBook.Size = new System.Drawing.Size(179, 20);
            this.tbCostBook.TabIndex = 42;
            // 
            // lbCostBook
            // 
            this.lbCostBook.AutoSize = true;
            this.lbCostBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCostBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCostBook.Location = new System.Drawing.Point(0, 186);
            this.lbCostBook.Name = "lbCostBook";
            this.lbCostBook.Size = new System.Drawing.Size(150, 13);
            this.lbCostBook.TabIndex = 43;
            this.lbCostBook.Text = "Стоимость экземпляра, руб";
            // 
            // tbDateRegistration
            // 
            this.tbDateRegistration.BackColor = System.Drawing.SystemColors.Control;
            this.tbDateRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDateRegistration.Location = new System.Drawing.Point(0, 166);
            this.tbDateRegistration.Name = "tbDateRegistration";
            this.tbDateRegistration.ReadOnly = true;
            this.tbDateRegistration.Size = new System.Drawing.Size(179, 20);
            this.tbDateRegistration.TabIndex = 40;
            // 
            // lbDateRegisration
            // 
            this.lbDateRegisration.AutoSize = true;
            this.lbDateRegisration.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDateRegisration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDateRegisration.Location = new System.Drawing.Point(0, 153);
            this.lbDateRegisration.Name = "lbDateRegisration";
            this.lbDateRegisration.Size = new System.Drawing.Size(132, 13);
            this.lbDateRegisration.TabIndex = 41;
            this.lbDateRegisration.Text = "Дата регистрации книги";
            // 
            // tbDatePublication
            // 
            this.tbDatePublication.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDatePublication.Location = new System.Drawing.Point(0, 133);
            this.tbDatePublication.Name = "tbDatePublication";
            this.tbDatePublication.Size = new System.Drawing.Size(179, 20);
            this.tbDatePublication.TabIndex = 38;
            // 
            // lbDatePublication
            // 
            this.lbDatePublication.AutoSize = true;
            this.lbDatePublication.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDatePublication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDatePublication.Location = new System.Drawing.Point(0, 120);
            this.lbDatePublication.Name = "lbDatePublication";
            this.lbDatePublication.Size = new System.Drawing.Size(70, 13);
            this.lbDatePublication.TabIndex = 39;
            this.lbDatePublication.Text = "Год издания";
            // 
            // btnUpdatePublishing
            // 
            this.btnUpdatePublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdatePublishing.Enabled = false;
            this.btnUpdatePublishing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdatePublishing.Location = new System.Drawing.Point(0, 100);
            this.btnUpdatePublishing.Name = "btnUpdatePublishing";
            this.btnUpdatePublishing.Size = new System.Drawing.Size(179, 20);
            this.btnUpdatePublishing.TabIndex = 18;
            this.btnUpdatePublishing.Text = "Редактировать издательства";
            this.btnUpdatePublishing.UseVisualStyleBackColor = true;
            // 
            // cbPublishing
            // 
            this.cbPublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPublishing.FormattingEnabled = true;
            this.cbPublishing.Location = new System.Drawing.Point(0, 79);
            this.cbPublishing.Name = "cbPublishing";
            this.cbPublishing.Size = new System.Drawing.Size(179, 21);
            this.cbPublishing.TabIndex = 24;
            // 
            // lbPublishing
            // 
            this.lbPublishing.AutoSize = true;
            this.lbPublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPublishing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPublishing.Location = new System.Drawing.Point(0, 66);
            this.lbPublishing.Name = "lbPublishing";
            this.lbPublishing.Size = new System.Drawing.Size(79, 13);
            this.lbPublishing.TabIndex = 25;
            this.lbPublishing.Text = "Издательство";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Автор книги";
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBookTitle.Location = new System.Drawing.Point(0, 13);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(179, 20);
            this.tbBookTitle.TabIndex = 9;
            // 
            // lbBookTitle
            // 
            this.lbBookTitle.AutoSize = true;
            this.lbBookTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBookTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBookTitle.Location = new System.Drawing.Point(0, 0);
            this.lbBookTitle.Name = "lbBookTitle";
            this.lbBookTitle.Size = new System.Drawing.Size(89, 13);
            this.lbBookTitle.TabIndex = 17;
            this.lbBookTitle.Text = "Название книги";
            // 
            // BookInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 570);
            this.Controls.Add(this.gbManipulationData);
            this.Name = "BookInsertForm";
            this.Text = "BookInsertForm";
            this.gbManipulationData.ResumeLayout(false);
            this.pnComboBox.ResumeLayout(false);
            this.pnTextBox.ResumeLayout(false);
            this.pnTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManipulationData;
        private System.Windows.Forms.Panel pnComboBox;
        private System.Windows.Forms.Panel pnTextBox;
        private System.Windows.Forms.TextBox tbBookTitle;
        private System.Windows.Forms.Label lbBookTitle;
        public System.Windows.Forms.Button btnUpdatePublishing;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCostBook;
        private System.Windows.Forms.Label lbCostBook;
        private System.Windows.Forms.TextBox tbDateRegistration;
        private System.Windows.Forms.Label lbDateRegisration;
        private System.Windows.Forms.TextBox tbDatePublication;
        private System.Windows.Forms.Label lbDatePublication;
        private System.Windows.Forms.ComboBox cbPublishing;
        private System.Windows.Forms.Label lbPublishing;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}