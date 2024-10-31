using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPageNavigation
{
    // ItemsManager.cs (Simple static class to manage our items)
    public static class ItemsManager
    {
        private static int _nextId = 1;
        public static List<Item> Items { get; } = new List<Item>();

        public static void AddItem(Item item)
        {
            item.Id = _nextId++;
            Items.Add(item);
        }

        public static void UpdateItem(Item item)
        {
            var existingItem = Items.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Title = item.Title;
                existingItem.Description = item.Description;
            }
        }
    }

}
