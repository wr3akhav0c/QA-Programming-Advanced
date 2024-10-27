using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();

        //Act
        string actual = Miner.Mine(input);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "gold 6", "Silver 6", "GOLD 2", "SILVER 24" };

        // Act
        string actual = Miner.Mine(input);

        // Assert
        Assert.That(actual, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = { "gold 2", "silver 2", "gold 1", "silver 2" };

        // Act
        string actual = Miner.Mine(input);

        // Assert
        Assert.That(actual, Is.EqualTo($"gold -> 3{Environment.NewLine}silver -> 4"));
    }
}
