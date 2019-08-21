using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    class Program
    {
 
        static void Main(string[] args)
        {
           
            // Rooms of the Hotel 1
            var Room1 = new Room();
            Room1.Number = 1;
            Room1.Type = "single";
            Room1.Price = 45;
            var Room2 = new Room();
            Room2.Number = 2;
            Room2.Type = "Double";
            Room2.Price = 100;
            var Room3 = new Room();
            Room3.Number = 3;
            Room3.Type = "Triple";
            Room3.Price = 150;
     

            // Rooms of the Hotel 2
            var Room4 = new Room();
            Room4.Number = 1;
            Room4.Type = "single";
            Room4.Price = 60;
            var Room5 = new Room();
            Room5.Number = 2;
            Room5.Type = "Trible";
            Room5.Price = 180;
            var Room6 = new Room();
            Room6.Number = 3;
            Room6.Type = "Double";
            Room6.Price = 100;
           Hotel[] hotels = new Hotel[]  {
                new Hotel { Name = "Avrasiya", Address = "Nizami", Services = new string[] { "eat", "Clean" }, Rooms = new Room[] { Room1, Room2, Room3 } },
                new Hotel { Name = "Caspian", Address = "28 May", Services = new string[] { "Swimming", "Spa" }, Rooms = new Room[] { Room4, Room5, Room6 } }

            };
            beginAgain(hotels);


        }

        public static void findHotel(Hotel[] arr,string Name)
        {
            int index=-1;
            bool correct = false;
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i].Name.ToLower() == Name.ToLower())
                {
                    correct = true;
                  index=i;
                    break;
                }
            }
            if (!correct)
            {
                Console.WriteLine("Melumatda sehvlik var emeliyyat yeniden baslanir! \n Zehmet olmasa otelin adini duzgun daxil edin!");
                beginAgain(arr);
            }
            Console.WriteLine("Bos otaqlar:"+"\n ");
            for (int i = 0; i < arr[index].Rooms.Length; i++)
            {
                Console.WriteLine(arr[index].Rooms[i].ShowRoomInfo());
            }
            Console.WriteLine("Enter your room number: ");
            int roomNumber = Convert.ToInt32(Console.ReadLine());
           
            ReservedRoom(arr[index].Rooms,arr, roomNumber,index);
           
        }
        
        public static void ReservedRoom(Room[] room,Hotel[] hotel,int number,int index)
        {
            for (int n = 0; n <room.Length; n++)
            {
                if (room[n].Number == number)
                {
                   
                    Console.WriteLine("Tebrikler, emeliyyat muveffeqiyyetle heyata kecirildi.Otaginizla bagli melumatlar:"+"\n  ");

                    Console.WriteLine(room[n].ShowRoomInfo());
                    room[n].Reserved = true;
                } 
            }
            Console.WriteLine("Oteliniz haqqinda melumatlar:"+"\n ");
            Console.WriteLine(hotel[index].ShowInfo());
            beginAgain(hotel);
        }

        public static void beginAgain(Hotel[] hotel)
        {
            Console.WriteLine("---------------"+"\n Booking baslanildi"+"\n--------------");
            for (int i = 0; i < hotel.Length; i++)
            {
                Console.WriteLine(hotel[i].ShowInfo());
            }

            Console.WriteLine("Enter your hotel name:");
            string myHotel = Console.ReadLine();
            Console.WriteLine("\n ");
            findHotel(hotel, myHotel);
        }

    }
}
