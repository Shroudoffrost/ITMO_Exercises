using System;

namespace WinFormCourseEx6
{
    class Book : Item
    {
        private String book_author;
        private String book_title;
        private String book_publisher;
        private int book_pages;
        private int book_year;

        private double cust;
        private bool return_time;

        private static double price = 9;
        
        static Book()       //статический конструктор
        {
            price = 100;
        }

        
        public Book(String author, String title, String publisher, int pages, int year, long invNumber, bool taken) : base (invNumber, taken)
        {
            this.book_author = author;
            this.book_title = title;
            this.book_publisher = publisher;
            this.book_pages = pages;
            this.book_year = year;
        }

        public Book()
        { }



        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public override string ToString()
        {
            if (this.IsAvailable())
            return "\nКнига:\n Автор: " + book_author +"\n Название: " + book_title +
            "\n Год издания: " + book_year + "., " + book_pages + " стр. \n Стоимость аренды: " + Book.price + " p.\n" + base.ToString()
            + "\nИтого за чтение: " + cust + " p.";
            else
                return "\nКнига:\n Автор: " + book_author +"\n Название: " + book_title +
            "\n Год издания: " + book_year + "., " + book_pages + " стр. \n Стоимость аренды: " + Book.price + " p.\n" + base.ToString();

        }

        public void BookPrice(int s)
        {

            if (this.return_time == true)
                this.cust = s * price;
            else this.cust = s * (price + price * 0.13); ;
            
        }

        public void ReturnTime()
        {
            return_time = true;
        }

        public override void Return()    // операция "вернуть"
        {
            if (return_time == true)
                taken = true;
            else
                taken = false;
        }

    }
}
