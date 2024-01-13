using System;

namespace ConsoleApplication1.Interfaces
{
    public interface ICharacterFabric
    {
        IWeapon[] CreateWeapons();
        IBodyPart[] CreateBody();
        double[] GetMapStats();
    }
}