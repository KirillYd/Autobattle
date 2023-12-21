﻿using System;
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
            hero.GetRandomBodyPart().TakeDamage(enemyDamage);
            enemy.GetRandomBodyPart().TakeDamage(heroDamage);
        }

        public void Battle()
        {
            while(hero.isAlive() && enemy.isAlive())
            {
                DoNextStep();
            }   
            writer.WriteLine("game over");
        }
    }
}