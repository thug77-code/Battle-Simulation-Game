public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Power { get; set; }

    public Character(string name, int health, int power)
    {
        Name = name;
        Health = health;
        Power = power;
    }

    public virtual void Attack(Character target)
    {
        // هجوم أساسي ينقص من صحة الخصم بمقدار القوة
        Console.WriteLine($"{Name} attacks {target.Name} causing {Power} damage!");
        target.Health -= Power;
    }

    public virtual void Defend()
    {
        // دفاع أساسي
        Console.WriteLine($"{Name} defends!");
    }
}
