namespace ConsoleApplication1.Interfaces
{
    public interface IBullet
    {
        string bulletType { get; set; }
        float accuracy { get; set; }

        float damage { get; set; }
    }
}