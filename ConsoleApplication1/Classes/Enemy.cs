using System;
using System.Linq;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Enemy : ICharacter
    {
        public IBodyPart[] body { get; set; }
        public IWeapon[] weapons { get; set; }
        private ICharacterFabric fabric { get; set; }
        
        public Enemy(ICharacterFabric fabric)
        {
            weapons = fabric.CreateWeapons();
            body = fabric.CreateBody();
        }

        public double getBestDamage(IMap map)
        {
            double bestDamage = 0;
            foreach (var weapon in weapons)
            {
                if (weapon.GetAverageDamage(map) > bestDamage)
                {
                    bestDamage = weapon.GetAverageDamage(map);
                }
            }
            
            return bestDamage;
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

            return !(damagedPartCnt >= 2);
        }

        public IBodyPart GetRandomBodyPart(Random rnd)
        {
            return body.Where(x => x.hp > 0).ToArray()[rnd.Next(body.Length-1)];
        }
    }
}