using System;

namespace GameUnits
{
    public class Program
    {
        private static void Main()
        {
            Unit[] allUnits = new Unit[]
            {
                new MilitaryUnit(3, 10, 5),
                new MilitaryUnit(3, 10, 5),
                new SettlerUnit(1, 5),
            };
            
            (allUnits[0] as MilitaryUnit)!.Attack(allUnits[1]);
            (allUnits[1] as MilitaryUnit)!.Attack(allUnits[0]);
            (allUnits[1] as MilitaryUnit)!.Attack(allUnits[2]);
            
            foreach (Unit u in allUnits)
            {
                u.Move();
            }
            
        }
    }
}