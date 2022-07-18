using System;

namespace WinFormCourseEx6
{
    class Magazine : Item, IPubs
    {
        private String mag_title;
        private String mag_volume;
        private int mag_issue;
        private int mag_year;

        public bool Subed { get; set; }

        public Magazine(String title, String volume, int issue, int year_mag, bool taken)
        {
            this.mag_volume = volume;
            this.mag_issue = issue;
            this.mag_title = title;
            this.mag_year = year_mag;
        }


       public override void Return()    // операция "вернуть"
       {
           taken = true;
       }

        // реализация интерфейса

      

      public void Subs()
      {
          // действия при оформлении подписки на журнал
      }


       public override string ToString()
       {
            if (Subed)
            {
                return "\nЖурнал:\n Название: " + mag_title + "\nТом: " + mag_volume + "\n Номер: " + mag_issue + "\nГод выпуска: " + mag_year + "\n Подписка оформлена";
            }
            else
            {
                return "\nЖурнал:\n Название: " + mag_title + "\nТом: " + mag_volume + "\n Номер: " + mag_issue + "\nГод выпуска: " + mag_year + "\n Подписка не оформлена";
            }
       }
    }
}
