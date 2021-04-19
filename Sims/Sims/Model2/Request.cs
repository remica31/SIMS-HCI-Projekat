
using System;
using System.Collections.Generic;

public class Request
{
    public Request() { }

    public void Create(String newId, String newDescription, String newDateOfSubmissionRequest, int newDuration, StatusType newStatus)
    {
        var req = new Request();
        req.Id = newId;
        req.Description = newDescription;
        req.DateOfSubmissionRequest = newDateOfSubmissionRequest;
        req.Duration = newDuration;
        req.Status = newStatus;
        requests.Add(req);

    }

    public void Update(String newDescription, int newDuration)
    {
        Description = newDescription;
        Duration = newDuration;
    }

    public void Delete(String id)
    {
        foreach (var req in requests)
        {
            if (id == req.Id)
            {
                requests.Remove(req);
            }
        }
    }

    public Request Read(String id)
    {
        foreach (var req in requests)
        {
            if (id == req.Id)
            {
                return req;
            }
        }
        return null;
    }

    public String Id { get; set; }
    public String Description { get; set; }
    public String DateOfSubmissionRequest { get; set; }
    public int Duration { get; set; }
    public StatusType Status;

    public Doctor doctor { get; set; }

    List<Request> requests = new List<Request>();
    public List<Request> GetRequests()
    {
        return requests;
    }

}