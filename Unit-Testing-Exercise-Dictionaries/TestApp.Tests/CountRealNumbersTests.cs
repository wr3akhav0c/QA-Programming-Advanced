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
        string actual = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new int[] { 4 };
        string expected = "4 -> 1";

        // Act
        string actual = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new int[] { 4, 8, 1, 8, 13 };
        string expected = $"1 -> 1{Environment.NewLine}4 -> 1{Environment.NewLine}8 -> 2{Environment.NewLine}13 -> 1";

        // Act
        string actual = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = { -4, -5, -3 };
        string expected = $"-5 -> 1{Environment.NewLine}-4 -> 1{Environment.NewLine}-3 -> 1";

        // Act
        string actual = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = { 4, 8, 0, 1, 8, -3, 0 };
        string expected = $"-3 -> 1{Environment.NewLine}0 -> 2{Environment.NewLine}1 -> 1{Environment.NewLine}4 -> 1{Environment.NewLine}8 -> 2";

        // Act
        string actual = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    } 
}
