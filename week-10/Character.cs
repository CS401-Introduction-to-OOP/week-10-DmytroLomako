namespace week_10;

public class Character
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int Gold { get; set; }
    public string State { get; set; }

    public Character(string name, string role, int level, int health, int gold, string state)
    {
        Name = name; Role = role; Level = level; Health = health; Gold = gold; State = state;
    }
}