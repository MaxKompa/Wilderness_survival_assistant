namespace Wilderness_survival_assistant.guid;
// Define an abstract class for fire building in the context of survival
public abstract class FireBuilding:SurvivalGuide
{
    // Override the DisplayInfo method from the SurvivalGuide class
    public override void DisplayInfo()
    {
        // Prompt the user to enter available materials for building a fire
        Console.WriteLine("Enter available materials separated by commas  \n 1. flint steel. \n 2. magnifying glass. \n 3. battery foil. \n 4. wood rope. \n 5.stone knife \n Please select from the possible options: ");
        // Read user input and convert it to lowercase
        string input = Console.ReadLine().ToLower();
        // Split the input string into an array of materials
        string[] materials = input.Split(',');

        // Remove spaces around array elements
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i] = materials[i].Trim();
        }
        // Check for the presence of specific materials and provide instructions accordingly
        if (Array.Exists(materials,  m   => m == "flint steel")) 
        {
            Console.WriteLine("- Hold the flint over a dry, flammable material such as grass or moss.");
            Console.WriteLine("- Hit the flint with a metal object to create sparks.");
            Console.WriteLine("- Direct the spark towards the material to ignite it.");
        }
        else if (Array.Exists(materials, m => m == "wood rope"))
        {
            Console.WriteLine("- Make a bow from a branch and a rope.");
            Console.WriteLine("- Fix the stick vertically to the board.");
            Console.WriteLine("- Wrap the rope around the stick and spin it with the bow.");
            Console.WriteLine("- Continue until coal appears, then bring it to the dry material.");
        }
        else if (Array.Exists(materials, m => m == "magnifying glass"))
        {
            Console.WriteLine("- Focus sunlight on dry material such as grass or moss.");
            Console.WriteLine("- Hold the lens in place until the material begins to smolder.");
        }
        else if (Array.Exists(materials, m => m == "battery foil"))
        {
            Console.WriteLine("- Bend a strip of foil into an hourglass shape.");
            Console.WriteLine("- Place the ends on the battery, the central part will heat up and may catch fire.");
            Console.WriteLine("- Keep this near dry flammable material.");
        }
        else if (Array.Exists(materials, m => m == "stone knife"))
        {
            Console.WriteLine("- Hit the edge of the stone with a knife to create sparks.");
            Console.WriteLine("- Direct sparks at dry moss or grass to ignite.");
        }
        else if (Array.Exists(materials,  m   => m == "1")) 
        {
            Console.WriteLine("- Hold the flint over a dry, flammable material such as grass or moss.");
            Console.WriteLine("- Hit the flint with a metal object to create sparks.");
            Console.WriteLine("- Direct the spark towards the material to ignite it.");
        }
        else if (Array.Exists(materials, m => m == "4"))
        {
            Console.WriteLine("- Make a bow from a branch and a rope.");
            Console.WriteLine("- Fix the stick vertically to the board.");
            Console.WriteLine("- Wrap the rope around the stick and spin it with the bow.");
            Console.WriteLine("- Continue until coal appears, then bring it to the dry material.");
        }
        else if (Array.Exists(materials, m => m == "2"))
        {
            Console.WriteLine("- Focus sunlight on dry material such as grass or moss.");
            Console.WriteLine("- Hold the lens in place until the material begins to smolder.");
        }
        else if (Array.Exists(materials, m => m == "3"))
        {
            Console.WriteLine("- Bend a strip of foil into an hourglass shape.");
            Console.WriteLine("- Place the ends on the battery, the central part will heat up and may catch fire.");
            Console.WriteLine("- Keep this near dry flammable material.");
        }
        else if (Array.Exists(materials, m => m == "5"))
        {
            Console.WriteLine("- Hit the edge of the stone with a knife to create sparks.");
            Console.WriteLine("- Direct sparks at dry moss or grass to ignite.");
        }
        else
        {
            Console.WriteLine("Not enough materials to make fire.");
        }
    }
}