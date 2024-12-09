using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BeefBurger : Burger
    {
        public string Sauce { get; set; }

        public void prepare()
        {
            Console.WriteLine("PREPARING THE BEEF BURGER...");

            Sauce = "Mayo";
        }
    }
}
