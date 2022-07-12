namespace Enqore.Contracts.Entities.Base;
public abstract class QuestionBase
{
    public Guid Id { get; set; }
    public string Title { get; init; } = string.Empty;

}
