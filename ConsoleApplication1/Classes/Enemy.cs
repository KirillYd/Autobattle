using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Enemy : ICharacter
    {
        public double head { get; set; }
        public double chest { get; set; }
        public double stomach { get; set; }
        public double leftArm { get; set; }
        public double leftLeg { get; set; }
        public double rightArm { get; set; }
        public double rightLeg { get; set; }

        private double damage { get; set; }
        //private ICharacter enemyStats;
    }
}