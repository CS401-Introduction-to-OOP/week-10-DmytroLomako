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