

using Factory;

Restaurant Vrestaurant = new VeggieBurgerRestaurant();
var Vburger = Vrestaurant.OrderBurger();

Restaurant Brestaurant = new BeefBurgerRestaurant();
var Bburger = Brestaurant.OrderBurger();

Console.WriteLine(Vburger.GetType());
Console.WriteLine(Bburger.GetType());