using System.ComponentModel.Design;

namespace GameUnits;

public abstract class Unit
{
    protected int Movement;
    public int Health { get; set; }
    public abstract float  Cost { get; }

    protected Unit(int movement, int health)
    {
        Movement = movement;
        Health = health;
    }

    public void Move()
    {
        Console.WriteLine($"This unit moved {Movement} times.");
    }
    public override string ToString()
    {
        return $"Settler Unit: HP = {Health} Cost = {Cost}";
    }
}

