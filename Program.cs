using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    partial class flat
    {
        private readonly int id = 0;
        private int number = 0;
        private int square = 0;
        private int floor = 0;
        private int nRooms = 0;
        private string street = "";
        private int time = 0;
        private readonly int size = 0;
        public  enum type
        {
            Панельный = 1, Кирпичный
        }
        private type tp = type.Панельный;
        private readonly uint FlightID;
        private static string company = "";
       public void sizeinfo()
        {
           Console.WriteLine("Size:" + size);
       }

        public int NUMBER
        {
            get { return this.number; }
            set { this.number = value; }

        }
        public int FLOOR
        {
            get { return this.floor; }
            set { this.floor = value; }

        }
        public string STREET
        {
            get { return this.street; }
            set { this.street = value; }

        }
        public int NROOMS
        {
            get { return this.nRooms; }
            set { this.nRooms = value; }

        }
        public type TYPE
        {
            get { return this.tp; }
            set { this.tp = value; }

        }
        public int TIME
        {
            get { return this.time; }
            set { this.time = value; }

        }
        public flat()
        {
            this.number = 0;
            this.nRooms = 0;
            this.square = 0;
            this.time = 0;
            this.street = "";
            this.tp = type.Кирпичный;
            this.id = GetHashCode();
            size++;
        }

        public flat(int n, int floor, int nr, int sqr, int time, string str, type t)
        {
            this.floor = floor;
            this.number = n;
            this.nRooms = nr;
            this.square = sqr;
            this.time = time;
            this.street = str;
            this.tp = t;
            this.id = GetHashCode();
            size++;
        }

        static flat()
        {
            Console.WriteLine("Создан объект");
        }
        public flat(string str, int n, int floor)
        {
            this.street = str;
            this.number = n;
            this.id = GetHashCode();
            size++;
        }
        public bool remont()
        {
            int x;
            Console.Write("Введите текущий год");
            x = Console.Read();
            if (this.time > x)
                Console.WriteLine("Капитальный ремонт не требуется");
            else
                Console.WriteLine("Капитальный ремонт требуется");
            return true;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            object[] ListOfFlats = new object[6]
            {
                 new flat(3 /*nomer kvartiry*/, 5/*etazh*/, 5/*komnat*/, 2050/*konec ekspl*/, 50/*ploscad*/, " Ленина "/*ulica*/,flat.type.Кирпичный),

                 new flat(),
                 
                 new flat(5, 9, 5, 50, 2050, "Ленина",flat.type.Кирпичный),
                 new flat(5, 9, 5, 50, 2050, "Ленина",flat.type.Кирпичный),
                 new flat(6, 3, 5, 50, 2000, "Ленина",flat.type.Кирпичный),
                 new flat("Ленина", 2, 7),
             };
           
           
            int n = 5;
            int niz = 3;
            int ver = 7;
            Console.WriteLine("Список Квартир с комнатами  - " + n);
            foreach (flat flat_ in ListOfFlats)
            {
                if (flat_.NROOMS == n)
                    Console.WriteLine("Номер квартиры "+flat_.NUMBER + "\t Улица " + flat_.STREET + " \t Этаж " + flat_.FLOOR);
            }
            Console.WriteLine("Список Квартир где комнат - " + n +" на этажах "+niz + " - " + ver);
            foreach (flat flat_ in ListOfFlats)
            {
                if (flat_.NROOMS == n && flat_.FLOOR >= niz && flat_.FLOOR <= ver)
                {
                    Console.WriteLine(" Номер квартиры " + flat_.NUMBER + " \t Улица " + flat_.STREET + " \t Этаж " + flat_.FLOOR);
                }
            }

            foreach (flat flat_ in ListOfFlats)
            {
                    
                    Console.WriteLine("Номер квартиры " + flat_.NUMBER + "\t Улица " + flat_.STREET + "\t Этаж " + flat_.FLOOR + "конец срока эксплуатации " + flat_.TIME);
                    flat_.remont();
                
            }

            var user = new { Name = "dddd",

            };
            Console.WriteLine(user.Name);
            
           // Console.WriteLine(Equals(ListOfFlights[0], ListOfFlights[1]));
            Console.WriteLine(ListOfFlats[2].Equals(ListOfFlats[3]));
            Console.WriteLine(ListOfFlats[1].ToString());
            Console.ReadLine();
        }
    }
}
