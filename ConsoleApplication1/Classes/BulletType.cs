namespace ConsoleApplication1
{
    public class BulletType
    {
        public string bulletType { get; set; }
        public float accuracy { get; set; }

        public float damage { get; set; }
        //public float recoil { get; set; }

        public BulletType(string bulletType, float accuracy, float damage)
        {
            this.bulletType = bulletType;
            this.accuracy = accuracy;
            this.damage = damage;
        }
    }
}