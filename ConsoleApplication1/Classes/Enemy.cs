using System;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Enemy : ICharacter
    {
        private double damage { get; set; }
        public BodyPart[] body { get; set; }

        public double getDamage(IMap map=null)
        {
            return damage;
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

        public Enemy(BodyPart[] body)
        {
            this.body = body;
        }
        
    }
}