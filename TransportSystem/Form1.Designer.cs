namespace TransportSystem
{
    partial class Form1
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
            this.dtgvDataset = new System.Windows.Forms.DataGridView();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.txtDetail = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDataset
            // 
            this.dtgvDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDataset.Location = new System.Drawing.Point(20, 42);
            this.dtgvDataset.Name = "dtgvDataset";
            this.dtgvDataset.RowTemplate.Height = 24;
            this.dtgvDataset.Size = new System.Drawing.Size(431, 406);
            this.dtgvDataset.TabIndex = 1;
            // 
            // cbType
            // 
            this.cbType.AccessibleName = "cbType";
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(20, 12);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(428, 24);
            this.cbType.TabIndex = 2;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Location = new System.Drawing.Point(466, 416);
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(368, 22);
            this.txtCommandLine.TabIndex = 3;
            this.txtCommandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommandLine_KeyDown);
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(840, 410);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 35);
            this.btRun.TabIndex = 4;
            this.btRun.Text = "RUN";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(457, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(457, 392);
            this.Panel.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(925, 14);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(404, 257);
            this.txtResult.TabIndex = 6;
            this.txtResult.Text = "";
            // 
            // txtDetail
            // 
            this.txtDetail.Enabled = false;
            this.txtDetail.Location = new System.Drawing.Point(926, 284);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(402, 160);
            this.txtDetail.TabIndex = 7;
            this.txtDetail.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 460);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.txtCommandLine);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.dtgvDataset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvDataset;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.RichTextBox txtDetail;
    }
}

