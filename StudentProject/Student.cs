using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject {

    public class Student {

        // default constructor - auto created by VS.NET if no other constructors exist
        public Student() {
            firstName = "George";
            lastName = "Smith";
        }
        public Student(string firstName, string lastName) 
            : this(firstName, lastName, null, null) {
        }
        public Student(string firstName, string lastName, string email, string phone) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
        }

        private string firstName;
        private string lastName;
        private string email;
        private string phone;

        public string GetFirstName() {
            return firstName;
        }
        public void SetFirstName(string firstName) {
            this.firstName = firstName;
        }
        public string GetLastName() {
            return lastName;
        }
        public void SetLastName(string lastName) {
            this.lastName = lastName;
        }
        public string GetFullName() {
            return GetFirstName() + " " + GetLastName();
        }
        public string GetEmail() {
            return email;
        }
        public void SetEmail(string email) {
            this.email = email;
        }
        public string GetPhone() {
            return phone;
        }
        public void SetPhone(string phone) {
            this.phone = phone;
        }

        public void Display() {
            Console.WriteLine(GetFullName());
            Console.WriteLine(GetEmail());
            Console.WriteLine(GetPhone());
            Console.WriteLine("...press any key to continue");
            Console.ReadKey();
        }

        public string Print() {
            return firstName + " " + lastName + "|" + email + "|" + phone;
        }
    }
}
