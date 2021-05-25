/***********************************************************************
 * Module:  MedicineNotification.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.MedicineNotification
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class NotificationBoard
   {
        public NotificationBoard(string id, string name, string text, DateTime Date)
        {
            Id = id;
            Name = name;
            Text = text;
            this.Date = Date;
        }
        public NotificationBoard() { }
      public String Id { set; get; }
      public String Name { set; get; }
        public String Text { set; get; }
        public DateTime Date { set; get; }

    }
}