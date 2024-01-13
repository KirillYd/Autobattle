using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;
using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    public class JsonReader: IDataReader
    {
        private readonly string FilePath = "../../data.json";
        public Dictionary<string, Dictionary<string, object>> Data { get; }

        public JsonReader()
        {
            string jsonContent = File.ReadAllText(FilePath);
            Data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, object>>>(jsonContent);
        }

        public IBodyPart[] GetBodyParts()
        {
            List<IBodyPart> body = new List<IBodyPart>();

            foreach (var part in Data["body"])
            {
                var bodyPartProperties = JsonSerializer.Deserialize<Dictionary<string, object>>(part.Value.ToString());
                double hp = double.Parse(bodyPartProperties["hp"].ToString());
                double armorInfluence = double.Parse(bodyPartProperties["armorInfluence"].ToString());
                string type = part.Key;
                BodyPart bodyPart = new BodyPart(hp, armorInfluence, type);
                body.Add(bodyPart);
            }

            return body.ToArray();
        }

        public IWeapon[] GetWeapons()
        {
            List<IWeapon> weapons = new List<IWeapon>();
            
            foreach (var weaponData in Data["weapons"])
            {
                var weaponProperties = JsonSerializer.Deserialize<Dictionary<string, object>>(weaponData.Value.ToString());

                string name = weaponProperties["name"].ToString();
                string type = weaponProperties["type"].ToString();
                float distance = float.Parse(weaponProperties["distance"].ToString());
                float accuracy = float.Parse(weaponProperties["accuracy"].ToString());
                float shotPerStep = float.Parse(weaponProperties["shotPerStep"].ToString());
                IBullet bullet = GetBullet(type);

                Weapon weapon = new Weapon(name, type, distance, accuracy, bullet, shotPerStep);
                weapons.Add(weapon);
            }

            return weapons.ToArray();
        }

        private IBullet GetBullet(string type)
        {
            var bulletData = Data["bullets"][type];
            var bulletProperties = JsonSerializer.Deserialize<BulletType>(bulletData.ToString());

            return new BulletType(bulletProperties.bulletType, bulletProperties.accuracy, bulletProperties.damage);
        }

        public double[] GetMapStats()
        {
            var size = double.Parse(Data["map"]["size"].ToString());
            var isolationDegree = Convert.ToDouble(Data["map"]["isolationDegree"].ToString(), CultureInfo.InvariantCulture);
            return new double[] {size, isolationDegree};
        }

    }
}