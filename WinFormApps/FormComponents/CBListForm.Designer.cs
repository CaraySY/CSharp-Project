namespace FormComponents
{
    partial class CBListForm
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
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDSDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo1
            // 
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Location = new System.Drawing.Point(284, 32);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(121, 23);
            this.cbo1.TabIndex = 0;
            this.cbo1.SelectedIndexChanged += new System.EventHandler(this.cbo1_SelectedIndexChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(157, 116);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(107, 38);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除指定";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(427, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加对象";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDSDel
            // 
            this.btnDSDel.Location = new System.Drawing.Point(315, 217);
            this.btnDSDel.Name = "btnDSDel";
            this.btnDSDel.Size = new System.Drawing.Size(118, 46);
            this.btnDSDel.TabIndex = 3;
            this.btnDSDel.Text = "删除DS绑定";
            this.btnDSDel.UseVisualStyleBackColor = true;
            this.btnDSDel.Click += new System.EventHandler(this.btnDSDel_Click);
            // 
            // CBListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDSDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.cbo1);
            this.Name = "CBListForm";
            this.Text = "CBListForm";
            this.Load += new System.EventHandler(this.CBListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDSDel;
    }
}