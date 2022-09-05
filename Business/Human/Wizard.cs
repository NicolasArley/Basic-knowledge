using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Human
{
    public class Wizard: Human
    {
        public Skills GetProperties()
        {
            Skills skills = new Skills
            {
                Vitality = 140,
                Strength = 45,
                Defense = 25
            };
            return skills;
        }

        public void Magic()
        {
            Console.WriteLine("");
        }

        public void DeepKnowledge()
        {
            Console.WriteLine("");
        }

        public void Potions()
        {
            Console.WriteLine("");
        }

    }
}
