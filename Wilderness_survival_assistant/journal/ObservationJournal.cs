namespace Wilderness_survival_assistant.journal;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class ObservationJournal
{
    private List<ObservationEntry> entries;

    public ObservationJournal()
    {
        entries = new List<ObservationEntry>();
    }

    // Method to add an observation entry without a date
    public void AddEntry(string description)
    {
        AddEntry(description, DateTime.Now);
    }

    // Method to add an observation entry with a date
    public void AddEntry(string description, DateTime date)
    {
        var entry = new ObservationEntry(description, date);
        entries.Add(entry);
    }

    // Method to view all observation entries
    public List<ObservationEntry> ViewEntries()
    {
        return entries;
    }

    // Method to save entries to a JSON file
    public void SaveToJson(string filename)
    {
        var json = JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, json);
    }

    // Method to load entries from a JSON file
    public void LoadFromJson(string filename)
    {
        if (File.Exists(filename))
        {
            var json = File.ReadAllText(filename);
            entries = JsonSerializer.Deserialize<List<ObservationEntry>>(json);
        }
        else
        {
            Console.WriteLine($"File {filename} not found.");
        }
    }
}
