using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormCourseEx6
{
    abstract class Item : IComparable
    {
        protected long invNum; // инвентарный номер — целое число
        protected bool taken;    // хранит состояние объекта - взят ли на руки
        
        abstract public void Return();    // операция "вернуть"

        public Item(long invNum, bool taken)
        {
            this.invNum = invNum;
            this.taken = taken;
        }

        public Item()
        {
            this.taken = true;
        }
           
   public bool IsAvailable()    // истина, если этот предмет имеется в библиотеке
      {
          if (taken == true)
              return true;
          else
              return false;
      }

   public long GetInvNumber()   // инвентарный номер  
      {
          return invNum;
      }


   private void Take()      // операция "взять"
        {
            taken = false;
        }

   public void TakeItem()
   {
       if (this.IsAvailable())
           this.Take();
   }


   public override string ToString()
   {
       if (taken)
       return "Состояние хранения: Инвентарный номер: " + invNum + ". В наличии";
       else
           return "Состояние хранения: Инвентарный номер: " + invNum + ". Нет в наличии";
   }


   int IComparable.CompareTo(object obj)
   {
       Item item = (Item)obj;
       if (this.invNum == item.invNum) return 0;
       else if (this.invNum > item.invNum) return 1;
       else return -1;
   }


  }
}
