
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

public class FileStorageRequest
{
    public FileStorageRequest()
    {
        requests = new List<Request>();
        string filePath = @"C:\Users\Asus\Desktop\sims5\Sims\Sims\Data\request.txt";
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
}