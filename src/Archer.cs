public class Archer : Character
{
    public Archer(string name) : base(name, 100, 15) { }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} (Archer) shoots an arrow at {target.Name}!");
        target.Health -= Power;
    }
}
