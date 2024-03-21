using NimblePizza.Core;

namespace NimblePizza.Tests.Builders;

public class PizzaBuilder
{
    private string _name;
    private List<string> _toppings;
    private decimal _price;

    public PizzaBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public PizzaBuilder WithToppings(List<string> toppings)
    {
        _toppings = toppings;
        return this;
    }

    public PizzaBuilder WithPrice(decimal price)
    {
        _price = price;
        return this;
    }

    public Pizza Build()
    {
        return new Pizza
        {
            Name = _name,
            Toppings = _toppings,
            Price = _price
        };
    }
}