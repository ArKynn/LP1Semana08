using System.ComponentModel.Design;

namespace GameUnits;

public abstract class Unit
{
    private int movement;
    public virtual int Health { get; set; }
    public abstract float  Cost { get; }

    public Unit(int movement)
    {
        this.movement = movement;
    }

    public void Move()
    {
        Console.WriteLine($"This unit moved {movement} times.");
    }
}