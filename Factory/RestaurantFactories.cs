using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BeefBurgerRestaurant : Restaurant
    {
        public override Burger createBurger()
        {
            return new BeefBurger();
        }
    }

    public class VeggieBurgerRestaurant : Restaurant
    {
        public override Burger createBurger()
        {
            return new VeggieBurger();
        }
    }
}
