using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hospital
{
    class Program
    {
            static void Main(string[] args)
            {
                Home h = new Home();
                patient p = new patient();
                Doctors_file d = new Doctors_file();
                Medicines m = new Medicines();
                Clincs cl = new Clincs();
            

            // File.WriteAllText("tst1.txt", "hello");

            string path = @"tst.txt";

                   //string lines;

                   if ( File.Exists(path)) Console.WriteLine("file exixt\n");
                   else Console.WriteLine("file not exixt\n");

            string path1 = @"mtst.txt";

            //string lines;

            if (File.Exists(path1)) Console.WriteLine("file exixt\n");
            else Console.WriteLine("file not exixt\n");



            Console.WriteLine("**************************Hospital System************************");
                user user1 = new user();
                user1.userInfo();
                char c = user1.flag;
                if (c == '1')
                    h.mainMenue();
                else
                    return;
                


                Console.ReadKey();
            }
        }
    }

