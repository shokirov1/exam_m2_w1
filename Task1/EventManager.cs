using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class EventManager
    {
        List<Event> events = new List<Event>();

        public void AddEvent(Event newEvent)
        { 
            try
            {
                if(newEvent!=null)
                {
                    events.Add(newEvent);
                    Console.WriteLine("Event Added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void RemoveEvent(string name) 
        {
            try
            {
                var ckeckForRemove = events.FirstOrDefault(x => x.Name == name);
                if (ckeckForRemove!=null)
                {
                    events.Remove(ckeckForRemove);
                    Console.WriteLine("Event Removed");
                }
                else
                {
                    Console.WriteLine("Event is not finded");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
        }
        public List<Event> GetFromDate(DateTime date)
        {
            try
            {
                var ckeckForDate = events.FindAll(x => x.StartTime.Day >= date.Day && x.EndTime.Day == date.Day);
                if(ckeckForDate!=null)
                {
                    return ckeckForDate;
                }
                return null;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
