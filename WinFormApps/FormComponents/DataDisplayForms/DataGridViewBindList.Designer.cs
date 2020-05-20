namespace FormComponents.DataDisplayForms
{
    partial class DataGridViewBindList
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
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.btnGetObj = new System.Windows.Forms.Button();
            this.tbGetNum = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this._Name,
            this.Sex,
            this.Birth});
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShow.Location = new System.Drawing.Point(0, 170);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.Size = new System.Drawing.Size(800, 280);
            this.dgvShow.TabIndex = 0;
            // 
            // btnGetObj
            // 
            this.btnGetObj.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetObj.Location = new System.Drawing.Point(55, 53);
            this.btnGetObj.Name = "btnGetObj";
            this.btnGetObj.Size = new System.Drawing.Size(97, 44);
            this.btnGetObj.TabIndex = 1;
            this.btnGetObj.Text = "获取对象";
            this.btnGetObj.UseVisualStyleBackColor = true;
            this.btnGetObj.Click += new System.EventHandler(this.btnGetObj_Click);
            // 
            // tbGetNum
            // 
            this.tbGetNum.Location = new System.Drawing.Point(192, 66);
            this.tbGetNum.Name = "tbGetNum";
            this.tbGetNum.Size = new System.Drawing.Size(169, 21);
            this.tbGetNum.TabIndex = 2;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "code";
            this.Code.HeaderText = "编号";
            this.Code.Name = "Code";
            // 
            // _Name
            // 
            this._Name.DataPropertyName = "name";
            this._Name.HeaderText = "姓名";
            this._Name.Name = "_Name";
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "sex";
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            // 
            // Birth
            // 
            this.Birth.DataPropertyName = "birth";
            this.Birth.HeaderText = "生日";
            this.Birth.Name = "Birth";
            // 
            // DataGridViewBindList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbGetNum);
            this.Controls.Add(this.btnGetObj);
            this.Controls.Add(this.dgvShow);
            this.Name = "DataGridViewBindList";
            this.Text = "DataGridView绑定List集合";
            this.Load += new System.EventHandler(this.DataGridViewBindList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnGetObj;
        private System.Windows.Forms.TextBox tbGetNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
    }
}