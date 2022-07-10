namespace Enqore.Contracts.Commands;
public sealed class CreateQuestionNumberRange : CreateQuestionBase
{
    public int MinValue { get; init; }
    public int MaxValue { get; init; }
}

public class CreateQuestionNumberRangeValidator : AbstractValidator<CreateQuestionNumberRange>
{
    public CreateQuestionNumberRangeValidator()
    {
        RuleFor(v => v).SetValidator(new CreateQuestionBaseValidator());
        RuleFor(v => v.MinValue).Must((validatee, value) => value < validatee.MaxValue).WithMessage("The minimum value must be smaller than the maximum value.");
        RuleFor(v => v.MaxValue).Must((validatee, value) => value > validatee.MinValue).WithMessage("The maximum value must be greater than the minimum value.");
    }
}