namespace GameUnits;

public class MilitaryUnit : XPUnit
{
    private int AttackPower { get; }
    protected sealed override float Cost { get; init; }

    public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
    {
        AttackPower = attackPower;
        Health += XP;
        Cost = AttackPower + XP;
    }

    public void Attack(Unit u)
    {
        if (u.Health == 0) return;
        else
        {
            u.Health -= AttackPower;
            if (u.Health < 0) u.Health = 0;
            
            XP++;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $" AP : {AttackPower}";
    }
}