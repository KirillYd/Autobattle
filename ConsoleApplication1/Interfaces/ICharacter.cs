using System;

namespace ConsoleApplication1.Interfaces
{
    public interface ICharacter
    {
        IBodyPart[] body { get; set; }
        
        IWeapon[] weapons { get; set; }
        
        double GetBestDamage(IMap map);
        bool IsAlive();
        IBodyPart GetRandomBodyPart(Random rnd);
    }
}
