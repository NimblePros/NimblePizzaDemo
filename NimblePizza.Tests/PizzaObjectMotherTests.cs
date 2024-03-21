namespace NimblePizza.Tests;

using NimblePizza.Core;
using Xunit;

public class PizzaObjectMotherTests
{
    [Fact]
    public void Test_PepperoniPizza()
    {
        // Arrange
        var expectedPizza = PizzaObjectMother.CreatePepperoniPizza();

        // Act
        var actualPizza = PizzaFactory.CreatePizza("Pepperoni Pizza",
                                                    new List<string> { "Pepperoni", "Cheese", "Tomato Sauce" },
                                                    10.99m);

        // Assert
        Assert.NotNull(actualPizza);
        Assert.Equal(expectedPizza.Name, actualPizza.Name);
        Assert.Equal(expectedPizza.Toppings, actualPizza.Toppings);
        Assert.Equal(expectedPizza.Price, actualPizza.Price);
    }

    [Fact]
    public void Test_VegetarianPizza()
    {
        // Arrange
        var expectedPizza = PizzaObjectMother.CreateVegetarianPizza();

        // Act
        var actualPizza = PizzaFactory.CreatePizza("Vegetarian Pizza",
                                                    new List<string> { "Mushrooms", "Bell Peppers", "Onions", "Cheese", "Tomato Sauce" },
                                                    9.99m);

        // Assert
        Assert.NotNull(actualPizza);
        Assert.Equal(expectedPizza.Name, actualPizza.Name);
        Assert.Equal(expectedPizza.Toppings, actualPizza.Toppings);
        Assert.Equal(expectedPizza.Price, actualPizza.Price);
    }
}