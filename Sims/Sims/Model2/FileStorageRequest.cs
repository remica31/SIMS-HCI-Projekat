
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class FileStorageRequest
{

    public FileStorageRequest()
    {
        requests = new List<Request>();
        string filePath = @"C:\Users\Remica\Downloads\wetransfer-d7f49c (1)\Sims\Sims\Data\request.txt";
        List<string> lines = File.ReadAllLines(filePath).ToList();

        foreach (var line in lines)
        {
            var newRequest = new Request();

            string[] entries = line.Split(',');

            newRequest.Id = entries[0];
            newRequest.Description = entries[1];
            newRequest.DateOfSubmissionRequest = entries[2];
            newRequest.Duration = Convert.ToInt32(entries[3]);
            requests.Add(newRequest);

        }
    }
    public List<Request> requests;
    public List<Request> GetRequests()
    {
        return requests;
    }

    public void createRequest(string id, string desc, string date, int dur)
    {
        string filePath1 = @"C:\Users\Remica\Downloads\wetransfer-d7f49c (1)\Sims\Sims\Data\request.txt";
        List<string> lines = new List<string>();
        lines = File.ReadAllLines(filePath1).ToList();

        string newLine = id + ", " + desc + ", " + date + "," + dur.ToString() + ",WAITING " + " ,d1";
        lines.Add(newLine);
        File.WriteAllLines(filePath1, lines);
    }

    public void updateRequest(string id, string newDescription, string newDate, int newDuration)
    {
        foreach (var req in requests)

        {
            if (req.Id == id)
            {
                req.Description = newDescription;
                req.DateOfSubmissionRequest = newDate;
                req.Duration = newDuration;
            }
        }

    }
    public void deleteRequest(string id)
    {
        List<Request> newRequests = new List<Request>();
        foreach (var req in requests)
        {
            if (req.Id != id)
            {
                newRequests.Add(req);
            }
        }
        requests = newRequests;
    }
    public void write()
    {
        string filePath1 = @"C:\Users\Remica\Downloads\wetransfer-d7f49c (1)\Sims\Sims\Data\request.txt";
        List<string> lines = new List<string>();
        foreach (var req in requests)
        {
            string id = Convert.ToString(req.Id);//"A1";
            string description = Convert.ToString(req.Description);//"12";
            string date = Convert.ToString(req.DateOfSubmissionRequest);//"1";
            string duration = req.Duration.ToString();
            string s10 = id + "," + description + "," + date + "," + duration + ",WAITING" + ",d1";
            lines.Add(s10);
        }
        File.WriteAllLines(filePath1, lines);
    }
}