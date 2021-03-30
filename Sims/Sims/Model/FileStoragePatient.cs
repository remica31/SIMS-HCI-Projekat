/***********************************************************************
 * Module:  FileStoragePatient.cs
 * Author:  Vujke
 * Purpose: Definition of the Class FileStoragePatient
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class FileStoragePatient
{
   public  FileStoragePatient() 
   {

        patients = new List<Patient>();
        string filePath = @"C:\Users\Asus\Desktop\sims5\Sims\Sims\Data\user.txt";
        List<string> lines = File.ReadAllLines(filePath).ToList();

        foreach (var line in lines)
        {
            var newuser = new User();


            string[] entries = line.Split(',');
            newuser.Jmbg = entries[0];
            newuser.Username = entries[1];
            newuser.Password = entries[2];
            newuser.Id = entries[3];
            newuser.Name = entries[4];
            newuser.Surname = entries[5];
            newuser.EMail = entries[6];
            newuser.Address = entries[7];
            newuser.Phone = entries[8];
            if (newuser.Id[0] == 'p')
            {
                var newPatient = new Patient { user = newuser };
                patients.Add(newPatient);
            }
        }



    }

    public List<Patient> patients;

    public List<Patient> GetPatients()
    {
        return patients;
    }


}