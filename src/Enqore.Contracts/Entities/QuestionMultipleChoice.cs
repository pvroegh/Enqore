namespace Enqore.Contracts.Entities;

public abstract class QuestionMultipleChoice : Question
{
    public List<Answer> PossibleAnswers { get; init; } = new List<Answer>();
}