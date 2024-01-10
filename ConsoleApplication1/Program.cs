using System;
using System.Collections.Generic;
using System.IO;
using ConsoleApplication1.Interfaces;
using System.Text.Json;
using System.Threading.Tasks;
using Ninject;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*string jsonFilePath = "../../data.json";

            var data = new JsonReader();

            var weapons = data.GetWeapons();
            var heroBody = data.GetBodyParts();
            var enemyBody = data.GetBodyParts();

            var hero = new Hero();
            var enemy = new Enemy();

            var map = new Map() { size = 1000, isolationDegree = 0.35};*/
            /*var game = new Game(map, hero, enemy, Console.Out);
            game.Battle();*/
            
            IKernel kernel = new StandardKernel(new ConfigModule());

            var game = kernel.Get<IGame>();
            game.Battle();
        }
    }
}