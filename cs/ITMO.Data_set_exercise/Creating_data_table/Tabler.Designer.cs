namespace Creating_data_table
{
    partial class Tabler
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
            this.btn_fill_child_table = new System.Windows.Forms.Button();
            this.grid_view_child = new System.Windows.Forms.DataGridView();
            this.btn_fill_parent_table = new System.Windows.Forms.Button();
            this.grid_view_parent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_child)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_parent)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fill_child_table
            // 
            this.btn_fill_child_table.Location = new System.Drawing.Point(26, 16);
            this.btn_fill_child_table.Name = "btn_fill_child_table";
            this.btn_fill_child_table.Size = new System.Drawing.Size(75, 23);
            this.btn_fill_child_table.TabIndex = 0;
            this.btn_fill_child_table.Text = "Fill child table";
            this.btn_fill_child_table.UseVisualStyleBackColor = true;
            this.btn_fill_child_table.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid_view_child
            // 
            this.grid_view_child.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_child.Location = new System.Drawing.Point(28, 56);
            this.grid_view_child.Name = "grid_view_child";
            this.grid_view_child.Size = new System.Drawing.Size(240, 150);
            this.grid_view_child.TabIndex = 1;
            // 
            // btn_fill_parent_table
            // 
            this.btn_fill_parent_table.Location = new System.Drawing.Point(277, 16);
            this.btn_fill_parent_table.Name = "btn_fill_parent_table";
            this.btn_fill_parent_table.Size = new System.Drawing.Size(75, 23);
            this.btn_fill_parent_table.TabIndex = 2;
            this.btn_fill_parent_table.Text = "Fill parent table";
            this.btn_fill_parent_table.UseVisualStyleBackColor = true;
            this.btn_fill_parent_table.Click += new System.EventHandler(this.button2_Click);
            // 
            // grid_view_parent
            // 
            this.grid_view_parent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_parent.Location = new System.Drawing.Point(277, 56);
            this.grid_view_parent.Name = "grid_view_parent";
            this.grid_view_parent.Size = new System.Drawing.Size(240, 150);
            this.grid_view_parent.TabIndex = 3;
            // 
            // Tabler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 235);
            this.Controls.Add(this.grid_view_parent);
            this.Controls.Add(this.btn_fill_parent_table);
            this.Controls.Add(this.grid_view_child);
            this.Controls.Add(this.btn_fill_child_table);
            this.Name = "Tabler";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tabler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_child)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_parent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fill_child_table;
        private System.Windows.Forms.DataGridView grid_view_child;
        private System.Windows.Forms.Button btn_fill_parent_table;
        private System.Windows.Forms.DataGridView grid_view_parent;
    }
}
