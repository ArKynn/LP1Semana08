namespace GameUnits;

public class SettlerUnit : Unit
{
    public override float Cost { get; }

    public SettlerUnit(int movement, int health) : base(movement, health)
    {
        Movement = 1;
        Health = 2;
        Cost = 5;
    }
}