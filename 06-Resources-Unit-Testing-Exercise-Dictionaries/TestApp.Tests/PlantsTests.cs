using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = { };

        //Act
        string actual = Plants.GetFastestGrowing(input);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = { "rose" };
        string expected = $"Plants with 4 letters:{Environment.NewLine}rose";

        // Act
        string actual = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = { "rose", "tulip", "poppy" };
        string expected = $"Plants with 4 letters:{Environment.NewLine}rose{Environment.NewLine}Plants with 5 letters:{Environment.NewLine}tulip{Environment.NewLine}poppy";

        // Act
        string actual = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = { "Rose", "tuLIp", "POPPY" };
        string expected = $"Plants with 4 letters:{Environment.NewLine}Rose{Environment.NewLine}Plants with 5 letters:{Environment.NewLine}tuLIp{Environment.NewLine}POPPY";

        // Act
        string actual = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
