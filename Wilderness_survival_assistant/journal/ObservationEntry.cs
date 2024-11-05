namespace Wilderness_survival_assistant.journal;

using System;

public class ObservationEntry
{
    public string Description { get; set; }
    public DateTime Date { get; set; }

    public ObservationEntry(string description, DateTime date)
    {
        Description = description;
        Date = date;
    }
}
