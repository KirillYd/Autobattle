using System;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class CharacterFabric: ICharacterFabric
    {
        public IWeapon[] CreateWeapons()
        {
            return new JsonReader().GetWeapons();
        }

        public IBodyPart[] CreateBody()
        {
            return new JsonReader().GetBodyParts();
        }
    }
}