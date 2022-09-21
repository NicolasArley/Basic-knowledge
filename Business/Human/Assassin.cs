using Business.Models;
using System;

namespace Business.Human
{
    public class Assassin : Human
    {
        public Stats GetHeroStats()
        {
            Value = new Stats()
            {
                Vitality = 125,
                Strength = 35,
                Defense = 25
            };
            return Value;
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine("\r\nThe special abilities of the Assassin:" + "\r\n" +
                "- Good Aim in near ranges." + "\r\n" +
                "- Moves Agile and Silent." + "\r\n" +
                "- Can throw Knifes." + "\r\n" +
                "- Can fight hand-to-hand." + "\r\n" +
                "- Can camouflage itself in its environment." + "\r\n" +
                "- Can use poisons and implement it in weapons." + "\r\n" +
                "\r\nThe Assassin can use the following as a weapon:" + "\r\n" +
                "- All kind of Knifes." + "\r\n" +
                "- Short Blowgun." + "\r\n" +
                "- Knuckles.");
        }

    }
}
