
using System;

public class Doctor
{
   public String SpecializationType { get; set; }
   
   public Request request { get; set; }
   public User user { get; set; }
    public Room room { get; set; }
    public Appointment[] appointment { get; set; }

}