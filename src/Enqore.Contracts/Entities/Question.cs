namespace Enqore.Contracts.Entities;
public abstract class Question
{
    public string Id { get; set; }
    public string Title { get; init; } = string.Empty;

}
