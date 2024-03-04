using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();

        string result = Plants.GetFastestGrowing(input);

        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = { "cucumber" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo("Plants with 8 letters:\r\ncucumber"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = { "cucumber", "abc", "cbd", "aaaaaaaa", "aaaa", "dsds" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo("Plants with 3 letters:\r\nabc\r\ncbd\r\nPlants with 4 letters:\r\naaaa\r\ndsds\r\nPlants with 8 letters:\r\ncucumber\r\naaaaaaaa"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = { "Cucumber", "abc", "CBD", "AaaaaaaA", "aAaa", "dsds" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo("Plants with 3 letters:\r\nabc\r\nCBD\r\nPlants with 4 letters:\r\naAaa\r\ndsds\r\nPlants with 8 letters:\r\nCucumber\r\nAaaaaaaA"));
    }
}
