namespace Wilderness_survival_assistant.equipment;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class EquipmentManager
{
    private List<EquipmentItem> equipmentList;
    private readonly string filePath;

    public EquipmentManager(string filePath)
    {
        this.filePath = filePath;
        equipmentList = new List<EquipmentItem>();

        // Attempt to load data from file upon initialization
        LoadFromFile();
    }

    // Method to add a new item to the equipment list
    public void AddItem(string name)
    {
        var item = new EquipmentItem(name);
        equipmentList.Add(item);
        Console.WriteLine($"Item '{name}' added.");
        SaveToFile();
    }

    // Method to remove an item by name
    public void RemoveItem(string name)
    {
        var item = equipmentList.FirstOrDefault(e => e.Name == name);
        if (item != null)
        {
            equipmentList.Remove(item);
            Console.WriteLine($"Item '{name}' removed.");
            SaveToFile();
        }
        else
        {
            Console.WriteLine($"Item '{name}' not found.");
        }
    }

    // Method to mark an item as collected
    public void MarkAsCollected(string name)
    {
        var item = equipmentList.FirstOrDefault(e => e.Name == name);
        if (item != null)
        {
            item.IsCollected = true;
            Console.WriteLine($"Item '{name}' marked as collected.");
            SaveToFile();
        }
        else
        {
            Console.WriteLine($"Item '{name}' not found.");
        }
    }

    // Method to save the equipment list to a JSON file
    private void SaveToFile()
    {
        try
        {
            string json = JsonSerializer.Serialize(equipmentList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            Console.WriteLine("Equipment list saved to file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }

    // Method to load the equipment list from a JSON file
    private void LoadFromFile()
    {
        try
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                equipmentList = JsonSerializer.Deserialize<List<EquipmentItem>>(json) ?? new List<EquipmentItem>();
                Console.WriteLine("Equipment list loaded from file.");
            }
            else
            {
                Console.WriteLine("Data file not found, creating a new list.");
                equipmentList = new List<EquipmentItem>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading from file: {ex.Message}");
            equipmentList = new List<EquipmentItem>();
        }
    }

    // Method to display the equipment list in the console
    public void ShowEquipmentList()
    {
        Console.WriteLine("Equipment List:");
        foreach (var item in equipmentList)
        {
            Console.WriteLine(item);
        }
    }
}