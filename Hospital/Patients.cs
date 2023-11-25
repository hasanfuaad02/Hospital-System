using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hospital
{
    public class patient
    {
        public string pname, phone, id, age, status, gender, date;
        public void mainMenue()
        {
            int ch;
            Console.WriteLine("\n1: Add Patint");
            Console.WriteLine("2: Disply Patint Info");
            Console.WriteLine("3: Delet Patint ");
            Console.WriteLine("4: Edite Patint Info  ");
            Console.WriteLine("5: Serch by ID ");
            Console.WriteLine("6: Back ");
            Console.WriteLine("7: Exit\n");
            ch = Convert.ToInt16(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    //p = new patient();
                    addpatint();
             
                    break;

                case 2:
                    if (pname != null)
                        displyPatintInfo();
                    else
                        Console.WriteLine("No Patients records available");
                    this.mainMenue();
                    break;

                case 3:

                    deletepatient();
                    this.mainMenue();
                    break;

                case 4:

                    editpatint();
                    this.mainMenue();
                    break;

                case 7:
                    Console.WriteLine("\n************ Exit ***********\n");

                    break;

                default:
                    if (ch == 3)
                        return;
                    else
                    {
                        Console.WriteLine("Enter a right choice");
                        this.mainMenue();
                    }
                    break;
            }
        }
        public void addpatint()
        {
            Console.Write("Enter Patient ID: ");
            id = Console.ReadLine();
            Console.Write("Enter Patient Name: ");
            pname = Console.ReadLine();
            Console.Write("Enter Patient Phone: ");
            phone = Console.ReadLine();
            Console.Write("Enter Patient Age: ");
            age = Console.ReadLine();
            Console.Write("Enter Patient Status: ");
            status = Console.ReadLine();
            Console.Write("Enter Patient Gender: ");
            gender = Console.ReadLine();
            Console.Write("Enter Patient Date: ");
            date = Console.ReadLine();

            Console.Write("  Patient has been added\n ");
            Console.Write("**************************");
            this.mainMenue();

        }
        public void displyPatintInfo()
        {
            Console.Write("\n\n**************************\n\n");
            Console.Write("Patint Information:\n\n\n");
            Console.Write("ID: ");
            Console.WriteLine(this.id);
            Console.Write("Name: ");
            Console.WriteLine(this.pname);
            Console.Write("Phone: ");
            Console.WriteLine(this.phone);
            Console.Write("Age: ");
            Console.WriteLine(this.age);
            Console.Write("Status: ");
            Console.WriteLine(this.status);
            Console.Write("Gender: ");
            Console.WriteLine(this.gender);
            Console.Write("Date: ");
            Console.WriteLine(this.date);
            Console.Write("\n\n**************************\n\n");
        }

        public void editpatint()
        {
            FileStream infile = new FileStream(@"tst.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader("tst.txt");
            string srpa;
            string readfile;
            string output;
            Console.Write("Enter Patient Name :");
            srpa = Console.ReadLine();
            readfile = File.ReadAllText("tst.txt");
            if (readfile.Contains(srpa))
            {
                output = reader.ReadLine();
                Console.WriteLine(output);
                infile.Close();
                reader.Close();
            }
            Console.Write("Enter Patient ID: " + id + ": ");
            id = Console.ReadLine();
            Console.Write("Enter Patient Name: " + pname + ": ");
            pname = Console.ReadLine();
            Console.Write("Enter Patient Phone: " + phone + ": ");
            phone = Console.ReadLine();
            Console.Write("Enter Patient Age: " + age + ": ");
            age = Console.ReadLine();
            Console.Write("Enter Patient Status: " + status + ": ");
            status = Console.ReadLine();
            Console.Write("Enter Patient Gender: " + gender + ": ");
            gender = Console.ReadLine();
            Console.Write("Enter Patient Gender: " + date + ": ");
            gender = Console.ReadLine();
            Console.Write(" Patient has been edited\n ");
            Console.Write("**************************");
            this.mainMenue();

        }

        public void deletepatient()
        {
            this.id = null;
            this.pname = null;
            this.phone = null;
            this.age = null;
            this.status = null;
            this.gender = null;
            this.date = null;
            Console.WriteLine("\n\n &&&& Recored has been deleted &&&&&");
        }
    }
}
