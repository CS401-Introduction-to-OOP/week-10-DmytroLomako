namespace week_10;

public class Event
{
    public int Turn { get; set; }
    public string Description { get; set; }
    public string EventType { get; set; } 
    public string CharChange { get; set; }

    public Event(int turn, string description, string eventType, string charChange)
    {
        Turn = turn; Description = description; EventType = eventType; CharChange = charChange;
    }

    public override string ToString()
    {
        return $"{Turn} {Description} {EventType} {CharChange}";
    }
}