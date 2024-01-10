using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class Map: IMap
    {
        public double size { get; set; }
        public double isolationDegree { get; set; }

        public Map()
        {
            size = 1000;
            isolationDegree = 0.8;
        }
    }
}