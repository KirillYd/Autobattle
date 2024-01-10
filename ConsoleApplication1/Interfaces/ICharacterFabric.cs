using System;

namespace ConsoleApplication1.Interfaces
{
    public interface ICharacterFabric
    {
        IWeapon[] CreateWeapons();
        IBodyPart[] CreateBody();
        Tuple<double, double> GetMapStats();
    }
}