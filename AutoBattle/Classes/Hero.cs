using System;
using System.Linq;
using System.Net.Mime;
using ConsoleApplication1.Interfaces;


namespace ConsoleApplication1
{
    public class Hero : ICharacter
    {
        public IBodyPart[] body { get; set; }
        public IWeapon[] weapons { get; set; }
        private ICharacterFabric fabric { get; set; }
        private int ChoosenWeapon = 0;
        public Hero(ICharacterFabric fabric)
        {
            weapons = fabric.CreateWeapons();
            body = fabric.CreateBody();
        }

        public double GetBestDamage(IMap map)
        {
            if (ChoosenWeapon == -1)
            {
                GetBestWeapon(map);
            }
            
            return weapons[ChoosenWeapon].GetAverageDamage(map);
        }

        private void GetBestWeapon(IMap map)
        {
            double bestDamage = 0;
            foreach (var weapon in weapons)
            {
                if (weapon.GetAverageDamage(map) > bestDamage)
                {
                    bestDamage = weapon.GetAverageDamage(map);
                    ChoosenWeapon = Array.IndexOf(weapons, weapon);
                }
            }
        }

        public bool IsAlive()
        {
            var damagedPartCnt = 0;
            foreach (var bodyPart in body)
            {
                if (bodyPart.hp <= 0)
                {
                    damagedPartCnt++;
                }
            }

            return !(damagedPartCnt >= 2);
        }

        public IBodyPart GetRandomBodyPart(Random rnd)
        {
            return body.Where(x => x.hp > 0).ToArray()[rnd.Next(body.Length-1)];
        }
    }
}