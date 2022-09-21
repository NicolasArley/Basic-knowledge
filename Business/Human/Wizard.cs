using Business.Models;
using System;

namespace Business.Human
{
    public class Wizard: Human
    {
        public Stats GetHeroStats()
        {
            Value = new Stats()
            {
                Vitality = 140,
                Strength = 45,
                Defense = 25
            };
            return Value;
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine("\r\nThe special abilities of the Wizard:" + "\r\n" +
                "- Cast Spells." + "\r\n" +
                "- Create different types of Potions." + "\r\n" +
                "- Manipulate resources to create different things." + "\r\n" +
                "- Can heal other persons and itself, but to some extent." + "\r\n" +
                "- Can control the environment." + "\r\n" +
                "- Has a deep knowledge in different areas, especially in Magic." + "\r\n" +
                "- Can manipulate the nature." + "\r\n" +
                "- Can Create Portals." + "\r\n" +
                "\r\nThe Wizard can use the following as a weapon:" + "\r\n" +
                "- Staff." + "\r\n" +
                "- Own hands.");
        }

    }
}
