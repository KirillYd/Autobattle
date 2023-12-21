using System;
using System.Net.Mime;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Weapon: IWeapon
    {
        public string name { get; set; }
        public string type { get; set; }
        public float distance { get; set; }
        public float accuracy { get; set; }
        public float shotPerStep { get; set; }
        public IBullet bulletType { get; set; }
        private Random rnd = new Random();

        public Weapon(string name, string type, float distance, float accuracy, IBullet bulletType, float shotPerStep)
        {
            this.name = name;
            this.type = type;
            this.distance = distance;
            this.accuracy = accuracy;
            this.bulletType = bulletType;
            this.shotPerStep = shotPerStep;
        }
        
        public double GetAverageDamage(IMap map)
        {
            double resultDamage = 0;
            double resultAccuracy = GetAccuracy(map);
            for (int i = 0; i < shotPerStep; i++)
            {
                if (rnd.Next(0, 100) < resultAccuracy)
                {
                    resultDamage += bulletType.damage;
                }
            }
            
            return resultDamage;
        }

        private double GetAccuracy(IMap map)
        {
            var maxOpenDist = map.size * (1 - map.isolationDegree);
            var potentialAccuracy = (distance / maxOpenDist) * accuracy;
            return potentialAccuracy > 100 ? 100 : potentialAccuracy;
        }
    }
}