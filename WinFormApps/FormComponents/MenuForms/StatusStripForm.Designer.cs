namespace FormComponents.RemainForms
{
    partial class StatusStripForm
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
            this.statusStripShow = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripShow
            // 
            this.statusStripShow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStripShow.Location = new System.Drawing.Point(0, 424);
            this.statusStripShow.Name = "statusStripShow";
            this.statusStripShow.Size = new System.Drawing.Size(800, 26);
            this.statusStripShow.TabIndex = 0;
            this.statusStripShow.Text = "状态栏";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 18);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 18);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 20);
            this.toolStripStatusLabel1.Text = "say yes";
            // 
            // StatusStripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStripShow);
            this.Name = "StatusStripForm";
            this.Text = "StatusStripForm";
            this.Load += new System.EventHandler(this.StatusStripForm_Load);
            this.statusStripShow.ResumeLayout(false);
            this.statusStripShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripShow;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}