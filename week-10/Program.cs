namespace week_10;

class Program
{
    static void Main(string[] args)
    {
        var character1 = new Character("Character1", "Captain", 30, 80, 10000, "Inactive");
        var character2 = new Character("Character2", "General", 100, 300, 40000, "Active");
        var character3 = new Character("Character3", "Corporal", 10, 20, 300, "Active");
        var character4 = new Character("Character4", "General", 100, 400, 24000, "Inactive");
        
        var party = new Party();
        party.AddCharacter(character1); party.AddCharacter(character2); party.AddCharacter(character3); party.AddCharacter(character4);

        var Event1 = new Event(1, "First Event", "Introduction", "100");
        var Event2 = new Event(2, "Second Event", "Battle", "-50");
        var Event3 = new Event(3, "Third Event", "Travel", "+30");
        var Event4 = new Event(4, "Fourth Event", "Battle", "-20");
        
        var eventLog = new EventLog();
        eventLog.AddEvent(Event1); eventLog.AddEvent(Event2); eventLog.AddEvent(Event3); eventLog.AddEvent(Event4);
        
        Console.WriteLine("Персонажі");
        foreach (var character in party)
        {
            Console.WriteLine(character);
        }
        
        Console.WriteLine("\nАктивні персонажі");
        foreach (var character in party.GetActiveCharacters())
        {
            Console.WriteLine(character);
        }
        
        Console.WriteLine("\nПерсонажі 20+ рівня:");
        var characters20 = party.Where(c => c.Level >= 20).ToList();
        foreach (var character in characters20)
        {
            Console.WriteLine(character);
        }
        
        Console.WriteLine("\nВсі ролі персонажів:");
        var characterRoles = party.Select(c => c.Role).ToList();
        foreach (var characterRole in characterRoles)
        {
            Console.WriteLine(characterRole);
        }
        
        Console.WriteLine("\nНайслабший персонаж:");
        Action<Party> getLeastHealthCharacter = party => Console.WriteLine(party.OrderBy(character => character.Health).First());
        getLeastHealthCharacter(party);
        
        Console.WriteLine($"\nКількість персонажів: {party.Count()}");
        
        Console.Write("\nНапишіть тип події, щоб отримати її (Introduction, Battle, Travel): ");
        string eventType = Console.ReadLine();
        foreach (var myEvent in eventLog.GetEventsWithType(eventType))
        {
            Console.WriteLine(myEvent);
        }
    }
}