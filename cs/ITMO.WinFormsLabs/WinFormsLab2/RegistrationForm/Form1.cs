using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbox_more_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_more.Checked == true)
            {
                this.ClientSize = new Size(380, 340);
                gbox_credentials.Size = new Size(248, 220);
                btn_signup.Location = new Point(131, 275);
                cbox_more.Location = new Point(292,286);
                Label label_email = new Label();
                label_email.Location = new Point(104, 151);
                label_email.Name = "label_email";
                label_email.Size = new Size(35, 13);
                label_email.TabIndex = 4;
                label_email.Text = "E-mail";
                gbox_credentials.Controls.Add(label_email);
                TextBox tbox_email = new TextBox();
                tbox_email.Location = new Point(40, 177);
                tbox_email.Name = "tbox_email";
                tbox_email.Size = new Size(169, 20);
                tbox_email.TabIndex = 5;
                tbox_email.Text = "";
                gbox_credentials.Controls.Add(tbox_email);
            }
            else
            {
                this.ClientSize = new Size(380, 290);
                gbox_credentials.Size = new Size(248, 170);
                btn_signup.Location = new Point(131, 225);
                cbox_more.Location = new Point(292, 236);
                int lcv;
                lcv = gbox_credentials.Controls.Count;// определяется количество элементов
                while (lcv > 4)
                {
                    gbox_credentials.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }

            }

        }

        private void tbox_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digits are not allowed");
            }
            errorProvider1.SetError(tbox_login, "Must be letter");

        }

        private void tbox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Letters are not allowed");
            //}


        }

        private void tbox_password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(tbox_password.Text =="")
            {
                e.Cancel=false;
                                  }
            else
            {
                try
                {
                    double.Parse(tbox_password.Text);
                    e.Cancel = false;
                                        }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Letters are not allowed");
                                                                  }
            }
        }
    }
}
