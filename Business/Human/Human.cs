using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models;

namespace Business.Human
{
    /*
     * Se busca que de la clase 'Human' tenga 'habilidades basicas' y un metodo que muestre las estadisticas
     * de la clase, y que esto sea heredado por las demas clases y que el apartado de las estadisticas muestre
     * las estadisticas correspondientes a la clase elegida.
     * 
     * Y que la clase 'CorruptedWizard' que hereda de la clase 'Wizard' pueda modificar las estidisticas con 
     * el uso de la interfaz 'ICorruption' y que se muestre lo heredado de 'Wizard', lo que no sea modificado.
     * 
     * Y todo pueda ser mostrado en un switch, en donde se de a elegir la clase (heroe) que el usuario desee
     * elegir, y una vez una clase haya sido elegida solo se mostrara las caracteristicas y estadisticas que
     * que corresponden a esa clase (heroe).
     */
    public class Human
    {


        public void Intelligence()
        {
            Console.WriteLine("Able to think, reason, have their own criteria and develop knowledge and skills");
        }

        public void Protect()
        {
            Console.WriteLine("Able to defend itself and protect others");
        }

        public void Attack()
        {
            Console.WriteLine("Able to attack others and produce damage");
        }

        public void GetStats()
        {
            Skills skills = new Skills
            {
                Vitality = 100,
                Strength = 10,
                Defense = 10
            };

            Console.WriteLine("The stats:");
            Console.WriteLine("---------------");
            Console.WriteLine("Vitality: " + skills.Vitality);
            Console.WriteLine("Strength: " + skills.Strength);
            Console.WriteLine("Defense: " + skills.Defense);
        }

    }
}
