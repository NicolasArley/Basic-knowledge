using System;
using Business.Models;

namespace Business.Human
{
    public class CorruptedWizard: Human
    {
        public Stats GetHeroStats()
        {
            Value = new Stats()
            {
                Vitality = 50,
                Strength = 80,
                Defense = 10
            };
            return Value;
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine("\r\nThe special abilities of the Corrupted Wizard:" + "\r\n" +
                "- Cast Spells." + "\r\n" +
                "- Create different types of Potions." + "\r\n" +
                "- Manipulate resources to create different things." + "\r\n" +
                "- Can heal other persons and itself, but it comes with a price to pay." + "\r\n" +
                "- Can control the environment." + "\r\n" +
                "- Has a deep knowledge in different areas, especially in Corrupted Magic." + "\r\n" +
                "- Can Create Portals, but it doesn't always work as expected." + "\r\n" +
                "\r\nUnique ability:" + "\r\n" +
                "- Corruption: It gives to the person acces to Corrupted Magic, concealed knowledge, and makes" + "\r\n" +
                "  the person more powerful, but it reduce the Wizard's vitality and defense and make" + "\r\n" +
                "  some abbilities unestable and some can no longer be used." + "\r\n" +
                "\r\nThe Wizard can use the following as a weapon:" + "\r\n" +
                "- Staff." + "\r\n" +
                "- Own hands.");
        }

    }
}
