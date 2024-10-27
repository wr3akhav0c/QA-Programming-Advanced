using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();

        //Act
        string actual = OddOccurrences.FindOdd(input);

        //Assert
        Assert.That(actual, Is.Empty);

    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] {"hlqb", "hlqb"};

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.Empty);

    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = { "meso" };
        string expected = "meso";
        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = { "test", "test", "hlqb", "kostenurka", "hlqb", "meso", "tigar", "tigar", "tigar", ""};
        string expected = "kostenurka meso tigar";
        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "Test", "KOStenurka", "Test", "hlqb", "hlqb", "meso", "TIGAR", "TIGAR", "TIGAR" };
        string expected = "kostenurka meso tigar";
        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
