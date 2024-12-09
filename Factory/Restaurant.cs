namespace Factory
{
    public abstract class Restaurant
    {
        public Burger OrderBurger()
        {
            Burger burger = createBurger();
            burger.prepare();
            return burger;
        }

        public abstract Burger createBurger();
    }
}
