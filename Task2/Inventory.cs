using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Inventory<T> where T : Item
    {
        List<Item> items=new List<Item>();
        public void AddItem(T item) 
        {
            try
            {
                if(item!=null)
                {
                    items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void RemoveItem(T item)
        {
            try
            {
                var checkForRemove = items.FirstOrDefault(x => x.Name == item.Name);
                if(checkForRemove!=null)
                {
                    items.Remove(checkForRemove);
                }
                else
                {
                    Console.WriteLine("Item is not found");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<Item> GetItemsByCategory(string category)
        {
            try
            {
                var checkForCategory = items.FindAll(x => x.Category == category);
                if (checkForCategory != null)
                {
                    return checkForCategory;
                }
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<Item> GetAllItems()
        {
            return items;
        }
    }
}
