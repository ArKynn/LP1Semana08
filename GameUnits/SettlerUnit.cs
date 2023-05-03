namespace GameUnits;

public class SettlerUnit : Unit
{
    public override float Cost { get; }

    public SettlerUnit(int movement, int health) : base(movement, health)
    {
        Movement = movement;
        Health = health;
        Cost = 5;
    }
}