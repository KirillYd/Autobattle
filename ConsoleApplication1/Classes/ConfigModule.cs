using System;
using System.IO;
using System.Net;
using System.Net.Mime;
using ConsoleApplication1.Interfaces;
using Ninject;
using Ninject.Modules;

namespace ConsoleApplication1
{
    public class ConfigModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGame>().To<Game>();
            Bind<IMap>().To<Map>();
            Bind<ICharacter>().To<Hero>().Named("Hero");;
            Bind<ICharacter>().To<Enemy>().Named("Enemy");
            Bind<ICharacterFabric>().To<CharacterFabric>();
            Bind<IWeapon>().To<Weapon>();
            Bind<IBodyPart>().To<BodyPart>();
            Bind<IBullet>().To<BulletType>();
            Bind<TextWriter>().ToConstant(Console.Out);
            Bind<IDataReader>().To<JsonReader>();
        }
    }
}