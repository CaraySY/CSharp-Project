namespace FormComponents
{
    partial class ComBoxForm
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
            this.comboxList = new System.Windows.Forms.CheckedListBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboxList
            // 
            this.comboxList.FormattingEnabled = true;
            this.comboxList.Items.AddRange(new object[] {
            "足球",
            "羽毛球",
            "篮球",
            "游泳",
            "跑步"});
            this.comboxList.Location = new System.Drawing.Point(213, 55);
            this.comboxList.Name = "comboxList";
            this.comboxList.Size = new System.Drawing.Size(327, 144);
            this.comboxList.TabIndex = 0;
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(294, 258);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(219, 44);
            this.showBtn.TabIndex = 1;
            this.showBtn.Text = "打印所选";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // ComBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.comboxList);
            this.Name = "ComBoxForm";
            this.Text = "ComBoxForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox comboxList;
        private System.Windows.Forms.Button showBtn;
    }
}