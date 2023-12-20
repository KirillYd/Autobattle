using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Enemy : ICharacter
    {
        public BodyPart head { get; set; }
        public BodyPart chest { get; set; }
        public BodyPart stomach { get; set; }
        public BodyPart leftArm { get; set; }
        public BodyPart leftLeg { get; set; }
        public BodyPart rightArm { get; set; }
        public BodyPart rightLeg { get; set; }

        private double damage { get; set; }
    }
}