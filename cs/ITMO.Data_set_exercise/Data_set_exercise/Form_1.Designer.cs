namespace Data_set_design
{
    partial class Form_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_get_customers = new System.Windows.Forms.Button();
            this.listbox_customers = new System.Windows.Forms.ListBox();
            this.tb_test = new System.Windows.Forms.TextBox();
            this.btn_delete_odd_rows = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_get_customers
            // 
            this.btn_get_customers.Location = new System.Drawing.Point(21, 18);
            this.btn_get_customers.Name = "btn_get_customers";
            this.btn_get_customers.Size = new System.Drawing.Size(126, 23);
            this.btn_get_customers.TabIndex = 0;
            this.btn_get_customers.Text = "Get customers";
            this.btn_get_customers.UseVisualStyleBackColor = true;
            this.btn_get_customers.Click += new System.EventHandler(this.btn_get_customers_Click);
            // 
            // listbox_customers
            // 
            this.listbox_customers.FormattingEnabled = true;
            this.listbox_customers.ItemHeight = 15;
            this.listbox_customers.Location = new System.Drawing.Point(227, 21);
            this.listbox_customers.Name = "listbox_customers";
            this.listbox_customers.Size = new System.Drawing.Size(187, 259);
            this.listbox_customers.TabIndex = 1;
            // 
            // tb_test
            // 
            this.tb_test.Location = new System.Drawing.Point(55, 88);
            this.tb_test.Name = "tb_test";
            this.tb_test.Size = new System.Drawing.Size(127, 23);
            this.tb_test.TabIndex = 2;
            this.tb_test.Text = "Test texT";
            // 
            // btn_delete_odd_rows
            // 
            this.btn_delete_odd_rows.Location = new System.Drawing.Point(21, 47);
            this.btn_delete_odd_rows.Name = "btn_delete_odd_rows";
            this.btn_delete_odd_rows.Size = new System.Drawing.Size(126, 23);
            this.btn_delete_odd_rows.TabIndex = 3;
            this.btn_delete_odd_rows.Text = "Delete odd rows";
            this.btn_delete_odd_rows.UseVisualStyleBackColor = true;
            // 
            // Form_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(426, 299);
            this.Controls.Add(this.btn_delete_odd_rows);
            this.Controls.Add(this.tb_test);
            this.Controls.Add(this.listbox_customers);
            this.Controls.Add(this.btn_get_customers);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form_1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_get_customers;
        private System.Windows.Forms.ListBox listbox_customers;
        private System.Windows.Forms.TextBox tb_test;
        private System.Windows.Forms.Button btn_delete_odd_rows;
    }
}
