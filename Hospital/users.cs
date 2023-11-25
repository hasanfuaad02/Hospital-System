using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class user
    {
        string id = "admin";
        string pass = "admin";
        string uid, upass;
        public char flag;

        public void userInfo()
        {
            char choice;
            Console.Write("\nEnter you ID:  ");
            uid = Console.ReadLine();
            Console.Write("\nEnter you Password:  ");
            upass = Console.ReadLine();
            if (uid == id && upass == pass)
            {
                Console.WriteLine("Succfull Login");
                flag = '1';
            }
            else
            {
                Console.WriteLine("Sorry ... You have Entered wrong id or password\n");
                Console.WriteLine("Try Again? Y/N");
                choice = Console.ReadLine()[0];
                if (choice == 'Y' || choice == 'y')
                    this.userInfo();
                else
                    if (choice == 'N' || choice == 'n')
                {
                    Console.WriteLine("Thanx 4 using the program");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("Sorry ...  wrong choice");
                    return;
                }

            }


        }
    }
}
