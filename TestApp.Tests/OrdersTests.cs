using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();

        string result = Orders.Order(input);

        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "apple 3 1.99", "banana 3 1.25", "orange 2 0.99" };
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "apple 300 2", "banana 500 3", "orange 100 2" };
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 600.00{Environment.NewLine}banana -> 1500.00{Environment.NewLine}orange -> 200.00"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "apple 3 1.98", "banana 3 1.24", "orange 2 0.98" };
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.94{Environment.NewLine}banana -> 3.72{Environment.NewLine}orange -> 1.96"));
    }
}
