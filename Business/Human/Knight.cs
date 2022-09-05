using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Human
{
    public class Knight : Human
    {

        public Skills GetProperties()
        {
            Skills skills = new Skills
            {
                Vitality = 115,
                Strength = 40,
                Defense = 40
            };
            return skills;
        }
        public void Fightingstyles()
        {
            Console.WriteLine("");
        }

        public void Meleeweapons()
        {
            Console.WriteLine("");
        }
    }
}
