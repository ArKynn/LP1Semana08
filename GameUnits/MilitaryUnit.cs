namespace GameUnits;

public class MilitaryUnit : XPUnit
{
    private int AttackPower { get; }
    protected sealed override float Cost { get; set; }

    public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
    {
        AttackPower = attackPower;
        Cost = AttackPower;
    }

    public void Attack(Unit u)
    {
        if (u.Health == 0) return;
        else
        {
            u.Health -= AttackPower;
            if (u.Health < 0) u.Health = 0;
            
            XP++;
            Cost++;
            Health++;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $" AP : {AttackPower}";
    }
}