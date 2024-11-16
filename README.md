# Battle-Simulation-Game

This project is a simple **battle simulation game** developed in C#. It demonstrates the concept of **inheritance** and **polymorphism** in object-oriented programming.

## Features

- **Character Classes**: Three unique character classes:
  - `Warrior`: A strong melee fighter with double damage attacks.
  - `Mage`: A spellcaster dealing heavy magic damage.
  - `Archer`: A ranged fighter with consistent damage.
- **Battle Mechanics**:
  - Turn-based combat between two characters.
  - Victory declared when one character's health reaches zero.

## Project Structure

- `Character.cs`: Base class containing common attributes and methods for all characters.
- `Warrior.cs`: Derived class with special attack mechanics.
- `Mage.cs`: Derived class with magic-based attacks.
- `Archer.cs`: Derived class with ranged attack capabilities.
- `Game.cs`: Main entry point that orchestrates the battle between characters.

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/thug77-code/Battle-Simulation-Game.git

Open the project in your preferred IDE (e.g., Visual Studio).
Run the Game.cs file to start the simulation.
