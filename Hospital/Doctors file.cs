using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Doctors_file
    {
        public string id, dname, birthday, clinic;
        public void mainMenue()
        {
            int dh;
            Console.WriteLine("\n1: Add Doctor");
            Console.WriteLine("2: Disply Doctor Info");
            dh = Convert.ToInt16(Console.ReadLine());

            switch (dh)
            {
                case 1:
                    adddoctor();
                    break;

                case 2:
                    if (dname != null)
                        displydoctorInfo();
                    else
                        Console.WriteLine("No Doctors records available");
                    this.mainMenue();
                    break;
            }
        }

        public void adddoctor()
        {
            Console.Write("Enter Doctor ID: ");
            id = Console.ReadLine();
            Console.Write("Enter Doctor Name: ");
            dname = Console.ReadLine();
            Console.Write("Enter Doctor Birthday: ");
            birthday = Console.ReadLine();
            Console.Write("Enter Doctor Clinic: ");
            clinic = Console.ReadLine();

            Console.Write("  Doctor has been added\n ");
            Console.Write("**************************");
            this.mainMenue();

        }

        public void displydoctorInfo()
        {
            Console.Write("\n\n**************************\n\n");

            Console.Write("Doctor Information:\n\n\n");
            Console.Write("ID: ");
            Console.WriteLine(this.id);
            Console.Write("Name: ");
            Console.WriteLine(this.dname);
            Console.Write("Birthday: ");
            Console.WriteLine(this.birthday);
            Console.Write("Clnic: ");
            Console.WriteLine(this.clinic);

            Console.Write("\n\n**************************\n\n");
        }

    }
}  
