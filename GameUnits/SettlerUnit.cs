namespace GameUnits;

public class SettlerUnit : Unit
{
    protected sealed override float Cost { get; set; }

    public SettlerUnit() : base(1, 2)
    {
        Cost = 5;
    }
}