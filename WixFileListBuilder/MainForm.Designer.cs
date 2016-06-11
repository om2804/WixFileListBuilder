namespace WixFileListBuilder
{
    partial class MainForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bGenerate = new System.Windows.Forms.Button();
            this.tbMask = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bOpen = new System.Windows.Forms.Button();
            this.lPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(229, 26);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(75, 23);
            this.bGenerate.TabIndex = 0;
            this.bGenerate.Text = "Generate";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // tbMask
            // 
            this.tbMask.Location = new System.Drawing.Point(12, 28);
            this.tbMask.Name = "tbMask";
            this.tbMask.Size = new System.Drawing.Size(211, 21);
            this.tbMask.TabIndex = 1;
            this.tbMask.Text = "*.exe|*.dll";
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.Location = new System.Drawing.Point(15, 108);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(592, 385);
            this.tbResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Files mask";
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(12, 67);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(75, 23);
            this.bOpen.TabIndex = 4;
            this.bOpen.Text = "Open folder";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // lPath
            // 
            this.lPath.AutoSize = true;
            this.lPath.Location = new System.Drawing.Point(105, 72);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(41, 13);
            this.lPath.TabIndex = 5;
            this.lPath.Text = "Path...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 505);
            this.Controls.Add(this.lPath);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbMask);
            this.Controls.Add(this.bGenerate);
            this.Name = "Form1";
            this.Text = "WixFileListBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.TextBox tbMask;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Label lPath;
    }
}

