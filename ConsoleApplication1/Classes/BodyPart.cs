namespace ConsoleApplication1
{
    public class BodyPart
    {
        public double hp { get; set; }
        public double armorInfluence { get; set; }

        public void TakeDamage(double damage)
        {
            hp -= damage;
        }

        public BodyPart(float hp, float armorInfluence)
        {
            this.hp = hp;
            this.armorInfluence = armorInfluence;
        }
    }
}