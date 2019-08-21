using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    class Room
    {
        public int Number;
        public string Type;
        public int Price;
        public bool Reserved=false;

        public string ShowRoomInfo()
        {
            if (Reserved == false)
            {
              
                return "Room  Number: " + Number + "\n Room Type: " + Type + "\n Room Price: " + Price + "\n--------------";
            }
               
            else
                return "";
        }
    }
}
