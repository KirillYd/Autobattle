namespace ConsoleApplication1
{
    public class BodyPart
    {
        public double hp { get; set; }
        public double armorInfluence { get; set; }
        public string partType { get; set; }
        
        public BodyPart(double hp, double armorInfluence, string partType)
        {
            this.hp = hp;
            this.armorInfluence = armorInfluence;
            this.partType = partType;
        }
        
        public void TakeDamage(double damage)
        {
            hp -= damage + armorInfluence;
        }
    }
}