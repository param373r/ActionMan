using ActionMan.Domain.Common;
using ActionMan.Domain.Routines;

namespace ActionMan.Domain.Clusters;

public class Cluster : Entity
{
    public string ClusterId { get; private set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public List<Routine> Routines { get; set; }

    public Cluster(string name, string description, List<Routine> routines)
    {
        ClusterId = name.Replace(" ", "-").ToLower();
        Name = name;
        Description = description;
        Routines = routines;
    }

}