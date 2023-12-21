namespace ConsoleApplication1.Interfaces
{
    public interface IWeapon
    {
        string name { get; set; }
        string type { get; set; }
        float distance { get; set; }
        float accuracy { get; set; }
        float shotPerStep { get; set; }
        IBullet bulletType { get; set; }

        double GetAverageDamage(IMap map);
    }
}