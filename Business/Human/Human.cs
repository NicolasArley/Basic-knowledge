using System;
using Business.Models;

namespace Business.Human
{
    public class Human
    {
        public Stats Value { get; set; }

        public virtual void GetDescription()
        {
            Console.WriteLine("\r\nDescription of the hero" + "\r\n" +
                "..................................." + "\r\n" +
                "Basic abilities:" + "\r\n" +
                "- Intellingence: Able to think, reason, have their own criteria and develop knowledge and skills." + "\r\n" +
                "- Protect: Able to defend itself and protect others." + "\r\n" +
                "- Attack: Able to attack others and produce damage.");
        }

    }
}
