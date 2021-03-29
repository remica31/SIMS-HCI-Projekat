

using System;

public class Request
{
   public void Create(int newId, String newDescription, DateTime newDateOfSubmissionRequest, int newDuration, StatusType newStatus)
   {
      // TODO: implement
   }
   
   public void Update(String newDescription, DateTime newDateOfSubmissionRequest, int newDuration)
   {
      // TODO: implement
   }
   
   public void Delete(int id)
   {
      // TODO: implement
   }
   
   public Request Read(int id)
   {
      // TODO: implement
      return null;
   }

   public int Id;
   public String Description;
   public DateTime DateOfSubmissionRequest;
   public int Duration;
   public StatusType Status;
   
   public Doctor doctor;

}