namespace FormComponents.DataDisplayForms
{
    partial class DataGirdViewCRUDForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.cbkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGetRowNums = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbkSelect,
            this.code,
            this._name,
            this.sex,
            this.birth,
            this.linkDel});
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvShow.Location = new System.Drawing.Point(0, 0);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 27;
            this.dgvShow.Size = new System.Drawing.Size(803, 334);
            this.dgvShow.TabIndex = 0;
            this.dgvShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellContentClick);
            // 
            // cbkSelect
            // 
            this.cbkSelect.HeaderText = "选择";
            this.cbkSelect.MinimumWidth = 6;
            this.cbkSelect.Name = "cbkSelect";
            this.cbkSelect.Width = 125;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "编号";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.Width = 125;
            // 
            // _name
            // 
            this._name.DataPropertyName = "name";
            this._name.HeaderText = "姓名";
            this._name.MinimumWidth = 6;
            this._name.Name = "_name";
            this._name.Width = 125;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "性别";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.Width = 125;
            // 
            // birth
            // 
            this.birth.DataPropertyName = "birth";
            this.birth.HeaderText = "生日";
            this.birth.MinimumWidth = 6;
            this.birth.Name = "birth";
            this.birth.Width = 125;
            // 
            // linkDel
            // 
            dataGridViewCellStyle3.NullValue = "删除";
            this.linkDel.DefaultCellStyle = dataGridViewCellStyle3;
            this.linkDel.HeaderText = "删除";
            this.linkDel.MinimumWidth = 6;
            this.linkDel.Name = "linkDel";
            this.linkDel.Width = 125;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(39, 371);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 38);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(182, 371);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 38);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnGetRowNums
            // 
            this.btnGetRowNums.Location = new System.Drawing.Point(681, 371);
            this.btnGetRowNums.Name = "btnGetRowNums";
            this.btnGetRowNums.Size = new System.Drawing.Size(95, 38);
            this.btnGetRowNums.TabIndex = 3;
            this.btnGetRowNums.Text = "获取行数据";
            this.btnGetRowNums.UseVisualStyleBackColor = true;
            // 
            // DataGirdViewCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 434);
            this.Controls.Add(this.btnGetRowNums);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dgvShow);
            this.Name = "DataGirdViewCRUDForm";
            this.Text = "使用DataGridViewCURD";
            this.Load += new System.EventHandler(this.DataGirdViewCRUDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnGetRowNums;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbkSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewLinkColumn linkDel;
    }
}