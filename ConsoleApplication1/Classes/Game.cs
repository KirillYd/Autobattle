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

        public double takenDamage = 0;
        public double dealtDamage = 0;

        public Game(IMap map, [Named("Hero")] ICharacter hero, [Named("Enemy")] ICharacter enemy, TextWriter writer)
        {
            this.map = map;
            this.hero = hero;
            this.enemy = enemy;
            this.writer = writer;
        }

        public void DoNextStep(ICharacter assaulter, ICharacter defender)
        {
            var damage = assaulter.getBestDamage(map);
            defender.GetRandomBodyPart(rnd).TakeDamage(damage);
            MakeStatistics(assaulter, damage);
            
            if (!defender.isAlive())
            {
                GetStatistics();
                writer.WriteLine("\n" + defender.GetType().Name + " was defeated");
            }
            
        }

        public void MakeStatistics(ICharacter assaulter, double damage)
        {
            if (assaulter.GetType().Name == "Hero")
            {
                dealtDamage += damage;
            }
            else
            {
                takenDamage += damage;
            }
        }

        public void GetStatistics()
        {
            writer.WriteLine("Получено урона: " + takenDamage);
            writer.WriteLine("Нанесено урона: " + dealtDamage);
        }


        public void Battle()
        {
            var flag = false;
            writer.WriteLine("Игра началась");
            while(hero.isAlive() && enemy.isAlive())
            {
                if (flag)
                    DoNextStep(hero, enemy);
                else 
                    DoNextStep(enemy, hero);
                flag = !flag;
            }
        }
    }
}