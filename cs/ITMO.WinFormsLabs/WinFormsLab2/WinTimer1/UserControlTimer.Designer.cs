namespace WinTimer1
{
    partial class UserControlTimer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_display = new System.Windows.Forms.Label();
            this.Main_timer = new System.Windows.Forms.Timer(this.components);
            this.btn_dis_arm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_display
            // 
            this.label_display.AutoSize = true;
            this.label_display.Location = new System.Drawing.Point(3, 0);
            this.label_display.Name = "label_display";
            this.label_display.Size = new System.Drawing.Size(0, 13);
            this.label_display.TabIndex = 0;
            this.label_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main_timer
            // 
            this.Main_timer.Enabled = true;
            this.Main_timer.Interval = 10;
            this.Main_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_dis_arm
            // 
            this.btn_dis_arm.BackColor = System.Drawing.Color.Red;
            this.btn_dis_arm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dis_arm.Location = new System.Drawing.Point(33, 25);
            this.btn_dis_arm.Name = "btn_dis_arm";
            this.btn_dis_arm.Size = new System.Drawing.Size(19, 19);
            this.btn_dis_arm.TabIndex = 1;
            this.btn_dis_arm.UseVisualStyleBackColor = false;
            this.btn_dis_arm.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_dis_arm);
            this.Controls.Add(this.label_display);
            this.Name = "UserControlTimer";
            this.Size = new System.Drawing.Size(83, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_display;
        private System.Windows.Forms.Timer Main_timer;
        private System.Windows.Forms.Button btn_dis_arm;
    }
}
