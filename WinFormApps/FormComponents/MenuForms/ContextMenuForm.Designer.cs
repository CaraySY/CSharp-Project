namespace FormComponents.RemainForms
{
    partial class ContextMenuForm
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
            this.cxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miSetColor = new System.Windows.Forms.ToolStripMenuItem();
            this.miColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.miColorGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.miColorDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.cxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cxMenuStrip
            // 
            this.cxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSetColor});
            this.cxMenuStrip.Name = "cxMenuStrip";
            this.cxMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // miSetColor
            // 
            this.miSetColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miColorRed,
            this.miColorGreen,
            this.miColorDefault});
            this.miSetColor.Name = "miSetColor";
            this.miSetColor.Size = new System.Drawing.Size(180, 22);
            this.miSetColor.Text = "设置背景颜色";
            // 
            // miColorRed
            // 
            this.miColorRed.Name = "miColorRed";
            this.miColorRed.Size = new System.Drawing.Size(180, 22);
            this.miColorRed.Text = "红色";
            this.miColorRed.Click += new System.EventHandler(this.miColorRed_Click);
            // 
            // miColorGreen
            // 
            this.miColorGreen.Name = "miColorGreen";
            this.miColorGreen.Size = new System.Drawing.Size(180, 22);
            this.miColorGreen.Text = "绿色";
            this.miColorGreen.Click += new System.EventHandler(this.miColorGreen_Click);
            // 
            // miColorDefault
            // 
            this.miColorDefault.Name = "miColorDefault";
            this.miColorDefault.Size = new System.Drawing.Size(180, 22);
            this.miColorDefault.Text = "默认颜色";
            this.miColorDefault.Click += new System.EventHandler(this.miColorDefault_Click);
            // 
            // ContextMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.cxMenuStrip;
            this.Name = "ContextMenuForm";
            this.Text = "右键菜单";
            this.cxMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem miSetColor;
        private System.Windows.Forms.ToolStripMenuItem miColorRed;
        private System.Windows.Forms.ToolStripMenuItem miColorGreen;
        private System.Windows.Forms.ToolStripMenuItem miColorDefault;
    }
}