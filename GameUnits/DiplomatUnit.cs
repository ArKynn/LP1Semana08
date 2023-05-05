namespace GameUnits;

public class DiplomatUnit : XPUnit
{
    protected sealed override float Cost { get; set; }

    public DiplomatUnit() : base(6, 1)
    {
        Cost = 7.1f;
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