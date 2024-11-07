using System.Text.Json.Serialization.Metadata;

namespace Wilderness_survival_assistant.guid;
// Define an abstract class for a survival guide, serving as a base for other survival-related guides
public abstract class SurvivalGuide
{
    // Virtual method that can be overridden in derived classes to display specific information
    public virtual void DisplayInfo()
    {
        Console.WriteLine("\nSurvival Guide");
    }
}



