using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act

        string result = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new int[] { 8 };

        // Act

        string result = CountRealNumbers.Count(numbers);
        string expected = "8 -> 1";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new int[] { 8, 7, 6, 6, 6, 5, 5, 1, 1, 1, 1, 1, 1 };

        // Act

        string result = CountRealNumbers.Count(numbers);
        string expected = "1 -> 6\r\n5 -> 2\r\n6 -> 3\r\n7 -> 1\r\n8 -> 1";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new int[] { -8, -7, -6, -6, -6, -5, -5, -1, -1, -1, -1, -1, -1 };

        // Act

        string result = CountRealNumbers.Count(numbers);
        string expected = "-8 -> 1\r\n-7 -> 1\r\n-6 -> 3\r\n-5 -> 2\r\n-1 -> 6";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new int[] { 0, 0, 0, 0, 0, 0 };

        // Act

        string result = CountRealNumbers.Count(numbers);
        string expected = "0 -> 6";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
