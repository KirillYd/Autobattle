using System;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Hero : ICharacter
    {
        /*public BodyPart head { get; set; }
        public BodyPart chest { get; set; }
        public BodyPart stomach { get; set; }
        
        public BodyPart leftArm { get; set; }
        public BodyPart leftLeg { get; set; }
        public BodyPart rightArm { get; set; }
        public BodyPart rightLeg { get; set; }*/


        public BodyPart[] body { get; set; }
        public Weapon meleeWeapon { get ; set; }
        public  Weapon rangedWeapon1 { get; set; }
        public  Weapon rangedWeapon2 { get; set; }
        
        public Hero(BodyPart[] body, Weapon meleeWeapon, Weapon rangedWeapon1, Weapon rangedWeapon2)
        {
            this.body = body;
            this.meleeWeapon = meleeWeapon;
            this.rangedWeapon1 = rangedWeapon1;
            this.rangedWeapon2 = rangedWeapon2;
        }

        public double getDamage(IMap map)
        {
            return rangedWeapon1.GetAverageDamage(map);
        }

        public bool isAlive()
        {
            var damagedPartCnt = 0;
            foreach (var bodyPart in body)
            {
                if (bodyPart.hp <= 0)
                {
                    damagedPartCnt++;
                }
            }

            return damagedPartCnt >= 2;
        }

        public BodyPart GetRandomBodyPart()
        {
            var rnd = new Random();
            return body[rnd.Next(body.Length)];
        }
        
        
        
    }
}