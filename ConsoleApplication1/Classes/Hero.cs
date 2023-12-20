using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Hero : ICharacter
    {
        public double head { get; set; }
        public double chest { get; set; }
        public double stomach { get; set; }
        public double leftArm { get; set; }
        public double leftLeg { get; set; }
        public double rightArm { get; set; }
        public double rightLeg { get; set; }
        
        public readonly Weapon meleeWeapon;
        public readonly Weapon[] rangedWeapon;
        //private ICharacter heroStats;
    }
}