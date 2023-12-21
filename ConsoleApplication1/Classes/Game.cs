using System;
using System.IO;
using ConsoleApplication1.Interfaces;
using System.Linq;

namespace ConsoleApplication1
{
    public class Game
    {
        public IMap map;
        public ICharacter hero;
        public ICharacter enemy;
        public readonly TextWriter writer;
        private Random rnd = new Random();

        public Game(IMap map, ICharacter hero, ICharacter enemy, TextWriter writer)
        {
            this.map = map;
            this.hero = hero;
            this.enemy = enemy;
            this.writer = writer;
        }

        public void DoNextStep()
        {
            var heroDamage = hero.getBestDamage(map);
            var enemyDamage = enemy.getBestDamage(map);
            var part = hero.GetRandomBodyPart(rnd);
            part.TakeDamage(enemyDamage);
            writer.WriteLine(part.partType);
            enemy.GetRandomBodyPart(rnd).TakeDamage(heroDamage);
        }

        public void Battle()
        {
            writer.WriteLine("Игра началась");
            while(hero.isAlive() && enemy.isAlive())
            {
                DoNextStep();
            }   
            writer.WriteLine("game over");
        }
    }
}