namespace Enqore.Contracts.Tests;

public class CreateQuestionBaseValidatorTests
{
    [Fact]
    public void Validate_TitleIsEmpty_ValidationFails()
    {
        // Arrange
        var validator = new CreateQuestionMultipleChoiceMultipleAnswersValidator();
        var validatee = new CreateQuestionMultipleChoiceMultipleAnswers()
        {
            Title = string.Empty
        };
        
        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(v => v.Title);
    }

    [Fact]
    public void Validate_TitleIsNotEmpty_ValidationSucceeds()
    {
        // Arrange
        var validator = new CreateQuestionMultipleChoiceMultipleAnswersValidator();
        var validatee = new CreateQuestionMultipleChoiceMultipleAnswers()
        {
            Title = "Rate your emptyness"
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldNotHaveValidationErrorFor(v => v.Title);
    }

    [Fact]
    public void Validate_TitleIsTooLong_ValidationFails()
    {
        // Arrange
        var validator = new CreateQuestionMultipleChoiceMultipleAnswersValidator();
        var validatee = new CreateQuestionMultipleChoiceMultipleAnswers()
        {
            Title = new string('?', 200)
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(v => v.Title);
    }


    [Fact]
    public void Validate_QuestionnaireIdIsEmpty_ValidationFails()
    {
        // Arrange
        var validator = new CreateQuestionMultipleChoiceMultipleAnswersValidator();
        var validatee = new CreateQuestionMultipleChoiceMultipleAnswers()
        {
            QuestionnaireId = Guid.Empty
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(v => v.QuestionnaireId);
    }

    [Fact]
    public void Validate_QuestionnaireIdIsAValidGuid_ValidationSucceeds()
    {
        // Arrange
        var validator = new CreateQuestionMultipleChoiceMultipleAnswersValidator();
        var validatee = new CreateQuestionMultipleChoiceMultipleAnswers()
        {
            QuestionnaireId = Guid.NewGuid()
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldNotHaveValidationErrorFor(v => v.QuestionnaireId);
    }
}