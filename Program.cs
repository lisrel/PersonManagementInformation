using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagementInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            PersonManager personManager = new PersonManager();
            
            Console.Write("Enter Name");
            person.name = Console.ReadLine();
            
            Console.Write("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age>0 )
            {
                person.age = age;
            }
            else
            {
                Console.WriteLine("Age is invalid, re-Enter Age");
            }
            
            Console.Write("Enter Person ID");
            string personId = Console.ReadLine();
            person.personID = Convert.ToInt32(personId);
            
            Console.Write("Enter Address");
            string address = Console.ReadLine();
            person.address = address;

            person.DisplayPersonInformation(person);
        }
    }
}
