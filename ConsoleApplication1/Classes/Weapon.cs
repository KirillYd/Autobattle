using System;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Weapon
    {
        public string name { get; set; }
        public string type { get; set; }
        public float distance { get; set; }
        public float accuracy { get; set; }
        //public float damage { get; set; }
        public float shotPerStep { get; set; }
        public BulletType bulletType { get; set; }

        public Weapon(string name, string type, float distance, float accuracy, BulletType bulletType, float shotPerStep)
        {
            this.name = name;
            this.type = type;
            this.distance = distance;
            this.accuracy = accuracy;
            //this.damage = damage;
            this.bulletType = bulletType;
            this.shotPerStep = shotPerStep;
        }
        
        public double GetAverageDamage(IMap map)
        {
            var maxOpenDist = map.size * (1 - map.isolationDegree);
            var potentialAccuracy = (distance / maxOpenDist) * accuracy / 100;
            var resultAccuracy = potentialAccuracy > 1 ? 1 : potentialAccuracy;
            return resultAccuracy * shotPerStep * bulletType.damage;
        }
    }
}