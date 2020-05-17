namespace FormComponents
{
    partial class ProgressBarForm
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
            this.components = new System.ComponentModel.Container();
            this.proBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTxt = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.lbShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // proBar
            // 
            this.proBar.Location = new System.Drawing.Point(193, 141);
            this.proBar.Name = "proBar";
            this.proBar.Size = new System.Drawing.Size(407, 46);
            this.proBar.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTxt
            // 
            this.lbTxt.AutoSize = true;
            this.lbTxt.Font = new System.Drawing.Font("宋体", 16F);
            this.lbTxt.Location = new System.Drawing.Point(171, 56);
            this.lbTxt.Name = "lbTxt";
            this.lbTxt.Size = new System.Drawing.Size(147, 27);
            this.lbTxt.TabIndex = 1;
            this.lbTxt.Text = "最大长度：";
            // 
            // tbContent
            // 
            this.tbContent.Font = new System.Drawing.Font("宋体", 16F);
            this.tbContent.Location = new System.Drawing.Point(324, 53);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(276, 38);
            this.tbContent.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("宋体", 12F);
            this.btnLoad.Location = new System.Drawing.Point(193, 290);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(96, 47);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "加载";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("宋体", 12F);
            this.btnStop.Location = new System.Drawing.Point(349, 290);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(102, 47);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "暂停";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("宋体", 12F);
            this.btnResume.Location = new System.Drawing.Point(510, 290);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(101, 47);
            this.btnResume.TabIndex = 5;
            this.btnResume.Text = "继续";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // lbShow
            // 
            this.lbShow.AutoSize = true;
            this.lbShow.Location = new System.Drawing.Point(617, 157);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(0, 15);
            this.lbShow.TabIndex = 6;
            // 
            // ProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.lbTxt);
            this.Controls.Add(this.proBar);
            this.Name = "ProgressBarForm";
            this.Text = "进度条显示&控制";
            this.Load += new System.EventHandler(this.ProgressBarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar proBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTxt;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label lbShow;
    }
}