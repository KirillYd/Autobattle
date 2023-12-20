using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Hero
    {
        public readonly MeleeWeapon meleeWeapon;
        public readonly RangedWeapon rangedWeapon;
        private ICharacter heroStats;
    }
}