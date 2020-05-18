namespace FormComponents.RemainForms
{
    partial class CreateMenuStripByCodeForm
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
            this.menuStu = new System.Windows.Forms.MenuStrip();
            this.miStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.miStudentAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miClass = new System.Windows.Forms.ToolStripMenuItem();
            this.miClassAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStu
            // 
            this.menuStu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStudent,
            this.miClass,
            this.miExit});
            this.menuStu.Location = new System.Drawing.Point(0, 0);
            this.menuStu.Name = "menuStu";
            this.menuStu.Size = new System.Drawing.Size(800, 25);
            this.menuStu.TabIndex = 0;
            this.menuStu.Text = "学生菜单";
            // 
            // miStudent
            // 
            this.miStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStudentAdd});
            this.miStudent.Name = "miStudent";
            this.miStudent.Size = new System.Drawing.Size(68, 21);
            this.miStudent.Text = "学生管理";
            // 
            // miStudentAdd
            // 
            this.miStudentAdd.Name = "miStudentAdd";
            this.miStudentAdd.Size = new System.Drawing.Size(124, 22);
            this.miStudentAdd.Text = "新增学生";
            this.miStudentAdd.Click += new System.EventHandler(this.miStudentAdd_Click);
            // 
            // miClass
            // 
            this.miClass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miClassAdd});
            this.miClass.Name = "miClass";
            this.miClass.Size = new System.Drawing.Size(68, 21);
            this.miClass.Text = "班级管理";
            // 
            // miClassAdd
            // 
            this.miClassAdd.Name = "miClassAdd";
            this.miClassAdd.Size = new System.Drawing.Size(124, 22);
            this.miClassAdd.Text = "新增班级";
            this.miClassAdd.Click += new System.EventHandler(this.miClassAdd_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(68, 21);
            this.miExit.Text = "退出系统";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // CreateMenuStripByCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStu);
            this.IsMdiContainer = true;
            this.Name = "CreateMenuStripByCodeForm";
            this.Text = "学生成绩管理系统";
            this.Load += new System.EventHandler(this.CreateMenuStripByCodeForm_Load);
            this.MouseHover += new System.EventHandler(this.CreateMenuStripByCodeForm_MouseHover);
            this.menuStu.ResumeLayout(false);
            this.menuStu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStu;
        private System.Windows.Forms.ToolStripMenuItem miStudent;
        private System.Windows.Forms.ToolStripMenuItem miClass;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miStudentAdd;
        private System.Windows.Forms.ToolStripMenuItem miClassAdd;
    }
}