namespace Wilderness_survival_assistant.guid;

public abstract class WaterPurification:SurvivalGuide
{
    public override void DisplayInfo()
    {
        var lines = new[] 
        {
            "1. finding water sources" ,
            "2. purifying water",
            "3. extracting water from air (using condensation)",
            " ",
            "Please select from the possible options: "
        };
        Console.WriteLine(string.Join(Environment.NewLine, lines));
        string input = Console.ReadLine().ToLower();
        string[] way = input.Split(',');

        // Remove spaces around array elements
        for (int i = 0; i < way.Length; i++)
        {
            way[i] = way[i].Trim();
        }

        if (Array.Exists(way,  m   => m == "finding water sources"))
        {
            Console.WriteLine("- Rivers and Streams: Look for running water, as it is usually cleaner than standing water..");
            Console.WriteLine("- Rain: Collect rainwater using leaves, clothing, a tent, or a container. It is already safe to drink..");
            Console.WriteLine("- Dew: Early in the morning, you can collect dew from grass or leaves by walking over them with a cloth and then wringing it out.");
            Console.WriteLine("- Plants: Some plants contain water. For example, cacti or vines can provide a small amount of moisture.");
        }
        else if (Array.Exists(way, m => m == "purifying water"))
        {
            Console.WriteLine("- Boiling: The most reliable way to kill bacteria and parasites. Boil water for 5-10 minutes. Works with any natural source.");
            Console.WriteLine("- Filtration with a cloth: Strain water through a cloth to remove large particles, then boil it. A filter from improvised materials: Make a filter using a bottle, sand, charcoal, and gravel.");
            Console.WriteLine("- How to make a filter: Layer charcoal, sand, and small stones in a bottle. Pour water on top so that the filter removes small particles and some impurities. After this, boil the water anyway.");
            Console.WriteLine("- If there are no clean sources nearby, you can collect water from the soil: Dig a hole, put green plants or moist soil in it. Place an empty container in the center of the hole.\nCover the hole with transparent film, secure the edges, and put a stone in the center of the film. Under the influence of the sun, the water will evaporate and condense on the film, flowing into the container..");
        }
        else if (Array.Exists(way, m => m == "extracting water from air"))
        {
            Console.WriteLine("- Condensation collection: Wrap a piece of cloth around grass or trees overnight. In the morning, the cloth will collect some moisture, which can be squeezed into a container.");
            Console.WriteLine("- Solar still: If water is available but salty, dig a hole on the shore, put a container in the center and cover the hole with transparent film with a weight in the middle. The water will evaporate and collect in the container, purified from salt.");
        }
        else if (Array.Exists(way,  m   => m == "1"))
        {
            Console.WriteLine("- Rivers and Streams: Look for running water, as it is usually cleaner than standing water..");
            Console.WriteLine("- Rain: Collect rainwater using leaves, clothing, a tent, or a container. It is already safe to drink..");
            Console.WriteLine("- Dew: Early in the morning, you can collect dew from grass or leaves by walking over them with a cloth and then wringing it out.");
            Console.WriteLine("- Plants: Some plants contain water. For example, cacti or vines can provide a small amount of moisture.");
        }
        else if (Array.Exists(way, m => m == "2"))
        {
            Console.WriteLine("- Boiling: The most reliable way to kill bacteria and parasites. Boil water for 5-10 minutes. Works with any natural source.");
            Console.WriteLine("- Filtration with a cloth: Strain water through a cloth to remove large particles, then boil it. A filter from improvised materials: Make a filter using a bottle, sand, charcoal, and gravel.");
            Console.WriteLine("- How to make a filter: Layer charcoal, sand, and small stones in a bottle. Pour water on top so that the filter removes small particles and some impurities. After this, boil the water anyway.");
            Console.WriteLine("- If there are no clean sources nearby, you can collect water from the soil: Dig a hole, put green plants or moist soil in it. Place an empty container in the center of the hole.\nCover the hole with transparent film, secure the edges, and put a stone in the center of the film. Under the influence of the sun, the water will evaporate and condense on the film, flowing into the container..");
        }
        else if (Array.Exists(way, m => m == "3"))
        {
            Console.WriteLine("- Condensation collection: Wrap a piece of cloth around grass or trees overnight. In the morning, the cloth will collect some moisture, which can be squeezed into a container.");
            Console.WriteLine("- Solar still: If water is available but salty, dig a hole on the shore, put a container in the center and cover the hole with transparent film with a weight in the middle. The water will evaporate and collect in the container, purified from salt.");
        }
        else
        {
            Console.WriteLine("There is no such option. Follow the instructions. ");
        }
    }
}
