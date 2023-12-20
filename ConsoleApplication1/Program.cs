namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var body = new BodyPart(100, 0.0f);
            var bullet = new BulletType("762", '0', 50);
            var weapon = new Weapon("ак", "1", 100, 50, bullet, 3);
            var map = new Map(){size = 1000, isolationDegree = 0.8};
            var hero = new Hero(body, body, body, body, body, body, body, weapon, weapon, weapon);
            var game = new Game(map, hero,hero);
            game.Battle();
            //game.GetRandomBodyPart(50.0, game.hero);
        }
    }
}