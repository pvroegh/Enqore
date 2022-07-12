namespace Enqore.Contracts.Entities;
public class Questionnaire
{
    public Guid Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public List<QuestionBase> Questions { get; init; } = new List<QuestionBase>();
}
