using System;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Game
    {
        public IMap map;
        public ICharacter hero;
        public ICharacter enemy;

        public Game(IMap map, ICharacter hero, ICharacter enemy)
        {
            this.map = map;
            this.hero = hero;
            this.enemy = enemy;
        }
        

        public void DoNextStep()
        {
            var damage = hero.getDamage(map);
            enemy.head.TakeDamage(damage);
            Console.WriteLine(enemy.head.hp);
        }

        public void Battle()
        {
            while(hero.isAlive() && enemy.isAlive())
            {
                DoNextStep();
            }   
            Console.WriteLine("game over");
        }
    }
}