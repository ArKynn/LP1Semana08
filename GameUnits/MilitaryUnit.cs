namespace GameUnits;

public class MilitaryUnit : Unit
{
    private int AttackPower { get; }
    private int Xp { get; set; }
    public override float Cost { get; }

    public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
    {
        AttackPower = attackPower;
        Xp = 0;
        Health += Xp;
        Cost = AttackPower + Xp;
    }

    public void Attack(Unit u)
    {
        if (u.Health == 0) return;
        else
        {
            u.Health -= AttackPower;
            if (u.Health < 0) u.Health = 0;
            
            Xp++;
        }
    }
    public override string ToString()
    {
        return $"Military Unit: HP = {Health} Cost = {Cost} Attack Power = {AttackPower} XP = {Xp}";
    }
}