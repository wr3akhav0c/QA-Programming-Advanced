using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();

        //Act
        string actual = Orders.Order(input);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "apple 2.00 3", "banana 1.25 3", "orange 1.98 1" };
        string expected = $"apple -> 6.00{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98";

        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "apple 1.64 3", "banana 1.24 3", "orange 1.98 2" };
        string expected = $"apple -> 4.92{Environment.NewLine}banana -> 3.72{Environment.NewLine}orange -> 3.96";

        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "apple 1.64 3.5", "banana 1.24 3.3", "orange 1.98 2.8" };
        string expected = $"apple -> 5.74{Environment.NewLine}banana -> 4.09{Environment.NewLine}orange -> 5.54";

        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
