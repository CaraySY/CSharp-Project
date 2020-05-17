namespace FormComponents
{
    partial class RichTextBoxForm
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
            this.richTB = new System.Windows.Forms.RichTextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnInsertImg = new System.Windows.Forms.Button();
            this.btnStrong = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // richTB
            // 
            this.richTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTB.Location = new System.Drawing.Point(0, 0);
            this.richTB.Name = "richTB";
            this.richTB.Size = new System.Drawing.Size(800, 221);
            this.richTB.TabIndex = 1;
            this.richTB.Text = "";
            this.richTB.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTB_LinkClicked);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(104, 329);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 41);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "加载";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(234, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnInsertImg
            // 
            this.btnInsertImg.Location = new System.Drawing.Point(349, 329);
            this.btnInsertImg.Name = "btnInsertImg";
            this.btnInsertImg.Size = new System.Drawing.Size(105, 41);
            this.btnInsertImg.TabIndex = 4;
            this.btnInsertImg.Text = "插入图片";
            this.btnInsertImg.UseVisualStyleBackColor = true;
            this.btnInsertImg.Click += new System.EventHandler(this.btnInsertImg_Click);
            // 
            // btnStrong
            // 
            this.btnStrong.Location = new System.Drawing.Point(486, 329);
            this.btnStrong.Name = "btnStrong";
            this.btnStrong.Size = new System.Drawing.Size(75, 41);
            this.btnStrong.TabIndex = 5;
            this.btnStrong.Text = "加粗";
            this.btnStrong.UseVisualStyleBackColor = true;
            this.btnStrong.Click += new System.EventHandler(this.btnStrong_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.Location = new System.Drawing.Point(611, 329);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(75, 41);
            this.btnCenter.TabIndex = 6;
            this.btnCenter.Text = "居中";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // RichTextBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnStrong);
            this.Controls.Add(this.btnInsertImg);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.richTB);
            this.Name = "RichTextBoxForm";
            this.Text = "富文本框";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTB;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnInsertImg;
        private System.Windows.Forms.Button btnStrong;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.ImageList imageList1;
    }
}