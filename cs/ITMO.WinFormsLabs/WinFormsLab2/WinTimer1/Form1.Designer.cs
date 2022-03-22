namespace WinTimer1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bomb_display = new WinTimer1.UserControlTimer();
            this.SuspendLayout();
            // 
            // bomb_display
            // 
            this.bomb_display.BackColor = System.Drawing.Color.Black;
            this.bomb_display.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bomb_display.ForeColor = System.Drawing.Color.Red;
            this.bomb_display.Location = new System.Drawing.Point(224, 100);
            this.bomb_display.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bomb_display.Name = "bomb_display";
            this.bomb_display.Size = new System.Drawing.Size(115, 45);
            this.bomb_display.TabIndex = 0;
            this.bomb_display.TimeEnabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 232);
            this.Controls.Add(this.bomb_display);
            this.MaximumSize = new System.Drawing.Size(495, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(495, 271);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer bomb_display;
    }
}

