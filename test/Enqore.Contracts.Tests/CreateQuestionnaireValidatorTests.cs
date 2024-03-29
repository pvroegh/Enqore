﻿namespace Enqore.Contracts.Tests;
public class CreateQuestionnaireValidatorTests
{
    [Fact]
    public void Validate_TitleIsEmpty_ValidationFails()
    {
        // Arrange
        var validator = new CreateQuestionnaireValidator();
        var validatee = new CreateQuestionnaire()
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
        var validator = new CreateQuestionnaireValidator();
        var validatee = new CreateQuestionnaire()
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
        var validator = new CreateQuestionnaireValidator();
        var validatee = new CreateQuestionnaire()
        {
            Title = new string('?', 200)
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(v => v.Title);
    }
}
