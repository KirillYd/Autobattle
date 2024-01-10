using System;
using System.IO;
using ConsoleApplication1.Interfaces;
using System.Linq;
using Ninject;

namespace ConsoleApplication1
{
    public class Game: IGame
    {
        public IMap map { get; set; }
        public ICharacter hero { get; set; }
        public ICharacter enemy { get; set; }
        private readonly TextWriter writer;
        private Random rnd = new Random();

        public Game(IMap map, [Named("Hero")] ICharacter hero, [Named("Enemy")] ICharacter enemy, TextWriter writer)
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
            hero.GetRandomBodyPart(rnd).TakeDamage(enemyDamage);
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