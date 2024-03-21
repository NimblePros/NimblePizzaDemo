namespace NimblePizza.Tests;

using Xunit;
using Bogus;
using NimblePizza.Core;

public class PizzaTests
{
    private readonly Faker _faker;

    public PizzaTests()
    {
        _faker = new Faker();
    }

    [Fact]
    public void Test_CreatePizza()
    {
        // Arrange
        var pizzaName = _faker.Commerce.ProductName();
        var toppings = _faker.Random.WordsArray(3).ToList();
        var price = _faker.Finance.Amount();

        // Act
        var pizza = PizzaFactory.CreatePizza(pizzaName, toppings, price);

        // Assert
        Assert.NotNull(pizza);
        Assert.Equal(pizzaName, pizza.Name);
        Assert.Equal(toppings, pizza.Toppings);
        Assert.Equal(price, pizza.Price);
    }
}