using ActionMan.Domain.Common;
using ActionMan.Domain.Actions;

namespace ActionMan.Domain.Routines;
public class Routine : Entity
{
    string RoutineId;
    public required string Name { get; set; }
    public string? Description { get; set; }
    public List<string> Tags { get; set; }
    public List<ActionModel> Actions { get; set; }
    public long? EstimatedTime { get; set; }

    public Routine(string name, string description, List<string> tags, List<ActionModel> actions, long? estimatedTime)
    {
        RoutineId = name.Replace(" ", "-").ToLower();
        Name = name;
        Description = description;
        Tags = tags;
        Actions = actions;
        EstimatedTime = estimatedTime;
    }

}