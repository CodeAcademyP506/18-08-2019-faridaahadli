using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    class Hotel
    {
        public string Name;
        public string Address;
        public string[] Services;
        public Room[] Rooms=new Room[3];
        public int minPrice;
        public string ShowInfo()
        {
            
            return "Hotel name: " + Name + "\n Address: " + Address+"\n Services: " + OurService() +"\n Minimum Price :"+MinNumber()+"\n--------------";
        }

        public int MinNumber()
        {
            minPrice = Rooms[0].Price;
            for (int i = 0; i <Rooms.Length-1 ; i++)
            {
              
                if (minPrice>Rooms[i + 1].Price)
                {
                    minPrice = Rooms[i+1].Price;
                }
            }
          
            return minPrice;
        }
        public string OurService()
        {
            string allService = " ";
            for (int i = 0; i < Services.Length; i++)
            {
                allService += Services[i].ToUpper() + " ";
            }
            return allService;
        }
    }
}
