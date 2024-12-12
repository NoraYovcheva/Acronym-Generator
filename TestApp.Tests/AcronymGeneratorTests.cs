using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class AcronymGeneratorTests
{
    [Test]
    public void Test_GenerateAcronym_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input = string.Empty;
        string expected = string.Empty;

        //Act
        string result = AcronymGenerator.GenerateAcronym(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GenerateAcronym_SingleWord_ReturnsUpperCaseFirstLetter()
    {
        //Arrange
        string input = "apple";
        string expected = "A";

        //Act
        string result = AcronymGenerator.GenerateAcronym(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GenerateAcronym_MultipleWords_ReturnsUpperCaseFirstLetters()
    {
        //Arrange
        string input = "united states of america";
        string expected = "USA";

        //Act
        string result = AcronymGenerator.GenerateAcronym(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GenerateAcronym_WordsWithNonLetters_ReturnsAcronymWithoutNonLetters()
    {
        //Arrange
        string input = "123 hello world!";
        string expected = "HW";

        //Act
        string result = AcronymGenerator.GenerateAcronym(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GenerateAcronym_PhraseWithSpecialCharacters_ReturnsUpperCaseFirstLetters()
    {
        //Arrange
        string input = "international business machines (IBM)";
        string expected = "IBM";

        //Act
        string result = AcronymGenerator.GenerateAcronym(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
