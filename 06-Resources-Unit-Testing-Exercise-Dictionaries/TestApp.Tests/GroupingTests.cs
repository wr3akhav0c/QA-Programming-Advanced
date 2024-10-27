using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> input = new List<int>();

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>{13, 2, 6, 8, 11 };
        string expected = $"Odd numbers: 13, 11{Environment.NewLine}Even numbers: 2, 6, 8";

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }
    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbersFirstEven_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { 12, 13, 2, 6, 8, 11 };
        string expected = $"Even numbers: 12, 2, 6, 8{Environment.NewLine}Odd numbers: 13, 11";

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { 12, 2, 4 };
        string expected = $"Even numbers: 12, 2, 4";

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { 17, 11, 3 };
        string expected = $"Odd numbers: 17, 11, 3";

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { -3, -1, -2, -4 };
        string expected = $"Odd numbers: -3, -1{Environment.NewLine}Even numbers: -2, -4";

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
