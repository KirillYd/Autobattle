using System;
using ConsoleApplication1.Interfaces;
using System.Linq;

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

        public void GetRandomBodyPart(double damage, ICharacter person)
        {
            var part_list = person.GetType().GetProperties()
                .Where(type => type.PropertyType.Name == "BodyPart")
                .Select(type => type.Name).ToArray().ToArray();;
            Console.WriteLine(part_list[0]);
            var rnd = new Random();
            var rndPart = part_list[rnd.Next(part_list.Count())];
            Console.WriteLine(rndPart);
            foreach (var part in part_list)
            {
                if (part == rndPart)
                {
                    //person
                }
            }

           // person.GetType().GetProperty(rndPart);
            
            //person.head.TakeDamage(damage);
        }
        


        public void DoNextStep()
        {
            var damage = hero.getDamage(map);
            enemy.head.TakeDamage(damage);
            Console.WriteLine("Осталось HP:"+ enemy.head.hp);
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