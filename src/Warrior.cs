public class Warrior : Character
{
    public Warrior(string name) : base(name, 150, 20) { }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} (Warrior) uses a powerful attack on {target.Name}!");
        target.Health -= Power * 2; // هجوم المحارب يكون أقوى
    }
}
