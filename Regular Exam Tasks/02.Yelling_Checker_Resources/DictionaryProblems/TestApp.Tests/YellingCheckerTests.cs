using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class YellingCheckerTests
{
    [Test]
    public void Test_AnalyzeSentence_EmptyString_ReturnsEmptyDictionary()
    {
        // Arrange
        string speech = string.Empty;
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> actual = YellingChecker.AnalyzeSentence(speech);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AnalyzeSentence_OnlyUpperCaseWords_ReturnsDictionaryWithYellingEntriesOnly()
    {
        // Arrange
        string speech = "ALO BE";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["yelling"] = 2
        };

        // Act
        Dictionary<string, int> actual = YellingChecker.AnalyzeSentence(speech);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AnalyzeSentence_OnlyLowerCaseWords_ReturnsDictionaryWithSpeakingLowerEntriesOnly()
    {
        // Arrange
        string speech = "hello everyone";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["speaking lower"] = 2
        };

        // Act
        Dictionary<string, int> actual = YellingChecker.AnalyzeSentence(speech);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AnalyzeSentence_OnlyMixedCaseWords_ReturnsDictionaryWithASpeakingNormalEntriesOnly()
    {
        // Arrange
        string speech = "Today Is Good";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["speaking normal"] = 3
        };

        // Act
        Dictionary<string, int> actual = YellingChecker.AnalyzeSentence(speech);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AnalyzeSentence_LowerUpperMixedCasesWords_ReturnsDictionaryWithAllTypeOfEntries()
    {
        // Arrange
        string speech = "Who Will I be TONIGHT";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            ["yelling"] = 2,
            ["speaking normal"] = 2,
            ["speaking lower"] = 1
        };

        // Act
        Dictionary<string, int> actual = YellingChecker.AnalyzeSentence(speech);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

