
using System;
using System.Collections.Generic;

public class Appointment

{
    public Appointment() { }

    public void Create(String newId, double newStart, int newMonth, int newDay, double finish, double newDuration, AppointmentType newType)
    {
        var app = new Appointment();
        app.Id = newId;
        app.Start = newStart;
        app.Month = newMonth;
        app.Day = newDay;
        app.Finish = finish;
        app.Duration = newDuration;
        app.Type = newType;
        appointments.Add(app);
    }

    public void Update(int day, int month, double start, double duration, double finish)
    {
        Start = start;
        Duration = duration;
        Finish = finish;
        Day = day;
        Month = month;
    }

    public void Delete(String id)
    {
        foreach (var app in appointments)
        {
            if (app.Id == id)
            {
                appointments.Remove(app);
            }
        }
    }

    public Appointment GetById(String id)
    {
        var newApp = new Appointment();
        foreach (var app in appointments)
        {
            if (app.Id == id)
            {
                newApp = app;
                return newApp;
            }
        }
        return null;
    }

    public List<Appointment> GetByDoctorId(String doctorId)
    {
        var apps = new List<Appointment>();
        foreach (var app in appointments)
        {
            if (doctorId == app.doctor.user.Id)
            {
                apps.Add(app);
            }
        }
        return apps;
    }

    public List<Appointment> GetByPatientId(String patientId)
    {
        var apps = new List<Appointment>();
        foreach (var app in appointments)
        {
            if (patientId == app.patient.user.Id)
            {
                apps.Add(app);
            }
        }
        return apps;
    }

    public List<Appointment> GetAll()
    {

        return appointments;
    }

    public String Id { get; set; }
    public double Start { get; set; }
    public double Duration { get; set; }
    public AppointmentType Type;
    public double Finish { get; set; }

    public int Month { get; set; }
    public int Day { get; set; }
    public Doctor doctor { get; set; }
    public Patient patient { get; set; }

    public List<Appointment> appointments = new List<Appointment>();

}