using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class VeggieBurger : Burger
    {
        public string Sauce { get; set; }

        public void prepare()
        {
            Console.WriteLine("PREPARING THE VEGGIE BURGER!!");

            Sauce = "Guaca mole";
        }
    }
}
