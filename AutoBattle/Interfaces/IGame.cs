using System;
using System.IO;

namespace ConsoleApplication1.Interfaces
{
    public interface IGame
    {
        IMap map { get; set; }
        ICharacter hero { get; set; }
        ICharacter enemy { get; set; }

        void DoNextStep(ICharacter assaulter, ICharacter defender);

        void Battle();
    }
}