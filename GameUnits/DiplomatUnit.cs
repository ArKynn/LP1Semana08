namespace GameUnits;

public class DiplomatUnit : XPUnit
{
    protected sealed override float Cost { get; init; }

    public DiplomatUnit(int movement, int health) : base(movement, health)
    {
        Cost = 7.1f;
        Movement = 6;
        Health = 1;
    }

    public void MakeAgreement(Unit unit)
    {
        if (unit is DiplomatUnit)
        {
            XP += 3;
        }
        else if (unit is SettlerUnit)
        {
            XP += 2;
        }
        else
        {
            XP++;
        }
    }
}