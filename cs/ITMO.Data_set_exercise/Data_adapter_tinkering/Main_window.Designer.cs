namespace Data_adapter_tinkering
{
    partial class Main_window
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
            this.main_grid_view = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_add_row = new System.Windows.Forms.Button();
            this.btn_delete_row = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // main_grid_view
            // 
            this.main_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main_grid_view.Location = new System.Drawing.Point(12, 12);
            this.main_grid_view.Name = "main_grid_view";
            this.main_grid_view.RowTemplate.Height = 25;
            this.main_grid_view.Size = new System.Drawing.Size(776, 249);
            this.main_grid_view.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(228, 282);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_add_row
            // 
            this.btn_add_row.Location = new System.Drawing.Point(356, 282);
            this.btn_add_row.Name = "btn_add_row";
            this.btn_add_row.Size = new System.Drawing.Size(75, 23);
            this.btn_add_row.TabIndex = 2;
            this.btn_add_row.Text = "Add row";
            this.btn_add_row.UseVisualStyleBackColor = true;
            this.btn_add_row.Click += new System.EventHandler(this.btn_add_row_Click);
            // 
            // btn_delete_row
            // 
            this.btn_delete_row.Location = new System.Drawing.Point(479, 282);
            this.btn_delete_row.Name = "btn_delete_row";
            this.btn_delete_row.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_row.TabIndex = 3;
            this.btn_delete_row.Text = "Delete row";
            this.btn_delete_row.UseVisualStyleBackColor = true;
            this.btn_delete_row.Click += new System.EventHandler(this.btn_delete_row_Click);
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.btn_delete_row);
            this.Controls.Add(this.btn_add_row);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.main_grid_view);
            this.Name = "Main_window";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Main_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView main_grid_view;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_add_row;
        private System.Windows.Forms.Button btn_delete_row;
    }
}
