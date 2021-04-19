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
        string filePath = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\patients.txt";
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
    public void deletePatient(string newId)
    {
        List<Patient> newList = new List<Patient>();
        foreach (var pat in patients)
        {
            if (pat.user.Id != newId)
            {
                newList.Add(pat);
            }
        }
        patients = newList;
    }
        public void updatePatient(String newUsername, String newPassword, String newID, String newJmbg, String newName, String newSurname, String newEmail, String newAddress, String newPhone)
    {
        foreach (var pat in patients)
        {
            if (pat.user.Id == newID)
            {
                pat.user.Username = newUsername;
                pat.user.Jmbg = newJmbg;
                pat.user.Name = newName;
                pat.user.Address = newAddress;
                pat.user.Surname = newSurname;
                pat.user.Phone = newPhone;
                pat.user.EMail = newEmail;
                pat.user.Password = newPassword;
            }
        }

    }
    public void Create(String newUsername, String newPassword, String newID, String newJmbg, String newName, String newSurname, String newEmail, String newAddress, String newPhone)
    {
     
        string filePath1 = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\patients.txt";
        List<string> lines = new List<string>();
        lines = File.ReadAllLines(filePath1).ToList();
        string jmbg = newJmbg;
        string username = newUsername;
        string id = newID;
        string password = newPassword;
        string name = newName;
        string surname = newSurname;
        string address = newAddress;
        string phone = newPhone;
        string email = newEmail;
        string s10 = jmbg + "," + username + "," + password + "," + id + "," + name + "," + surname + "," + email + "," + address + "," + phone;
        lines.Add(s10);
        File.WriteAllLines(filePath1, lines);
    }
    public List<Patient> patients;

    public List<Patient> GetPatients()
    {
        return patients;
    }
    public void write()
    {
        string filePath1 = @"C:\Users\Remica\Desktop\rema\Sims\Sims\Data\patients.txt";
        List<string> lines = new List<string>();
        foreach (var pat in patients)
        {
            string jmbg = pat.user.Jmbg;
            string username = pat.user.Username;
            string id = pat.user.Id;//"A1";
            string password = pat.user.Password;
            string name = pat.user.Name;
            string surname = pat.user.Surname;
            string address = pat.user.Address;
            string phone = pat.user.Phone;
            string email = pat.user.EMail;
            string s10 = jmbg + "," + username + "," + password + "," + id + ","+ name + "," + surname + ","+ email +"," + address + "," + phone;
            lines.Add(s10);
        }
        File.WriteAllLines(filePath1, lines);
    }


}