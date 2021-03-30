
using System;
using System.Collections.Generic;

public class Patient
{
    public Patient() { }

    public List<Patient> GetAll()
    {
        return patients;
    }

    public Patient GetById(String id)
    {
        foreach (var pat in patients)
        {
            if (id == pat.user.Id)
            {
                return pat;
            }
        }
        return null;
    }

    public void Create(String newUsername, String newPassword, String newID, String newJmbg, String newName, String newSurname, String newEmail, String newAddress, String newPhone)
    {
        var patient = new Patient();
        patient.user.Username = newUsername;
        patient.user.Password = newPassword;
        patient.user.Id = newID;
        patient.user.Jmbg = newJmbg;
        patient.user.Name = newName;
        patient.user.Surname = newSurname;
        patient.user.EMail = newEmail;
        patient.user.Address = newAddress;
        patient.user.Phone = newPhone;
        patients.Add(patient);
    }

    public void Update(String newEmail, String newAddress, String newPhone)
    {
        user.EMail = newEmail;
        user.Address = newAddress;
        user.Phone = newPhone;
    }

    public void Delete(String id)
    {
        foreach (var pat in patients)
        {
            if (id == pat.user.Id)
            {
                patients.Remove(pat);
            }
        }
    }

    public User user { get; set; }
    public Appointment[] appointment { get; set; }
    public List<Patient> patients = new List<Patient>();

}