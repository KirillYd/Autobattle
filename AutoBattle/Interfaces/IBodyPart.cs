namespace ConsoleApplication1.Interfaces
{
    public interface IBodyPart
    {
        double hp { get; set; }
        double armorInfluence { get; set; }
        string partType { get; set; }

        void TakeDamage(double damage);
    }
}