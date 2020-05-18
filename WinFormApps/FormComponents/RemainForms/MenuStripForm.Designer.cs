namespace FormComponents.RemainForms
{
    partial class MenuStripForm
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
            this.studentMenus = new System.Windows.Forms.MenuStrip();
            this.stageOneFile = new System.Windows.Forms.ToolStripMenuItem();
            this.stageOneSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.stageTwoFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentMenus
            // 
            this.studentMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stageOneFile,
            this.stageOneSetting});
            this.studentMenus.Location = new System.Drawing.Point(0, 0);
            this.studentMenus.Name = "studentMenus";
            this.studentMenus.Size = new System.Drawing.Size(800, 25);
            this.studentMenus.TabIndex = 0;
            this.studentMenus.Text = "menuStrip1";
            // 
            // stageOneFile
            // 
            this.stageOneFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stageTwoFileSave});
            this.stageOneFile.Name = "stageOneFile";
            this.stageOneFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.stageOneFile.Size = new System.Drawing.Size(58, 21);
            this.stageOneFile.Text = "文件(&F)";
            // 
            // stageOneSetting
            // 
            this.stageOneSetting.Name = "stageOneSetting";
            this.stageOneSetting.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stageOneSetting.Size = new System.Drawing.Size(59, 21);
            this.stageOneSetting.Text = "设置(S)";
            // 
            // stageTwoFileSave
            // 
            this.stageTwoFileSave.Name = "stageTwoFileSave";
            this.stageTwoFileSave.Size = new System.Drawing.Size(180, 22);
            this.stageTwoFileSave.Text = "保存";
            // 
            // MenuStripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentMenus);
            this.MainMenuStrip = this.studentMenus;
            this.Name = "MenuStripForm";
            this.Text = "菜单导航条控件";
            this.studentMenus.ResumeLayout(false);
            this.studentMenus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip studentMenus;
        private System.Windows.Forms.ToolStripMenuItem stageOneFile;
        private System.Windows.Forms.ToolStripMenuItem stageOneSetting;
        private System.Windows.Forms.ToolStripMenuItem stageTwoFileSave;
    }
}