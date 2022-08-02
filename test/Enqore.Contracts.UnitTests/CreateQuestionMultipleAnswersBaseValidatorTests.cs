using Enqore.Contracts.Entities;

namespace Enqore.Contracts.Tests;
public class CreateQuestionMultipleAnswersBaseValidatorTests
{

    [Fact]
    public void Validate_PossibleAnswerIsLessThan2_ValidationFails()
    {
        // Arrange
        var validator = new CreateQuestionMultipleChoiceMultipleAnswersValidator();
        var validatee = new CreateQuestionMultipleChoiceMultipleAnswers()
        {
            Title = "What's your favorite Star Wars character?",
            PossibleChoices = new[]
            {
                new Answer() { Value = "Jar Jar Binks" }
            }
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(v => v.PossibleChoices);
    }

    [Fact]
    public void Validate_PossibleAnswersIsGreaterThan10_ValidationFails()
    {
        // Arrange
        var validator = new CreateQuestionMultipleChoiceMultipleAnswersValidator();
        var validatee = new CreateQuestionMultipleChoiceMultipleAnswers()
        {
            Title = "What's your favorite Star Wars character?",
            PossibleChoices = new[]
            {
                new Answer() { Value = "Darth Vader" },
                new Answer() { Value = "Luke Skywalker" },
                new Answer() { Value = "Han Solo" },
                new Answer() { Value = "Obi Wan Kenobi" },
                new Answer() { Value = "R2D2" },
                new Answer() { Value = "C3PO" },
                new Answer() { Value = "Princess Lea" },
                new Answer() { Value = "Yoda" },
                new Answer() { Value = "Darth Maul" },
                new Answer() { Value = "Jar Jar Binks" },
                new Answer() { Value = "Chewbacca" }
            }
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(v => v.PossibleChoices);
    }

    [Fact]
    public void Validate_PossibleAnswersIsBetween2And10_ValidationSucceeds()
    {
        // Arrange
        var validator = new CreateQuestionMultipleChoiceMultipleAnswersValidator();
        var validatee = new CreateQuestionMultipleChoiceMultipleAnswers()
        {
            Title = "What's your favorite Star Wars character?",
            PossibleChoices = new[]
            {
                new Answer() { Value = "Darth Vader" },
                new Answer() { Value = "Luke Skywalker" },
                new Answer() { Value = "Han Solo" },
                new Answer() { Value = "Obi Wan Kenobi" },
                new Answer() { Value = "R2D2" },
                new Answer() { Value = "C3PO" },
                new Answer() { Value = "Princess Lea" },
                new Answer() { Value = "Yoda" },
                new Answer() { Value = "Darth Maul" },
                new Answer() { Value = "Chewbacca" }
            }
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldNotHaveValidationErrorFor(v => v.PossibleChoices);
    }
}
