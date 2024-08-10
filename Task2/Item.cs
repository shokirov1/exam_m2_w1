using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Item
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public enum Type
        {
            HomeItem, 
            WorkItem, 
            OfficeItem
        }
    }
}
