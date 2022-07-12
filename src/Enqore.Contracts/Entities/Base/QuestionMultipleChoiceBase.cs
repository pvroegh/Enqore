namespace Enqore.Contracts.Entities.Base;

public abstract class QuestionMultipleChoiceBase : QuestionBase
{
    public List<Answer> PossibleAnswers { get; init; } = new List<Answer>();
}