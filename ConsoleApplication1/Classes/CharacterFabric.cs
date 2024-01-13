using System;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class CharacterFabric: ICharacterFabric
    {
        private IDataReader dataReader;
        public CharacterFabric(IDataReader dataReader)
        {
            this.dataReader = dataReader;
        }
        public IWeapon[] CreateWeapons()
        {
            return dataReader.GetWeapons();
        }

        public IBodyPart[] CreateBody()
        {
            return dataReader.GetBodyParts();
        }

        public double[] GetMapStats()
        {
            return dataReader.GetMapStats();
        }
    }
}