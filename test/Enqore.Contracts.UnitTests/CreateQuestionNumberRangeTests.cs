namespace Enqore.Contracts.Tests;
public class CreateQuestionNumberRangeTests
{

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0)]
    public void Validate_InvalidRanges_ValidationFails(int minValue, int maxValue)
    {
        // Arrange
        var validator = new CreateQuestionNumberRangeValidator();
        var validatee = new CreateQuestionNumberRange()
        {
            Title = "Grade yourself",
            MinValue = minValue,
            MaxValue = maxValue
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldHaveValidationErrorFor(v => v.MinValue);
        validationResult.ShouldHaveValidationErrorFor(v => v.MaxValue);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(int.MinValue, int.MaxValue)]
    public void Validate_ValidRanges_ValidationSucceeds(int minValue, int maxValue)
    {
        // Arrange
        var validator = new CreateQuestionNumberRangeValidator();
        var validatee = new CreateQuestionNumberRange()
        {
            Title = "Grade yourself",
            MinValue = minValue,
            MaxValue = maxValue
        };

        // Act
        var validationResult = validator.TestValidate(validatee);

        // Assert
        validationResult.ShouldNotHaveValidationErrorFor(v => v.MinValue);
        validationResult.ShouldNotHaveValidationErrorFor(v => v.MaxValue);
    }

}
