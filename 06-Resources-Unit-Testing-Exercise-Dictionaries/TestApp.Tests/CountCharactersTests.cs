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
        List<string> input = new() { "", "" };

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string> () { "a" };
        string expected = "a -> 1";

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "test", "za", "l" };
        string expected = $"t -> 2{Environment.NewLine}e -> 1{Environment.NewLine}s -> 1{Environment.NewLine}z -> 1{Environment.NewLine}a -> 1{Environment.NewLine}l -> 1";

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "testtesttest!@#" };

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo($"t -> 6{Environment.NewLine}e -> 3{Environment.NewLine}s -> 3{Environment.NewLine}! -> 1{Environment.NewLine}@ -> 1{Environment.NewLine}# -> 1"));
    }
}
