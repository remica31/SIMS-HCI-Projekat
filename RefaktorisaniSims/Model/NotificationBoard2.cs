/***********************************************************************
 * Module:  MedicineNotification.cs
 * Author:  Remica
 * Purpose: Definition of the Class Model.MedicineNotification
 ***********************************************************************/

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class NotificationBoard2
   {
      public String Id { get; set; }
        public String FroomRoomId { get; set; }
        public String ToRoomId { get; set; }
        public DateTime Date { get; set; }
        public String EqName { get; set; }

        public NotificationBoard2(string id, string rid1, string rid2, DateTime date, string name)
        {
            Id = id;
            FroomRoomId = rid1;
            ToRoomId = rid2;
            Date = date;
            EqName = name;
        }
   
   }
}