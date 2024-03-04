using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = { "yes", "yes", "no", "no" };
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = { "yes", "yes", "yes"};
        // Act
        string result = OddOccurrences.FindOdd(input);
        string expected = "yes";
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord2()
    {
        // Arrange
        string[] input = { "yes" };
        // Act
        string result = OddOccurrences.FindOdd(input);
        string expected = "yes";
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = { "yes", "yes", "yes", "no", "pet", "da", "da" };
        // Act
        string result = OddOccurrences.FindOdd(input);
        string expected = "yes no pet";
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "yES", "YES", "Yes", "No", "Pet", "DA", "da", "Car", "car", "caR", "T", "t", "123", "123", "123"  };
        // Act
        string result = OddOccurrences.FindOdd(input);
        string expected = "yes no pet car 123";
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
