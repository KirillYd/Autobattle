namespace ConsoleApplication1
{
    public class BodyPart
    {
        private float hp { get; set; }
        private float armorInfluence { get; set; }

        public BodyPart(float hp, float armorInfluence)
        {
            this.hp = hp;
            this.armorInfluence = armorInfluence;
        }
    }
}