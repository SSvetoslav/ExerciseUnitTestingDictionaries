using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new List<string>() { "", "", "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "a" };

        // Act
        string actualResult = CountCharacters.Count(input);

        string expectedResult = "a -> 1";
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "abcaaaaa", "ttrrttt", "bbbbbb", "gfggfa", "qpioh", "asvbr", "asdfg" };

        // Act
        string actualResult = CountCharacters.Count(input);

        string expectedResult = "a -> 9\r\nb -> 8\r\nc -> 1\r\nt -> 5\r\nr -> 3\r\ng -> 4\r\nf -> 3\r\nq -> 1\r\np -> 1\r\ni -> 1\r\no -> 1\r\nh -> 1\r\ns -> 2\r\nv -> 1\r\nd -> 1";
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "aaa$%^&", "adgag^&", "6875gm,", "AAA" };

        // Act
        string actualResult = CountCharacters.Count(input);

        string expectedResult = "a -> 5\r\n$ -> 1\r\n% -> 1\r\n^ -> 2\r\n& -> 2\r\nd -> 1\r\ng -> 3\r\n6 -> 1\r\n8 -> 1\r\n7 -> 1\r\n5 -> 1\r\nm -> 1\r\n, -> 1\r\nA -> 3";
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
