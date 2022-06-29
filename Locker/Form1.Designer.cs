namespace Locker
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.file_Path = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.file_Browser = new System.Windows.Forms.Button();
            this.share_read = new System.Windows.Forms.Button();
            this.share_write = new System.Windows.Forms.Button();
            this.Lock = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Share_rw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // file_Path
            // 
            this.file_Path.AutoSize = true;
            this.file_Path.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.file_Path.Location = new System.Drawing.Point(66, 49);
            this.file_Path.Name = "file_Path";
            this.file_Path.Size = new System.Drawing.Size(52, 14);
            this.file_Path.TabIndex = 0;
            this.file_Path.Text = "文件：";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(113, 46);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(238, 21);
            this.textBox.TabIndex = 1;
            // 
            // file_Browser
            // 
            this.file_Browser.Location = new System.Drawing.Point(358, 43);
            this.file_Browser.Name = "file_Browser";
            this.file_Browser.Size = new System.Drawing.Size(75, 23);
            this.file_Browser.TabIndex = 2;
            this.file_Browser.Text = "浏览...";
            this.file_Browser.UseVisualStyleBackColor = true;
            this.file_Browser.Click += new System.EventHandler(this.file_Browser_Click);
            // 
            // share_read
            // 
            this.share_read.Location = new System.Drawing.Point(47, 105);
            this.share_read.Name = "share_read";
            this.share_read.Size = new System.Drawing.Size(75, 23);
            this.share_read.TabIndex = 3;
            this.share_read.Text = "Share_Read";
            this.share_read.UseVisualStyleBackColor = true;
            this.share_read.Click += new System.EventHandler(this.share_read_Click);
            // 
            // share_write
            // 
            this.share_write.Location = new System.Drawing.Point(139, 105);
            this.share_write.Name = "share_write";
            this.share_write.Size = new System.Drawing.Size(80, 23);
            this.share_write.TabIndex = 4;
            this.share_write.Text = "Share_Write";
            this.share_write.UseVisualStyleBackColor = true;
            this.share_write.Click += new System.EventHandler(this.share_write_Click);
            // 
            // Lock
            // 
            this.Lock.Location = new System.Drawing.Point(358, 105);
            this.Lock.Name = "Lock";
            this.Lock.Size = new System.Drawing.Size(75, 23);
            this.Lock.TabIndex = 5;
            this.Lock.Text = "Lock";
            this.Lock.UseVisualStyleBackColor = true;
            this.Lock.Click += new System.EventHandler(this.Lock_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Share_rw
            // 
            this.Share_rw.Location = new System.Drawing.Point(242, 105);
            this.Share_rw.Name = "Share_rw";
            this.Share_rw.Size = new System.Drawing.Size(97, 23);
            this.Share_rw.TabIndex = 6;
            this.Share_rw.Text = "Share_ReadWrite";
            this.Share_rw.UseVisualStyleBackColor = true;
            this.Share_rw.Click += new System.EventHandler(this.Share_rw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 180);
            this.Controls.Add(this.Share_rw);
            this.Controls.Add(this.Lock);
            this.Controls.Add(this.share_write);
            this.Controls.Add(this.share_read);
            this.Controls.Add(this.file_Browser);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.file_Path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label file_Path;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button file_Browser;
        private System.Windows.Forms.Button share_read;
        private System.Windows.Forms.Button share_write;
        private System.Windows.Forms.Button Lock;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Share_rw;
    }
}

