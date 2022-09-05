using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Human
{
    public class Archer: Human
    {
        public Skills GetProperties()
        {
            Skills skills = new Skills
            {
                Vitality = 130,
                Strength = 35,
                Defense = 30
            };
            return skills;
        }

        public void Projectionweapons()
        {
            Console.WriteLine("Ballesta\r\nProyectiles de aire comprimido\r\nArco y flecha");
        }

        public void Excelentaim()
        {
            Console.WriteLine("");
        }

    }
}
