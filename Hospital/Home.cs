using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Home
    {
        public void mainMenue()
        {
            int ho;
            Console.WriteLine("\n1:Patint");
            Console.WriteLine("2:labority");
            Console.WriteLine("3:Medicines");
            Console.WriteLine("4:Clinics  ");
            Console.WriteLine("5:Doctor files");
            Console.WriteLine("6: Exit\n");
            ho = Convert.ToInt16(Console.ReadLine());
            switch (ho)
            {
                case 1:
                    patient p = new patient();
                    p.mainMenue();

                    //p = new patient();
                    //patient();
                    break;


                case 2:
                    Laboratory la = new Laboratory();
                    la.mainMenue();
                    break;



                case 3:
                    Medicines m = new Medicines();
                    m.mainMenue();
                    break;

                case 4:
                    Clincs cl = new Clincs();
                    cl.mainMenue();
                    break;


                case 5:
                    Doctors_file d = new Doctors_file();
                    d.mainMenue();
                    break;

                case 6:
                    Console.WriteLine("\n************ Exit ***********\n");

                    break;

                default:
                    if (ho == 3)
                        return;
                    else
                    {
                        Console.WriteLine("Enter a right choice");
                        this.mainMenue();
                    }
                    break;



            }



        }
    }
}
