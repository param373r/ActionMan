using ActionMan.Domain.Common;

namespace ActionMan.Domain.Actions;

public class ActionModel : Entity
{
    string ActionId;
    public required string Name { get; set; }
    public string? Description { get; set; }
    public ActionStatus Status { get; set; } = ActionStatus.NEW;
    public ActionPriority Priority { get; set; } = ActionPriority.P5;
    public DateTime CreationDate { get; init; }
    public DateTime? LastModifiedDate { get; set; }
    public DateTime? DueDate { get; set; }
    public List<string> Tags { get; set; }
    public long? EstimatedHours { get; set; }
    public ActionModel(string name, string description, ActionStatus status, ActionPriority priority, DateTime creationDate, DateTime lastModifiedDate, DateTime? dueDate, List<string> tags, long? estimatedHours)
    {
        ActionId = name.Replace(" ", "-").ToLower();
        Name = name;
        Description = description;
        Priority = priority;
        CreationDate = creationDate;
        LastModifiedDate = lastModifiedDate;
        DueDate = dueDate;
        Tags = tags;
        EstimatedHours = estimatedHours;
    }
}