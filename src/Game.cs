Character player = new Warrior("Player Warrior");
Character enemy = new Mage("Enemy Mage");

// المعركة
while (player.Health > 0 && enemy.Health > 0)
{
    player.Attack(enemy);
    if (enemy.Health <= 0)
    {
        Console.WriteLine($"{enemy.Name} has been defeated!");
        break;
    }

    enemy.Attack(player);
    if (player.Health <= 0)
    {
        Console.WriteLine($"{player.Name} has been defeated!");
        break;
    }
}