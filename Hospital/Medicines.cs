using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medicines
    {
        public string id,mname,price;
        public void mainMenue()
        {
            int mh;
            Console.WriteLine("\n1: Add Medicines");
            Console.WriteLine("2: Disply Medicines Info");
            mh = Convert.ToInt16(Console.ReadLine());

            switch (mh)
            {
                case 1:
                    addmed();
                    break;

                case 2:
                    if (mname != null)
                        displymedInfo();
                    else
                        Console.WriteLine("No Medicines records available");
                    this.mainMenue();
                    break;
            }
        }

        public void addmed()
        {
            Console.Write("Enter Medicines ID: ");
            id = Console.ReadLine();
            Console.Write("Enter Medicines Name: ");
            mname = Console.ReadLine();
            Console.Write("Enter Medicines Price: ");
            price = Console.ReadLine();


            Console.Write("  Medicines has been added\n ");
            Console.Write("**************************");
            this.mainMenue();

        }

        public void displymedInfo()
        {
            Console.Write("\n\n**************************\n\n");

            Console.Write("Medicines Information:\n\n\n");
            Console.Write("ID: ");
            Console.WriteLine(this.id);
            Console.Write("Name: ");
            Console.WriteLine(this.mname);
            Console.Write("Price: $");
            Console.WriteLine(this.price);


            Console.Write("\n\n**************************\n\n");
        }

    }
}

