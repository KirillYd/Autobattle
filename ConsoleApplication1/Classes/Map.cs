using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Map: IMap
    {
        public double size { get; set; }
        public double isolationDegree { get; set; }
        public ICharacterFabric faric;
        public Map(ICharacterFabric fabric)
        {
            var stats = fabric.GetMapStats();
            size = stats[0];
            isolationDegree = stats[1];
        }
    }
}