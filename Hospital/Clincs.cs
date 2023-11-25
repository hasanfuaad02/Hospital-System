using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Clincs
    {
        public string id, cname, workday;
        public void mainMenue()
        {
            int cch;
            Console.WriteLine("\n1: Add Clinc");
            Console.WriteLine("2: Disply Clinc Info");
            cch = Convert.ToInt16(Console.ReadLine());

            switch (cch)
            {
                case 1:
                    addclinc();
                    break;

                case 2:
                    if (cname != null)
                        displyclincInfo();
                    else
                        Console.WriteLine("No Clincs records available");
                    this.mainMenue();
                    break;
            }
        }


        public void addclinc()
        {
            Console.Write("Enter Clinc ID: ");
            id = Console.ReadLine();
            Console.Write("Enter Clinc Name: ");
            cname = Console.ReadLine();
            Console.Write("Enter Clinc Working_day: ");
            workday = Console.ReadLine();
           

            Console.Write("  Clinc has been added\n ");
            Console.Write("**************************");
            this.mainMenue();

        }

        public void displyclincInfo()
        {
            Console.Write("\n\n**************************\n\n");

            Console.Write("Doctor Information:\n\n\n");
            Console.Write("ID: ");
            Console.WriteLine(this.id);
            Console.Write("Name: ");
            Console.WriteLine(this.cname);
            Console.Write("Working_day: ");
            Console.WriteLine(this.workday);
            

            Console.Write("\n\n**************************\n\n");
        }

    }

}

