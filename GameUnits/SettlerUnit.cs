namespace GameUnits;

public class SettlerUnit : Unit
{
    protected sealed override float Cost { get; init; }

    public SettlerUnit(int movement, int health) : base(movement, health)
    {
        Movement = movement;
        Health = health;
        Cost = 5;
    }
}