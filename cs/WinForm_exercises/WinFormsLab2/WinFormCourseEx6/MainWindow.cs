using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormCourseEx6
{
    public partial class main_window : Form
    {
        List<Item> items = new List<Item>();        

        #region
        public string Book_author    {get {return tbox_book_author.Text;}            set {tbox_book_author.Text = value;} }
        public string Book_title     {get {return tbox_book_title.Text;}             set {tbox_book_title.Text = value;} }
        public string Book_publisher {get {return tbox_book_publisher.Text;}         set {tbox_book_publisher.Text = value;} }
        public int Book_num_of_pages {get {return (int)nuc_book_num_of_pages.Value;} set {nuc_book_num_of_pages.Value = value;} }
        public int Book_year         {get {return (int)nuc_book_year.Value;}         set {nuc_book_year.Value = value;} }
        public int Book_inv_num      {get {return (int)nuc_book_inv_num.Value;}      set {nuc_book_inv_num.Value = value;} }
        public int Book_use_period   {get {return (int)nuc_book_use_period.Value; }  set {nuc_book_use_period.Value = value; } }
        public bool Book_available   {get {return cbox_book_available.Checked;}      set {cbox_book_available.Checked = value;} }

        public string Mag_title      {get {return tbox_mag_title.Text;}              set {tbox_mag_title.Text = value;} }
        public string Mag_volume     {get {return tbox_mag_volume.Text;}             set {tbox_mag_volume.Text = value; } }
        public int Mag_issue         {get {return (int)nuc_mag_issue.Value;}         set {nuc_mag_year.Value = value;} }
        public int Mag_year          {get {return (int)nuc_book_inv_num.Value;}      set {nuc_book_inv_num.Value = value;} }
        public bool Mag_subed        {get {return cbox_mag_sub.Checked;}             set {cbox_mag_sub.Checked = value;} }
        public bool Mag_taken        {get {return cbox_mag_sub.Checked;}             set {cbox_mag_sub.Checked = value;} }
        //public bool Inv_num_sort { get {return cbox_book_ret_period.Checked;} set {cbox_book_ret_period.Checked = value;} }
        public bool Return_time      {get {return cbox_mag_taken.Checked;}           set {cbox_mag_taken.Checked = value;} }
        #endregion

        public main_window()
        {
            InitializeComponent();
        }

        private void btn_book_add_Click(object sender, EventArgs e)
        {
            Book book = new Book(Book_author,
                                 Book_title,
                                 Book_publisher,
                                 Book_num_of_pages,
                                 Book_year,
                                 Book_inv_num,
                                 Book_available);
            
            if (Return_time)
            {
                book.ReturnTime();
                book.BookPrice(Book_use_period);
                                                    }
            
            items.Add(book);
            
            Book_author = Book_title = Book_publisher = "";
            Book_num_of_pages = Book_inv_num = Book_use_period = 0;
            Book_year = 1965;
            Book_available = Return_time = false;
                                                    }

        
        private void btn_mag_add_Click(object sender, EventArgs e)
        {
             Magazine mag = new Magazine(Mag_title,
                                         Mag_volume,
                                         Mag_issue,
                                         Mag_year,
                                         Mag_subed);

            items.Add(mag);

            Mag_title = Mag_volume = "";
            Mag_issue = 1;
            Mag_year = 2000;
                               }

        private void btn_lookup_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Item item in items)
            {
                sb.Append("\n" + item.ToString());
                                                     }

            rtbox_display.Text = sb.ToString();
        }

    }
}
