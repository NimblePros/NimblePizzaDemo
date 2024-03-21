namespace NimblePizza.Tests;

using NimblePizza.Core;
using NimblePizza.Tests.Builders;

public class PizzaBuilderTests
{
    [Fact]
    public void ActualPizzaShouldMatchBuilderPizza()
    {
        // Arrange
        var expectedPizza = new PizzaBuilder()
            .WithDefaultValues()
            .WithName("Pepperoni Pizza")
            .WithToppings(new List<string> { "Pepperoni", "Mushrooms", "Extra Cheese" })
            .WithPrice(12.99m)
            .Build();

        // Act
        var actualPizza = PizzaFactory.CreatePizza("Pepperoni Pizza",
                                                    new List<string> { "Pepperoni", "Mushrooms", "Extra Cheese" },
                                                    12.99m);

        // Assert
        Assert.NotNull(actualPizza);
        Assert.Equal(expectedPizza.Name, actualPizza.Name);
        Assert.Equal(expectedPizza.Toppings, actualPizza.Toppings);
        Assert.Equal(expectedPizza.Price, actualPizza.Price);
    }
}