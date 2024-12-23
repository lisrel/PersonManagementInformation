using System;

namespace PersonManagementInformation
{
    public class Person
    {
        private int PersonID;
        private string Name;
        private int Age;
        private string Address;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int age
        {
            get { return Age; }
            set {
                if (value > 0)
                {
                    Age = value; 
                }
                else
                {
                    Console.WriteLine("Age must be greater than 0");
                }
                
            }
        }

        public string address
        {
            get { return Address; }
            set { Address = value; }
        }

        public int personID
        {
            get { return PersonID; }
            set { PersonID = value; }
        }

        public void DisplayPersonInformation(Person person)
        {
            Console.WriteLine($"Person ID: {person.PersonID}");
            Console.WriteLine("Name: " + person.name);
            Console.WriteLine("Age: " + person.age);
            Console.WriteLine("Address: " + person.address);
            
        }

        public static void UpdateAddress(Person person)
        {
            person.address = person.address + " " + person.address;
        }
        
    }
}