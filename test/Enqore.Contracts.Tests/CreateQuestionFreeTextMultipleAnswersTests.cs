namespace Enqore.Contracts.Tests;
public class CreateQuestionFreeTextMultipleAnswersTests
{
    [Fact]
    public void Validate_NumberOfAnswersIsLessThan2_ValidationFails()
    {
        // Arrange
        var validator = new CreateQuestionFreeTextMultipleAnswersValidator();
        var validatee = new CreateQuestionFreeTextMultipleAnswers()
        {
            Title = "Who are your favorite Star Wars characters?",
            NumberOfAnswers = 1
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(v => v.NumberOfAnswers);
    }

    [Fact]
    public void Validate_NumberOfAnswersIsGreaterThan10_ValidationFails()
    {
        // Arrange
        var validator = new CreateQuestionFreeTextMultipleAnswersValidator();
        var validatee = new CreateQuestionFreeTextMultipleAnswers()
        {
            Title = "Who are your favorite Star Wars characters?",
            NumberOfAnswers = 11
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(v => v.NumberOfAnswers);
    }

    [Fact]
    public void Validate_NumberOfAnswersIsBetween2And10_ValidationSucceeds()
    {
        // Arrange
        var validator = new CreateQuestionFreeTextMultipleAnswersValidator();
        var validatee = new CreateQuestionFreeTextMultipleAnswers()
        {
            Title = "Who are your favorite Star Wars characters?",
            NumberOfAnswers = 5
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldNotHaveValidationErrorFor(v => v.NumberOfAnswers);
    }
}
