using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> list = new List<int>();
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>() { 2, 3, 4, 5 };

        // Act
        string result = Grouping.GroupNumbers(list);
        string expected = "Even numbers: 2, 4\r\nOdd numbers: 3, 5\r\n";

        // Assert
        Assert.That(result, Is.EqualTo(expected.ToString().Trim()));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>() { 2, 4, 6, 8 };

        // Act
        string result = Grouping.GroupNumbers(list);
        string expected = "Even numbers: 2, 4, 6, 8\r\n";

        // Assert
        Assert.That(result, Is.EqualTo(expected.ToString().Trim()));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>() { 1, 3, 5, 7 };

        // Act
        string result = Grouping.GroupNumbers(list);
        string expected = "Odd numbers: 1, 3, 5, 7\r\n";

        // Assert
        Assert.That(result, Is.EqualTo(expected.ToString().Trim()));
    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new List<int>() { -1, -3, -5, -7, -8, -2 };

        // Act
        string result = Grouping.GroupNumbers(list);
        string expected = "Odd numbers: -1, -3, -5, -7\r\nEven numbers: -8, -2";

        // Assert
        Assert.That(result, Is.EqualTo(expected.ToString().Trim()));
    }
}
