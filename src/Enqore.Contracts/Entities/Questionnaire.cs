namespace Enqore.Contracts.Entities;
public class Questionnaire
{
    public Guid Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public List<Question> Questions { get; init; } = new List<Question>();
}
