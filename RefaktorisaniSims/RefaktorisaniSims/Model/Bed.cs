/***********************************************************************
 * Module:  Bed.cs
 * Author:  User
 * Purpose: Definition of the Class Bed
 ***********************************************************************/

using System;

namespace Model
{


    public class Bed
    {
        public Bed()
        {
            Status = "Free";
            Number = 2;
        }
        public String Status { get; set; }

        public int Number { get; set; }
    }

}