using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Human
{
    public class Assassin : Human
    {

        public Skills GetProperties()
        {
            Skills skills = new Skills
            {
                Vitality = 125,
                Strength = 40,
                Defense = 30
            };
            return skills;
        }

        public void Stealth()
        {
            Console.WriteLine("");
        }

        public void Throwingweapons()
        {
            Console.WriteLine("");
        }

        public void Poisonmanagement()
        {
            Console.WriteLine("");
        }
    }
}
