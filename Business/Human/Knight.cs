using Business.Models;
using System;

namespace Business.Human
{
    public class Knight : Human
    {
        public Stats GetHeroStats()
        {
            Value = new Stats()
            {
                Vitality = 115,
                Strength = 40,
                Defense = 35
            };
            return Value;
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine("\r\nThe special abilities of the Knight:" + "\r\n" +
                "- Great physical strength." + "\r\n" +
                "- Moves Super Fast for a short time." + "\r\n" +
                "- Can use different fighting styles." + "\r\n" +
                "- Can fight hand-to-hand." + "\r\n" +
                "- Can fight for a long time." + "\r\n" +
                "- Can use magic melee weapons." + "\r\n" +
                "- Can use full armor and different types." + "\r\n" +
                "\r\nThe Knight can use the following as a weapon:" + "\r\n" +
                "- All kind of Melee Weapons (Pointed weapons, Edged weapons and Blunt weapons)." + "\r\n" +
                "- All kind of Shields." + "\r\n" +
                "- Own hands.");
        }

    }
}
