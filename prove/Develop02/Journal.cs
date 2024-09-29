using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{

    public List<Entry> _userEntries = new List<Entry>();
    public List<Entry> _allRecords = new List<Entry>();
    public void AddEntry(List<Entry> entries){
      
        foreach (var entry in entries)
        {
            _allRecords.Add(entry);
        }
    }
    
    public void DisplayAll(){
            Console.WriteLine($"Your Records:\n");
            foreach (var record in _userEntries)
            {
                record.DisplayingRecords();
            }
        }

    public void SaveToFile(string fileName)
    {
    using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var record in _allRecords)
            {
                outputFile.WriteLine($"Date: {record._date}; - Prompt: {record._promptText};");
                outputFile.WriteLine($"Your record: {record._entryText};");
                outputFile.WriteLine();
            }
                 
        }
    }

    public void LoadFromFile(string fileName)
    {
        _userEntries.Clear();

        if (File.Exists(fileName))
        {
            string [] records = File.ReadAllLines(fileName);
           foreach(string record in records)
            {
                string[] parts = record.Split(";");
              

                if(parts.Length == 3)
                {
                   
                    string date = parts[0].Trim();
                    string promp = parts[1].Trim();
                    string entryText = parts[2].Trim();

                    Entry entry = new Entry();
                    entry._date = date;
                    entry._promptText = promp;
                    entry._entryText = entryText;
                    _userEntries.Add(entry);
                    DisplayAll();
                }            
            }
        }

        else{
            Console.WriteLine($"The filename {fileName} does not exist.");
        }
    }
}

   


