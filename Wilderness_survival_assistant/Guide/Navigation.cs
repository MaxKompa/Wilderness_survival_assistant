namespace Wilderness_survival_assistant.guid;

public abstract class Navigation:SurvivalGuide
{
    public override void DisplayInfo()
    {
        var lines = new[] 
        {
            "Finding Direction:",
            " ",
            "Hold the compass horizontally at chest level.",
            "Wait for the needle to settle. The red end of the needle will point to magnetic north.",
            "Turn the compass body until the needle aligns with the 'N' mark on the dial.",
            " ",
            "Setting the Direction:",
            " ",
            "Select a target point and point the needle at it.",
            "Read the degrees on the dial that indicate the direction. Remember or write down these degrees." ,
            " ",
            "Navigation:",
            " ",
            "To navigate in the chosen direction, hold the compass so that the needle remains on the 'N' mark.",
            "Look ahead a few meters to maintain the course, and check the compass periodically.",
            " ",
            "Using the map:",
            " ",
            "Fold the map on a flat surface and align it with the compass.",
            "Plot the direction using the compass for orientation on the ground."
            
        };
        Console.WriteLine(string.Join(Environment.NewLine, lines));
    }
}