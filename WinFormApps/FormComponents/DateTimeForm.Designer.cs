namespace FormComponents
{
    partial class DateTimeForm
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
        /// 的的的
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //的的
            /*的的*/
            this.timer = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.timer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timer.Location = new System.Drawing.Point(265, 53);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(256, 25);
            this.timer.TabIndex = 0;
            // 
            // DateTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timer);
            this.Name = "DateTimeForm";
            this.Text = "DateTimeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timer;
    }
}