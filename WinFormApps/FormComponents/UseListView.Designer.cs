namespace FormComponents
{
    partial class UseListView
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
            this.lsViewShow = new System.Windows.Forms.ListView();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnHuge = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.imgListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imgListHuge = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lsViewShow
            // 
            this.lsViewShow.HideSelection = false;
            this.lsViewShow.Location = new System.Drawing.Point(27, 76);
            this.lsViewShow.Name = "lsViewShow";
            this.lsViewShow.Size = new System.Drawing.Size(745, 284);
            this.lsViewShow.TabIndex = 0;
            this.lsViewShow.UseCompatibleStateImageBehavior = false;
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(58, 20);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(75, 41);
            this.btnSmall.TabIndex = 1;
            this.btnSmall.Text = "小图标";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnHuge
            // 
            this.btnHuge.Location = new System.Drawing.Point(207, 20);
            this.btnHuge.Name = "btnHuge";
            this.btnHuge.Size = new System.Drawing.Size(75, 42);
            this.btnHuge.TabIndex = 2;
            this.btnHuge.Text = "大图标";
            this.btnHuge.UseVisualStyleBackColor = true;
            this.btnHuge.Click += new System.EventHandler(this.btnHuge_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(372, 20);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 42);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(519, 20);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 41);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(664, 20);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(75, 42);
            this.btnTitle.TabIndex = 5;
            this.btnTitle.Text = "Tile";
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(372, 401);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(75, 37);
            this.btnGroup.TabIndex = 6;
            this.btnGroup.Text = "GroupBy";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // imgListSmall
            // 
            this.imgListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgListHuge
            // 
            this.imgListHuge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListHuge.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListHuge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UseListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnHuge);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.lsViewShow);
            this.Name = "UseListView";
            this.Text = "UseListView";
            this.Load += new System.EventHandler(this.UseListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsViewShow;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnHuge;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.ImageList imgListSmall;
        private System.Windows.Forms.ImageList imgListHuge;
    }
}