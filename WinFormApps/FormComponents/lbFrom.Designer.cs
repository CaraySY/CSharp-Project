namespace FormComponents
{
    partial class lbForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.DelteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 35;
            this.listBox1.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Pink",
            "Yello",
            "Green"});
            this.listBox1.Location = new System.Drawing.Point(160, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(461, 214);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Alert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "显示一个UserInfo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(333, 335);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(79, 33);
            this.btnMore.TabIndex = 3;
            this.btnMore.Text = "选择多项";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(333, 392);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(79, 27);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "添加新的";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // DelteBtn
            // 
            this.DelteBtn.Location = new System.Drawing.Point(668, 359);
            this.DelteBtn.Name = "DelteBtn";
            this.DelteBtn.Size = new System.Drawing.Size(78, 37);
            this.DelteBtn.TabIndex = 5;
            this.DelteBtn.Text = "删除一个";
            this.DelteBtn.UseVisualStyleBackColor = true;
            this.DelteBtn.Click += new System.EventHandler(this.DelteBtn_Click);
            // 
            // lbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DelteBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "lbForm";
            this.Text = "ListBox介绍";
            this.Load += new System.EventHandler(this.lbForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button DelteBtn;
    }
}

