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
        public double getDamage(IMap map=null)
        {
            return damage;
        }

        public bool isAlive()
        {
            foreach (var type in this.GetType().GetProperties())
            {
                //Console.WriteLine('1');
                if (type.PropertyType.Name == "BodyPart")
                {
                    var y = type?.GetValue(this, null).GetType().GetProperty("hp") ;
                    if ((int)y.GetValue(type.GetValue(this)) <= 0)
                        return false;
                }
            }

            return true;
        }
        
    }
}