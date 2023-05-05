namespace GameUnits;

public class SettlerUnit : Unit
{
    protected sealed override float Cost { get; init; }

    public SettlerUnit() : base(1, 2)
    {
        Cost = 5;
    }
}