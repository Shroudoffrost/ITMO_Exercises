namespace WinFormCourseEx2
{
    partial class Form1
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
            this.customControlTimer21 = new WinFormCourseEx2.CustomControlTimer2();
            this.SuspendLayout();
            // 
            // customControlTimer21
            // 
            this.customControlTimer21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.customControlTimer21.Location = new System.Drawing.Point(12, 12);
            this.customControlTimer21.Name = "customControlTimer21";
            this.customControlTimer21.Size = new System.Drawing.Size(119, 51);
            this.customControlTimer21.TabIndex = 0;
            this.customControlTimer21.Text = "customControlTimer21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(144, 76);
            this.Controls.Add(this.customControlTimer21);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(160, 115);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(160, 115);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControlTimer2 customControlTimer21;
    }
}

