namespace Enqore.Contracts.Commands;
public sealed class CreateQuestionFreeTextSingleAnswer : CreateQuestionBase
{
}

public class CreateQuestionFreeTextSingleAnswerValidator : AbstractValidator<CreateQuestionFreeTextSingleAnswer>
{
    public CreateQuestionFreeTextSingleAnswerValidator()
    {
        RuleFor(v => v).SetValidator(new CreateQuestionBaseValidator());
    }
}
