using System;
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
        public double getDamage(IMap map)
        {
            return rangedWeapon1.GetAverageDamage(map);
        }

        public bool isAlive()
        {
            foreach (var type in this.GetType().GetProperties())
            {
                //Console.WriteLine('1');
                if (type.PropertyType.Name == "BodyPart")
                {
                    var y = type?.GetValue(this, null).GetType().GetProperty("hp");
                    if (Convert.ToInt32(y.GetValue(type.GetValue(this))) <= 0)
                        return false;
                }
            }

            return true;
        }


        public Weapon meleeWeapon { get ; set; }
        public  Weapon rangedWeapon1 { get; set; }
        public  Weapon rangedWeapon2 { get; set; }
        

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