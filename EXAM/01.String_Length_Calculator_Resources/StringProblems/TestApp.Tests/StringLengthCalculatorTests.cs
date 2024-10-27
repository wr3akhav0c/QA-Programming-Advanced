using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class StringLengthCalculatorTests
{
    [Test]
    public void Test_Calculate_EmptyString_ReturnsZero()
    {
        // Arrange
        string text = "";

        // Act
        int actual = StringLengthCalculator.Calculate(text);

        // Assert
        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void Test_Calculate_SingleEvenLengthWord_ReturnsCorrectInteger()
    {
        // Arrange
        string text = "dinq";
        int expected = 856;

        // Act
        int actual = StringLengthCalculator.Calculate(text);

        // Assert
        Assert.That(expected, Is.EqualTo(actual));    
    }

    [Test]
    public void Test_Calculate_SingleOddLengthWord_ReturnsCorrectInteger()
    {
        // Arrange
        string text = "Natalia";
        int expected = 349;

        // Act
        int actual = StringLengthCalculator.Calculate(text);

        // Assert
        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Calculate_WholeSentenceString_ReturnsCorrectInteger()
    {
        // Arrange
        string text = "Back at home studying";
        int expected = 995;

        // Act
        int actual = StringLengthCalculator.Calculate(text);

        // Assert
        Assert.That(expected, Is.EqualTo(actual));
    }

}

