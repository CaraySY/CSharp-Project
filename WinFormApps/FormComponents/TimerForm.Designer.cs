namespace FormComponents
{
    partial class ProgressBarFormrForm
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
            this.formTimer = new System.Windows.Forms.Timer(this.components);
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // formTimer
            // 
            this.formTimer.Enabled = true;
            this.formTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtPicker
            // 
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtPicker.Location = new System.Drawing.Point(271, 56);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(219, 25);
            this.dtPicker.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // tbCount
            // 
            this.tbCount.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCount.Location = new System.Drawing.Point(225, 196);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(338, 38);
            this.tbCount.TabIndex = 1;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.dtPicker);
            this.Name = "TimerForm";
            this.Text = "定时器控件";
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer formTimer;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbCount;
    }
}