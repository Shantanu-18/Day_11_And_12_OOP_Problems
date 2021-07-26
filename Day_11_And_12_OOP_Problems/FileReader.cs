using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace Day_11_And_12_OOP_Problems
{
    public class FileReader
    {
        public static List<Inventory> inventories = new List<Inventory>();

        public List<Inventory> GetInventry()
        {
            string text = File.ReadAllText("C:\\Users\\shant\\Documents\\Data.json");
            inventories = JsonConvert.DeserializeObject<List<Inventory>>(text);
            return inventories;
        }

    }
}
