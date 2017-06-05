using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject {

    class Program {

        string PromptUserInput(string prompt) {
            Console.Write(prompt);
            string response = Console.ReadLine();
            return response;
        }

        void Run() {
            Student stud1 = new Student();

            stud1.SetFirstName(PromptUserInput("Enter First Name: "));
            string lname = PromptUserInput("Enter Last Name: ");
            stud1.SetLastName(lname);
            string tempEmail = PromptUserInput("Enter Email: ");
            stud1.SetEmail(tempEmail);
            string tempPhone = PromptUserInput("Enter Phone: ");
            stud1.SetPhone(tempPhone);
            stud1.Display();

            Student studGeorge = new Student("George", "Smith");
            //studGeorge.Display();
            Student studAlex = new Student("Alex", "Cobb", "alex@aol.com", "513-555-1212");
            //studAlex.Display();
            studAlex.Print();
            string personalData = studAlex.Print();
            //Console.WriteLine(personalData);

            //User enters data
            //Console.Write("Enter some data: ");
            //string response = Console.ReadLine();
            //Console.WriteLine(response);
            //Console.ReadKey();
        }

        static void Main(string[] args) {
            (new Program()).Run();
        }
    }
}
