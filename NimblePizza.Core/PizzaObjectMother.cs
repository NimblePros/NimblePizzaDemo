namespace NimblePizza.Core;

public static class PizzaObjectMother
{
    public static Pizza CreatePepperoniPizza()
    {
        return new Pizza
        {
            Name = "Pepperoni Pizza",
            Toppings = new List<string> { "Pepperoni", "Cheese", "Tomato Sauce" },
            Price = 10.99m
        };
    }

    public static Pizza CreateVegetarianPizza()
    {
        return new Pizza
        {
            Name = "Vegetarian Pizza",
            Toppings = new List<string> { "Mushrooms", "Bell Peppers", "Onions", "Cheese", "Tomato Sauce" },
            Price = 9.99m
        };
    }
}