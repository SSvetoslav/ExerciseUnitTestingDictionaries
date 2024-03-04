using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrage
        string[] input = Array.Empty<string>();

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.Empty);

    }

    // TODO: finish test
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "gold 8", "silver 30", "Gold 1", "SILVER 1"};

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 9{Environment.NewLine}silver -> 31"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrage
        string[] input = { "gold 155", "silver 10", "copper 17", "Silver 20", "Bronze 123", "Bronze 1" };

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 155\r\nsilver -> 30\r\ncopper -> 17\r\nbronze -> 124"));
    }
}
