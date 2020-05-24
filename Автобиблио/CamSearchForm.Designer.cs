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
            this.pbCamImage = new System.Windows.Forms.PictureBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lbSources = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCamImage
            // 
            this.pbCamImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbCamImage.Location = new System.Drawing.Point(0, 53);
            this.pbCamImage.Name = "pbCamImage";
            this.pbCamImage.Size = new System.Drawing.Size(786, 385);
            this.pbCamImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCamImage.TabIndex = 0;
            this.pbCamImage.TabStop = false;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaption.Location = new System.Drawing.Point(179, 9);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(395, 40);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "Просканируйте книгу";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSources
            // 
            this.lbSources.FormattingEnabled = true;
            this.lbSources.ItemHeight = 16;
            this.lbSources.Location = new System.Drawing.Point(8, 61);
            this.lbSources.Name = "lbSources";
            this.lbSources.Size = new System.Drawing.Size(120, 84);
            this.lbSources.TabIndex = 2;
            this.lbSources.Visible = false;
            // 
            // CamSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 438);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.lbSources);
            this.Controls.Add(this.pbCamImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CamSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сканирование";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CamSearchForm_FormClosing);
            this.Load += new System.EventHandler(this.CamSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCamImage;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.ListBox lbSources;
    }
}