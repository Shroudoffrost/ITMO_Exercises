namespace RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.btn_signup = new System.Windows.Forms.Button();
            this.gbox_credentials = new System.Windows.Forms.GroupBox();
            this.tbox_password = new System.Windows.Forms.TextBox();
            this.tbox_login = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.cbox_more = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbox_credentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(131, 225);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(127, 36);
            this.btn_signup.TabIndex = 0;
            this.btn_signup.Text = "Sign up";
            this.btn_signup.UseVisualStyleBackColor = true;
            // 
            // gbox_credentials
            // 
            this.gbox_credentials.Controls.Add(this.tbox_password);
            this.gbox_credentials.Controls.Add(this.tbox_login);
            this.gbox_credentials.Controls.Add(this.label_password);
            this.gbox_credentials.Controls.Add(this.label_login);
            this.gbox_credentials.Location = new System.Drawing.Point(67, 39);
            this.gbox_credentials.Name = "gbox_credentials";
            this.gbox_credentials.Size = new System.Drawing.Size(248, 170);
            this.gbox_credentials.TabIndex = 1;
            this.gbox_credentials.TabStop = false;
            this.gbox_credentials.Text = "Enter your credentials";
            // 
            // tbox_password
            // 
            this.tbox_password.Location = new System.Drawing.Point(40, 116);
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.Size = new System.Drawing.Size(169, 20);
            this.tbox_password.TabIndex = 3;
            this.tbox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_password_KeyPress);
            this.tbox_password.Validating += new System.ComponentModel.CancelEventHandler(this.tbox_password_Validating);
            // 
            // tbox_login
            // 
            this.tbox_login.Location = new System.Drawing.Point(40, 42);
            this.tbox_login.Name = "tbox_login";
            this.tbox_login.Size = new System.Drawing.Size(169, 20);
            this.tbox_login.TabIndex = 2;
            this.tbox_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_login_KeyPress);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(95, 89);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(104, 16);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(33, 13);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "Login";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(67, 13);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(101, 13);
            this.label_info.TabIndex = 2;
            this.label_info.Text = "Sign up to see more";
            // 
            // cbox_more
            // 
            this.cbox_more.AutoSize = true;
            this.cbox_more.Location = new System.Drawing.Point(292, 236);
            this.cbox_more.Name = "cbox_more";
            this.cbox_more.Size = new System.Drawing.Size(50, 17);
            this.cbox_more.TabIndex = 3;
            this.cbox_more.Text = "More";
            this.cbox_more.UseVisualStyleBackColor = true;
            this.cbox_more.CheckedChanged += new System.EventHandler(this.cbox_more_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.gbox_credentials);
            this.Controls.Add(this.cbox_more);
            this.Controls.Add(this.btn_signup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Sign up dialog";
            this.gbox_credentials.ResumeLayout(false);
            this.gbox_credentials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.GroupBox gbox_credentials;
        private System.Windows.Forms.TextBox tbox_password;
        private System.Windows.Forms.TextBox tbox_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.CheckBox cbox_more;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

