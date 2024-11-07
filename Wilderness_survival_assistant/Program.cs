namespace Wilderness_survival_assistant
{

    using System;
    using equipment;
    using guid;
    using journal;

    class Program
    {
        static void Main(string[] args)
        {
            var equipmentManager = new EquipmentManager("equipment.json");
            var observationJournal = new ObservationJournal();

            while (true)
            {
                Console.WriteLine("Welcome to the Wilderness Survival Assistant");
                Console.WriteLine("1. Equipment Management");
                Console.WriteLine("2. Fire Building Guide");
                Console.WriteLine("3. Navigation Guide");
                Console.WriteLine("4. Water Purification Guide");
                Console.WriteLine("5. Observation Journal");
                Console.WriteLine("6. Exit");
                Console.Write("Please select an option: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ManageEquipment(equipmentManager);
                        break;
                    case "2":
                        var fireBuilding = new ConcreteFireBuilding();
                        fireBuilding.DisplayInfo();
                        break;
                    case "3":
                        var navigation = new ConcreteNavigation();
                        navigation.DisplayInfo();
                        break;
                    case "4":
                        var waterPurification = new ConcreteWaterPurification();
                        waterPurification.DisplayInfo();
                        break;
                    case "5":
                        ManageObservationJournal(observationJournal);
                        break;
                    case "6":
                        Console.WriteLine("Exiting the application.");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void ManageEquipment(EquipmentManager equipmentManager)
        {
            while (true)
            {
                Console.WriteLine("\nEquipment Management");
                Console.WriteLine("1. Add Equipment Item");
                Console.WriteLine("2. Remove Equipment Item");
                Console.WriteLine("3. Mark Item as Collected");
                Console.WriteLine("4. Show Equipment List");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Please select an option: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter item name: ");
                        string nameToAdd = Console.ReadLine();
                        equipmentManager.AddItem(nameToAdd);
                        break;
                    case "2":
                        Console.Write("Enter item name to remove: ");
                        string nameToRemove = Console.ReadLine();
                        equipmentManager.RemoveItem(nameToRemove);
                        break;
                    case "3":
                        Console.Write("Enter item name to mark as collected: ");
                        string nameToCollect = Console.ReadLine();
                        equipmentManager.MarkAsCollected(nameToCollect);
                        break;
                    case "4":
                        equipmentManager.ShowEquipmentList();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void ManageObservationJournal(ObservationJournal observationJournal)
        {
            const string defaultFilename = "observation_entries.json"; // Set a default filename

            while (true)
            {
                Console.WriteLine("\nObservation Journal Management");
                Console.WriteLine("1. Add Observation Entry");
                Console.WriteLine("2. View Observation Entries");
                Console.WriteLine("3. Save Entries to JSON");
                Console.WriteLine("4. Load Entries from JSON");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Please select an option: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter observation description: ");
                        string description = Console.ReadLine();
                        observationJournal.AddEntry(description);
                        break;
                    case "2":
                        var entries = observationJournal.ViewEntries();
                        foreach (var entry in entries)
                        {
                            Console.WriteLine($"{entry.Date}: {entry.Description}");
                        }

                        break;
                    case "3":
                        observationJournal.SaveToJson(defaultFilename); // Save using the default filename
                        Console.WriteLine($"Entries saved to {defaultFilename}.");
                        break;
                    case "4":
                        observationJournal.LoadFromJson(defaultFilename); // Load using the default filename
                        Console.WriteLine($"Entries loaded from {defaultFilename}.");
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

    }
}
