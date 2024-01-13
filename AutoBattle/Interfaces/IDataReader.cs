using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Interfaces
{
    public interface IDataReader
    {
        Dictionary<string, Dictionary<string, object>> Data { get; }

        IBodyPart[] GetBodyParts();
        IWeapon[] GetWeapons();
        double[] GetMapStats();
    }
}