using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Hero : ICharacter
    {
        public BodyPart head { get; set; }
        public BodyPart chest { get; set; }
        public BodyPart stomach { get; set; }
        public BodyPart leftArm { get; set; }
        public BodyPart leftLeg { get; set; }
        public BodyPart rightArm { get; set; }
        public BodyPart rightLeg { get; set; }

        public readonly Weapon meleeWeapon;
        public readonly Weapon rangedWeapon1;
        public readonly Weapon rangedWeapon2;

        public Hero(BodyPart head, BodyPart chest, BodyPart stomach, BodyPart leftArm, BodyPart rightArm, BodyPart leftLeg, BodyPart rightLeg, Weapon meleeWeapon, Weapon rangedWeapon1, Weapon rangedWeapon2)
        {
            this.head = head;
            this.chest = chest;
            this.stomach = stomach;
            this.leftArm = leftArm;
            this.rightArm = rightArm;
            this.leftLeg = leftLeg;
            this.rightLeg = rightLeg;
            this.meleeWeapon = meleeWeapon;
            this.rangedWeapon1 = rangedWeapon1;
            this.rangedWeapon2 = rangedWeapon2;
        }
    }
}