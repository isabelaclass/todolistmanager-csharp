namespace TodoListManager.API;

public class TaskItem
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public string? Description { get; set; }

    public bool IsCompleted { get; set; }

    public TaskPriority TaskPriority { get; set; } = TaskPriority.Medium;

    public string UserId { get; set; } = string.Empty;

}

public enum TaskPriority
{
    Low,
    Medium,
    High
}