public class Mage : Character
{
    public Mage(string name) : base(name, 80, 30) { }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} (Mage) casts a spell on {target.Name}!");
        target.Health -= Power; // هجوم بالسحر يسبب ضررًا كبيرًا
    }
}
