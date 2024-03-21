namespace NimblePizza.Core;
public class PizzaFactory
{
    public static Pizza CreatePizza(string name, List<string> toppings, decimal price)
    {
        return new Pizza
        {
            Name = name,
            Toppings = toppings,
            Price = price
        };
    }
}
