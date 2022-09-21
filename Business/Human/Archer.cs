using Business.Models;
using System;

namespace Business.Human
{
    public class Archer: Human
    {
        public Stats GetHeroStats()
        {
            Value = new Stats()
            {
                Vitality = 130,
                Strength = 35,
                Defense = 30
            };
            return Value;
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine("\r\nThe special abilities of the Archer:" + "\r\n" +
                "- Excellent Aim in all ranges." + "\r\n" +
                "- Moves Fast." + "\r\n" +
                "- Can fight hand-to-hand." + "\r\n" +
                "- Reconnaissance of distant enemies." + "\r\n" +
                "- Can camouflage itself in its environment." + "\r\n" +
                "- Can track enemies." + "\r\n" +
                "\r\nThe Archer can use the following as a weapon:" + "\r\n"+
                "- Crossbow." + "\r\n" +
                "- Bow and Arrow." + "\r\n" +
                "- Short Sword.");
        }

    }
}
