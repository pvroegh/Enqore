namespace Enqore.Contracts.Commands;
public sealed class CreateQuestionFreeTextSingleAnswer : CreateQuestionBase<QuestionFreeTextSingleAnswer>
{
}

public class CreateQuestionFreeTextSingleAnswerValidator : AbstractValidator<CreateQuestionFreeTextSingleAnswer>
{
    public CreateQuestionFreeTextSingleAnswerValidator()
    {
        RuleFor(v => v).SetValidator(new CreateQuestionBaseValidator<CreateQuestionFreeTextSingleAnswer, QuestionFreeTextSingleAnswer>());
    }
}
