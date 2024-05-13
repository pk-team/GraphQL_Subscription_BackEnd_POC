namespace HotChocPubSub.Domain;

public class TimeEntry {
    public string? Description { get; private set; }
    public DateTimeOffset Date { get; private set; }
    public int Hours { get; private set; }

    public static TimeEntry Create(string description, int hours)
    {
        return new TimeEntry
        {
            Description = description,
            Hours = hours,
            Date = DateTimeOffset.UtcNow
        };
    }


    private TimeEntry() 
    {
    }
}