using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Hero: ICharacter
    {
        public readonly MeleeWeapon meleeWeapon;
        public readonly RangedWeapon rangedWeapon;
        private ICharacter heroStats;
        public double damage { get; set; }
        public double head { get; set; }
        public double chest { get; set; }
        public double stomach { get; set; }
        public double leftArm { get; set; }
        public double leftLeg { get; set; }
        public double rightArm { get; set; }
        public double rightLeg { get; set; }
    }
}