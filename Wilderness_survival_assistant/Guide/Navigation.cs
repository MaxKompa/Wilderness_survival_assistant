namespace Wilderness_survival_assistant.guid;
// Define an abstract class for navigation techniques in the context of survival
public abstract class Navigation:SurvivalGuide
{
    // Override the DisplayInfo method from the SurvivalGuide class
    public override void DisplayInfo()
    {
        // Create an array of navigation techniques to display to the user
        var lines = new[] 
        {
            "1. orienteering techniques the 'circle' scan technique." ,
            "2. using maps and a compass map.",
            "3. the sun and stars the sun.",
            "4. natural landmarks rivers and streams. ",
            "5. sound navigation.",
            "6. using materials moss on trees. ",
            " ",
            "Please select from the possible options: "
        };
        // Print the navigation techniques to the console
        Console.WriteLine(string.Join(Environment.NewLine, lines));
        // Read user input and convert it to lowercase
        string input = Console.ReadLine().ToLower();
        // Split the input string into an array of chosen options
        string[] choose = input.Split(',');

        // Remove spaces around array elements
        for (int i = 0; i < choose.Length; i++)
        {
            choose[i] = choose[i].Trim();
        }
        // Check for the presence of specific navigation techniques and provide instructions accordingly
        if (Array.Exists(choose,  m   => m == "orienteering techniques the 'circle' scan technique"))
        {
            Console.WriteLine("- Look around and note major landmarks on the horizon to get an idea of where you are.");
            Console.WriteLine("- The 'parallel' technique: Move in the direction of a landmark, checking to make sure you are not going off course.");
        }
        else if (Array.Exists(choose, m => m == "using maps and a compass map"))
        {
            Console.WriteLine("- Know how to read topographic maps, which show terrain, bodies of water, roads, and other landmarks.");
            Console.WriteLine("- Compass: Use a compass to find your trail. Example: Find north with a compass and match it to the map.");
        }
        else if (Array.Exists(choose, m => m == "the sun and stars the sun"))
        {
            Console.WriteLine("- In the Northern Hemisphere, the sun rises in the east and sets in the west. At noon, the sun will be in the south. Use this to help you find your way.");
            Console.WriteLine("- Stars: At night, you can use Polaris (in the Northern Hemisphere) to find your way to the north.");
        }
        else if (Array.Exists(choose,  m   => m == "natural landmarks rivers and streams"))
        {
            Console.WriteLine("- Water courses often provide good landmarks. Follow a river to find your way to populated areas.");
            Console.WriteLine("- Terrain: Use hills, valleys, and other geographic features to determine your location.");
        }
        else if (Array.Exists(choose, m => m == "sound navigation"))
        {
            Console.WriteLine("- Listen for sounds (such as running water, cars, or people talking) that can help you determine your direction.");
        }
        else if (Array.Exists(choose, m => m == "using materials moss on trees"))
        {
            Console.WriteLine("- In the Northern Hemisphere, moss often grows on the north side of trees (but it is not always a reliable method).");
            Console.WriteLine("- In the Northern Hemisphere, moss often grows on the north side of trees (but it is not always a reliable method).");
        }
        else if (Array.Exists(choose,  m   => m == "1"))
        {
            Console.WriteLine("- Look around and note major landmarks on the horizon to get an idea of where you are.");
            Console.WriteLine("- The 'parallel' technique: Move in the direction of a landmark, checking to make sure you are not going off course.");
        }
        else if (Array.Exists(choose, m => m == "2"))
        {
            Console.WriteLine("- Know how to read topographic maps, which show terrain, bodies of water, roads, and other landmarks.");
            Console.WriteLine("- Compass: Use a compass to find your trail. Example: Find north with a compass and match it to the map.");
        }
        else if (Array.Exists(choose, m => m == "3"))
        {
            Console.WriteLine("- In the Northern Hemisphere, the sun rises in the east and sets in the west. At noon, the sun will be in the south. Use this to help you find your way.");
            Console.WriteLine("- Stars: At night, you can use Polaris (in the Northern Hemisphere) to find your way to the north.");
        }
        else if (Array.Exists(choose,  m   => m == "4"))
        {
            Console.WriteLine("- Water courses often provide good landmarks. Follow a river to find your way to populated areas.");
            Console.WriteLine("- Terrain: Use hills, valleys, and other geographic features to determine your location.");
        }
        else if (Array.Exists(choose, m => m == "5"))
        {
            Console.WriteLine("- Listen for sounds (such as running water, cars, or people talking) that can help you determine your direction.");
        }
        else if (Array.Exists(choose, m => m == "6"))
        {
            Console.WriteLine("- In the Northern Hemisphere, moss often grows on the north side of trees (but it is not always a reliable method).");
            Console.WriteLine("- In the Northern Hemisphere, moss often grows on the north side of trees (but it is not always a reliable method).");
        }
        else
        {
            Console.WriteLine("There is no such option. Follow the instructions. ");
        }
    } 
}
