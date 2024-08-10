using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class BookingManager
    {
        List<Booking> bookings = new List<Booking>();

        public void Add(Booking booking)
        {
            try
            {
                if(booking!=null)
                {
                    bookings.Add(booking);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
