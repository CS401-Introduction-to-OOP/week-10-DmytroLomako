using System.Collections;

namespace week_10;

public class Party : IEnumerable<Character>
{
    private readonly List<Character> _characters = new();

    public void AddCharacter(Character character)
    {
        _characters.Add(character);
    }

    public IEnumerator<Character> GetEnumerator()
    {
        foreach (var character in _characters)
        {
            yield return character;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => _characters.GetEnumerator();
    
    public IEnumerable<Character> GetActiveCharacters()
    {
        foreach (var character in _characters)
        {
            if (character.State == "Active")
            {
                yield return character;
            }
        }
    }
}

public class EventLog : IEnumerable<Event>
{
    private readonly List<Event> _events = new();

    public void AddEvent(Event myEvent)
    {
        _events.Add(myEvent);
    }

    public IEnumerator<Event> GetEnumerator()
    {
        foreach (var myEvent in _events)
        {
            yield return myEvent;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => _events.GetEnumerator();
    
    public IEnumerable<Event> GetEventsWithType(string eventType)
    {
        foreach (var myEvent in _events)
        {
            if (myEvent.EventType == eventType)
            {
                yield return myEvent;
            }
        }
    }
}