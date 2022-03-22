namespace WinFormCourseEx6
{
    partial class main_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_window));
            this.tab_view = new System.Windows.Forms.TabControl();
            this.tab_books = new System.Windows.Forms.TabPage();
            this.nuc_book_use_period = new System.Windows.Forms.NumericUpDown();
            this.nuc_book_inv_num = new System.Windows.Forms.NumericUpDown();
            this.nuc_book_year = new System.Windows.Forms.NumericUpDown();
            this.nuc_book_num_of_pages = new System.Windows.Forms.NumericUpDown();
            this.tbox_book_publisher = new System.Windows.Forms.TextBox();
            this.tbox_book_title = new System.Windows.Forms.TextBox();
            this.tbox_book_author = new System.Windows.Forms.TextBox();
            this.label_book_use_period = new System.Windows.Forms.Label();
            this.label_book_inv_num = new System.Windows.Forms.Label();
            this.label_book_year = new System.Windows.Forms.Label();
            this.label_book_num_of_pages = new System.Windows.Forms.Label();
            this.label_book_publisher = new System.Windows.Forms.Label();
            this.label_book_title = new System.Windows.Forms.Label();
            this.label_book_author = new System.Windows.Forms.Label();
            this.btn_book_add = new System.Windows.Forms.Button();
            this.cbox_book_return_in_time = new System.Windows.Forms.CheckBox();
            this.cbox_book_available = new System.Windows.Forms.CheckBox();
            this.tab_mags = new System.Windows.Forms.TabPage();
            this.cbox_mag_taken = new System.Windows.Forms.CheckBox();
            this.cbox_mag_sub = new System.Windows.Forms.CheckBox();
            this.btn_mag_add = new System.Windows.Forms.Button();
            this.nuc_mag_year = new System.Windows.Forms.NumericUpDown();
            this.nuc_mag_issue = new System.Windows.Forms.NumericUpDown();
            this.tbox_mag_volume = new System.Windows.Forms.TextBox();
            this.tbox_mag_title = new System.Windows.Forms.TextBox();
            this.label_mag_year = new System.Windows.Forms.Label();
            this.label_mag_issue = new System.Windows.Forms.Label();
            this.label_mag_title = new System.Windows.Forms.Label();
            this.label_mag_volume = new System.Windows.Forms.Label();
            this.rtbox_display = new System.Windows.Forms.RichTextBox();
            this.btn_lookup = new System.Windows.Forms.Button();
            this.cbox_inv_num_sort = new System.Windows.Forms.CheckBox();
            this.tab_view.SuspendLayout();
            this.tab_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_book_use_period)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_book_inv_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_book_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_book_num_of_pages)).BeginInit();
            this.tab_mags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_mag_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_mag_issue)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_view
            // 
            this.tab_view.Controls.Add(this.tab_books);
            this.tab_view.Controls.Add(this.tab_mags);
            this.tab_view.Location = new System.Drawing.Point(26, 25);
            this.tab_view.Name = "tab_view";
            this.tab_view.SelectedIndex = 0;
            this.tab_view.Size = new System.Drawing.Size(269, 356);
            this.tab_view.TabIndex = 0;
            // 
            // tab_books
            // 
            this.tab_books.BackColor = System.Drawing.Color.BurlyWood;
            this.tab_books.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab_books.Controls.Add(this.nuc_book_use_period);
            this.tab_books.Controls.Add(this.nuc_book_inv_num);
            this.tab_books.Controls.Add(this.nuc_book_year);
            this.tab_books.Controls.Add(this.nuc_book_num_of_pages);
            this.tab_books.Controls.Add(this.tbox_book_publisher);
            this.tab_books.Controls.Add(this.tbox_book_title);
            this.tab_books.Controls.Add(this.tbox_book_author);
            this.tab_books.Controls.Add(this.label_book_use_period);
            this.tab_books.Controls.Add(this.label_book_inv_num);
            this.tab_books.Controls.Add(this.label_book_year);
            this.tab_books.Controls.Add(this.label_book_num_of_pages);
            this.tab_books.Controls.Add(this.label_book_publisher);
            this.tab_books.Controls.Add(this.label_book_title);
            this.tab_books.Controls.Add(this.label_book_author);
            this.tab_books.Controls.Add(this.btn_book_add);
            this.tab_books.Controls.Add(this.cbox_book_return_in_time);
            this.tab_books.Controls.Add(this.cbox_book_available);
            this.tab_books.Location = new System.Drawing.Point(4, 22);
            this.tab_books.Name = "tab_books";
            this.tab_books.Padding = new System.Windows.Forms.Padding(3);
            this.tab_books.Size = new System.Drawing.Size(261, 330);
            this.tab_books.TabIndex = 0;
            this.tab_books.Text = "Books";
            // 
            // nuc_book_use_period
            // 
            this.nuc_book_use_period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nuc_book_use_period.Location = new System.Drawing.Point(152, 200);
            this.nuc_book_use_period.Name = "nuc_book_use_period";
            this.nuc_book_use_period.Size = new System.Drawing.Size(54, 20);
            this.nuc_book_use_period.TabIndex = 16;
            // 
            // nuc_book_inv_num
            // 
            this.nuc_book_inv_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nuc_book_inv_num.Location = new System.Drawing.Point(57, 200);
            this.nuc_book_inv_num.Name = "nuc_book_inv_num";
            this.nuc_book_inv_num.Size = new System.Drawing.Size(60, 20);
            this.nuc_book_inv_num.TabIndex = 15;
            // 
            // nuc_book_year
            // 
            this.nuc_book_year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nuc_book_year.Location = new System.Drawing.Point(152, 151);
            this.nuc_book_year.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nuc_book_year.Minimum = new decimal(new int[] {
            1965,
            0,
            0,
            0});
            this.nuc_book_year.Name = "nuc_book_year";
            this.nuc_book_year.Size = new System.Drawing.Size(54, 20);
            this.nuc_book_year.TabIndex = 14;
            this.nuc_book_year.Value = new decimal(new int[] {
            1965,
            0,
            0,
            0});
            // 
            // nuc_book_num_of_pages
            // 
            this.nuc_book_num_of_pages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nuc_book_num_of_pages.Location = new System.Drawing.Point(57, 151);
            this.nuc_book_num_of_pages.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuc_book_num_of_pages.Name = "nuc_book_num_of_pages";
            this.nuc_book_num_of_pages.Size = new System.Drawing.Size(60, 20);
            this.nuc_book_num_of_pages.TabIndex = 13;
            // 
            // tbox_book_publisher
            // 
            this.tbox_book_publisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbox_book_publisher.Location = new System.Drawing.Point(94, 87);
            this.tbox_book_publisher.Name = "tbox_book_publisher";
            this.tbox_book_publisher.Size = new System.Drawing.Size(144, 20);
            this.tbox_book_publisher.TabIndex = 12;
            // 
            // tbox_book_title
            // 
            this.tbox_book_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbox_book_title.Location = new System.Drawing.Point(94, 52);
            this.tbox_book_title.Name = "tbox_book_title";
            this.tbox_book_title.Size = new System.Drawing.Size(144, 20);
            this.tbox_book_title.TabIndex = 11;
            // 
            // tbox_book_author
            // 
            this.tbox_book_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbox_book_author.Location = new System.Drawing.Point(94, 17);
            this.tbox_book_author.Name = "tbox_book_author";
            this.tbox_book_author.Size = new System.Drawing.Size(144, 20);
            this.tbox_book_author.TabIndex = 10;
            // 
            // label_book_use_period
            // 
            this.label_book_use_period.AutoSize = true;
            this.label_book_use_period.Location = new System.Drawing.Point(149, 184);
            this.label_book_use_period.Name = "label_book_use_period";
            this.label_book_use_period.Size = new System.Drawing.Size(58, 13);
            this.label_book_use_period.TabIndex = 9;
            this.label_book_use_period.Text = "Use period";
            // 
            // label_book_inv_num
            // 
            this.label_book_inv_num.AutoSize = true;
            this.label_book_inv_num.Location = new System.Drawing.Point(60, 184);
            this.label_book_inv_num.Name = "label_book_inv_num";
            this.label_book_inv_num.Size = new System.Drawing.Size(61, 13);
            this.label_book_inv_num.TabIndex = 8;
            this.label_book_inv_num.Text = "Inventory #";
            // 
            // label_book_year
            // 
            this.label_book_year.AutoSize = true;
            this.label_book_year.Location = new System.Drawing.Point(162, 135);
            this.label_book_year.Name = "label_book_year";
            this.label_book_year.Size = new System.Drawing.Size(29, 13);
            this.label_book_year.TabIndex = 7;
            this.label_book_year.Text = "Year";
            // 
            // label_book_num_of_pages
            // 
            this.label_book_num_of_pages.AutoSize = true;
            this.label_book_num_of_pages.Location = new System.Drawing.Point(60, 135);
            this.label_book_num_of_pages.Name = "label_book_num_of_pages";
            this.label_book_num_of_pages.Size = new System.Drawing.Size(58, 13);
            this.label_book_num_of_pages.TabIndex = 6;
            this.label_book_num_of_pages.Text = "# of pages";
            this.label_book_num_of_pages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_book_publisher
            // 
            this.label_book_publisher.AutoSize = true;
            this.label_book_publisher.Location = new System.Drawing.Point(31, 90);
            this.label_book_publisher.Name = "label_book_publisher";
            this.label_book_publisher.Size = new System.Drawing.Size(50, 13);
            this.label_book_publisher.TabIndex = 5;
            this.label_book_publisher.Text = "Publisher";
            // 
            // label_book_title
            // 
            this.label_book_title.AutoSize = true;
            this.label_book_title.Location = new System.Drawing.Point(31, 55);
            this.label_book_title.Name = "label_book_title";
            this.label_book_title.Size = new System.Drawing.Size(27, 13);
            this.label_book_title.TabIndex = 4;
            this.label_book_title.Text = "Title";
            // 
            // label_book_author
            // 
            this.label_book_author.AutoSize = true;
            this.label_book_author.Location = new System.Drawing.Point(31, 20);
            this.label_book_author.Name = "label_book_author";
            this.label_book_author.Size = new System.Drawing.Size(38, 13);
            this.label_book_author.TabIndex = 3;
            this.label_book_author.Text = "Author";
            // 
            // btn_book_add
            // 
            this.btn_book_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_book_add.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book_add.Location = new System.Drawing.Point(41, 271);
            this.btn_book_add.Name = "btn_book_add";
            this.btn_book_add.Size = new System.Drawing.Size(177, 39);
            this.btn_book_add.TabIndex = 2;
            this.btn_book_add.Text = "Add book";
            this.btn_book_add.UseVisualStyleBackColor = false;
            this.btn_book_add.Click += new System.EventHandler(this.btn_book_add_Click);
            // 
            // cbox_book_return_in_time
            // 
            this.cbox_book_return_in_time.AutoSize = true;
            this.cbox_book_return_in_time.Location = new System.Drawing.Point(138, 237);
            this.cbox_book_return_in_time.Name = "cbox_book_return_in_time";
            this.cbox_book_return_in_time.Size = new System.Drawing.Size(91, 17);
            this.cbox_book_return_in_time.TabIndex = 1;
            this.cbox_book_return_in_time.Text = "Return in time";
            this.cbox_book_return_in_time.UseVisualStyleBackColor = true;
            // 
            // cbox_book_available
            // 
            this.cbox_book_available.AutoSize = true;
            this.cbox_book_available.Location = new System.Drawing.Point(53, 237);
            this.cbox_book_available.Name = "cbox_book_available";
            this.cbox_book_available.Size = new System.Drawing.Size(69, 17);
            this.cbox_book_available.TabIndex = 0;
            this.cbox_book_available.Text = "Available";
            this.cbox_book_available.UseVisualStyleBackColor = true;
            // 
            // tab_mags
            // 
            this.tab_mags.BackColor = System.Drawing.Color.BurlyWood;
            this.tab_mags.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab_mags.Controls.Add(this.cbox_mag_taken);
            this.tab_mags.Controls.Add(this.cbox_mag_sub);
            this.tab_mags.Controls.Add(this.btn_mag_add);
            this.tab_mags.Controls.Add(this.nuc_mag_year);
            this.tab_mags.Controls.Add(this.nuc_mag_issue);
            this.tab_mags.Controls.Add(this.tbox_mag_volume);
            this.tab_mags.Controls.Add(this.tbox_mag_title);
            this.tab_mags.Controls.Add(this.label_mag_year);
            this.tab_mags.Controls.Add(this.label_mag_issue);
            this.tab_mags.Controls.Add(this.label_mag_title);
            this.tab_mags.Controls.Add(this.label_mag_volume);
            this.tab_mags.Location = new System.Drawing.Point(4, 22);
            this.tab_mags.Name = "tab_mags";
            this.tab_mags.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mags.Size = new System.Drawing.Size(261, 330);
            this.tab_mags.TabIndex = 1;
            this.tab_mags.Text = "Magazines";
            // 
            // cbox_mag_taken
            // 
            this.cbox_mag_taken.AutoSize = true;
            this.cbox_mag_taken.Location = new System.Drawing.Point(138, 237);
            this.cbox_mag_taken.Name = "cbox_mag_taken";
            this.cbox_mag_taken.Size = new System.Drawing.Size(51, 17);
            this.cbox_mag_taken.TabIndex = 10;
            this.cbox_mag_taken.Text = "Take";
            this.cbox_mag_taken.UseVisualStyleBackColor = true;
            // 
            // cbox_mag_sub
            // 
            this.cbox_mag_sub.AutoSize = true;
            this.cbox_mag_sub.Location = new System.Drawing.Point(53, 237);
            this.cbox_mag_sub.Name = "cbox_mag_sub";
            this.cbox_mag_sub.Size = new System.Drawing.Size(73, 17);
            this.cbox_mag_sub.TabIndex = 9;
            this.cbox_mag_sub.Text = "Subscribe";
            this.cbox_mag_sub.UseVisualStyleBackColor = true;
            // 
            // btn_mag_add
            // 
            this.btn_mag_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_mag_add.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mag_add.Location = new System.Drawing.Point(41, 271);
            this.btn_mag_add.Name = "btn_mag_add";
            this.btn_mag_add.Size = new System.Drawing.Size(177, 39);
            this.btn_mag_add.TabIndex = 8;
            this.btn_mag_add.Text = "Add magazine";
            this.btn_mag_add.UseVisualStyleBackColor = false;
            this.btn_mag_add.Click += new System.EventHandler(this.btn_mag_add_Click);
            // 
            // nuc_mag_year
            // 
            this.nuc_mag_year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nuc_mag_year.Location = new System.Drawing.Point(94, 122);
            this.nuc_mag_year.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nuc_mag_year.Name = "nuc_mag_year";
            this.nuc_mag_year.Size = new System.Drawing.Size(54, 20);
            this.nuc_mag_year.TabIndex = 7;
            // 
            // nuc_mag_issue
            // 
            this.nuc_mag_issue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nuc_mag_issue.Location = new System.Drawing.Point(94, 87);
            this.nuc_mag_issue.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nuc_mag_issue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuc_mag_issue.Name = "nuc_mag_issue";
            this.nuc_mag_issue.Size = new System.Drawing.Size(54, 20);
            this.nuc_mag_issue.TabIndex = 6;
            this.nuc_mag_issue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbox_mag_volume
            // 
            this.tbox_mag_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbox_mag_volume.Location = new System.Drawing.Point(94, 52);
            this.tbox_mag_volume.Name = "tbox_mag_volume";
            this.tbox_mag_volume.Size = new System.Drawing.Size(144, 20);
            this.tbox_mag_volume.TabIndex = 5;
            // 
            // tbox_mag_title
            // 
            this.tbox_mag_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbox_mag_title.Location = new System.Drawing.Point(94, 17);
            this.tbox_mag_title.Name = "tbox_mag_title";
            this.tbox_mag_title.Size = new System.Drawing.Size(144, 20);
            this.tbox_mag_title.TabIndex = 4;
            // 
            // label_mag_year
            // 
            this.label_mag_year.AutoSize = true;
            this.label_mag_year.Location = new System.Drawing.Point(31, 125);
            this.label_mag_year.Name = "label_mag_year";
            this.label_mag_year.Size = new System.Drawing.Size(29, 13);
            this.label_mag_year.TabIndex = 3;
            this.label_mag_year.Text = "Year";
            // 
            // label_mag_issue
            // 
            this.label_mag_issue.AutoSize = true;
            this.label_mag_issue.Location = new System.Drawing.Point(31, 90);
            this.label_mag_issue.Name = "label_mag_issue";
            this.label_mag_issue.Size = new System.Drawing.Size(32, 13);
            this.label_mag_issue.TabIndex = 2;
            this.label_mag_issue.Text = "Issue";
            // 
            // label_mag_title
            // 
            this.label_mag_title.AutoSize = true;
            this.label_mag_title.Location = new System.Drawing.Point(31, 20);
            this.label_mag_title.Name = "label_mag_title";
            this.label_mag_title.Size = new System.Drawing.Size(27, 13);
            this.label_mag_title.TabIndex = 1;
            this.label_mag_title.Text = "Title";
            // 
            // label_mag_volume
            // 
            this.label_mag_volume.AutoSize = true;
            this.label_mag_volume.Location = new System.Drawing.Point(31, 55);
            this.label_mag_volume.Name = "label_mag_volume";
            this.label_mag_volume.Size = new System.Drawing.Size(42, 13);
            this.label_mag_volume.TabIndex = 0;
            this.label_mag_volume.Text = "Volume";
            // 
            // rtbox_display
            // 
            this.rtbox_display.BackColor = System.Drawing.Color.BurlyWood;
            this.rtbox_display.Location = new System.Drawing.Point(342, 61);
            this.rtbox_display.Name = "rtbox_display";
            this.rtbox_display.Size = new System.Drawing.Size(277, 283);
            this.rtbox_display.TabIndex = 1;
            this.rtbox_display.Text = "";
            // 
            // btn_lookup
            // 
            this.btn_lookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_lookup.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lookup.Location = new System.Drawing.Point(355, 354);
            this.btn_lookup.Name = "btn_lookup";
            this.btn_lookup.Size = new System.Drawing.Size(135, 23);
            this.btn_lookup.TabIndex = 2;
            this.btn_lookup.Text = "Look up";
            this.btn_lookup.UseVisualStyleBackColor = false;
            this.btn_lookup.Click += new System.EventHandler(this.btn_lookup_Click);
            // 
            // cbox_inv_num_sort
            // 
            this.cbox_inv_num_sort.AutoSize = true;
            this.cbox_inv_num_sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbox_inv_num_sort.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_inv_num_sort.Location = new System.Drawing.Point(502, 355);
            this.cbox_inv_num_sort.Name = "cbox_inv_num_sort";
            this.cbox_inv_num_sort.Size = new System.Drawing.Size(104, 21);
            this.cbox_inv_num_sort.TabIndex = 3;
            this.cbox_inv_num_sort.Text = "Sort by inv. #";
            this.cbox_inv_num_sort.UseVisualStyleBackColor = false;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 407);
            this.Controls.Add(this.cbox_inv_num_sort);
            this.Controls.Add(this.btn_lookup);
            this.Controls.Add(this.rtbox_display);
            this.Controls.Add(this.tab_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 450);
            this.Name = "main_window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.tab_view.ResumeLayout(false);
            this.tab_books.ResumeLayout(false);
            this.tab_books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_book_use_period)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_book_inv_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_book_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_book_num_of_pages)).EndInit();
            this.tab_mags.ResumeLayout(false);
            this.tab_mags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_mag_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuc_mag_issue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_view;
        private System.Windows.Forms.TabPage tab_books;
        private System.Windows.Forms.TabPage tab_mags;
        private System.Windows.Forms.RichTextBox rtbox_display;
        private System.Windows.Forms.NumericUpDown nuc_book_use_period;
        private System.Windows.Forms.NumericUpDown nuc_book_inv_num;
        private System.Windows.Forms.NumericUpDown nuc_book_year;
        private System.Windows.Forms.NumericUpDown nuc_book_num_of_pages;
        private System.Windows.Forms.TextBox tbox_book_publisher;
        private System.Windows.Forms.TextBox tbox_book_title;
        private System.Windows.Forms.TextBox tbox_book_author;
        private System.Windows.Forms.Label label_book_use_period;
        private System.Windows.Forms.Label label_book_inv_num;
        private System.Windows.Forms.Label label_book_year;
        private System.Windows.Forms.Label label_book_num_of_pages;
        private System.Windows.Forms.Label label_book_publisher;
        private System.Windows.Forms.Label label_book_title;
        private System.Windows.Forms.Label label_book_author;
        private System.Windows.Forms.Button btn_book_add;
        private System.Windows.Forms.CheckBox cbox_book_return_in_time;
        private System.Windows.Forms.CheckBox cbox_book_available;
        private System.Windows.Forms.Button btn_lookup;
        private System.Windows.Forms.CheckBox cbox_inv_num_sort;
        private System.Windows.Forms.TextBox tbox_mag_volume;
        private System.Windows.Forms.TextBox tbox_mag_title;
        private System.Windows.Forms.Label label_mag_year;
        private System.Windows.Forms.Label label_mag_issue;
        private System.Windows.Forms.Label label_mag_title;
        private System.Windows.Forms.Label label_mag_volume;
        private System.Windows.Forms.NumericUpDown nuc_mag_year;
        private System.Windows.Forms.NumericUpDown nuc_mag_issue;
        private System.Windows.Forms.Button btn_mag_add;
        private System.Windows.Forms.CheckBox cbox_mag_sub;
        private System.Windows.Forms.CheckBox cbox_mag_taken;
    }
}