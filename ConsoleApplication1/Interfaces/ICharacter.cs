using System;

namespace ConsoleApplication1.Interfaces
{
    public interface ICharacter
    {
        IBodyPart[] body { get; set; }
        
        IWeapon[] weapons { get; set; }
        
        double getBestDamage(IMap map);
        bool isAlive();
        IBodyPart GetRandomBodyPart();
    }
}
