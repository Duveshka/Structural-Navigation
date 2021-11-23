using System;
using System.Collections.Generic;
//namespaces
namespace Structural_Navigation
{
    //class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Test
    {
        private readonly List<string> _line;
        //constructor
        public Test(List<string> line)
        {
            _line = line;
        }

        public static string TestMethod()
        {
            const string a = "return";
            return a;
        }
        //method
        public void Loops()
        {
            //Loop For
            for (int i = 1, j = 1; i < 10; i++, j++)
            {
                Console.WriteLine($"{i * j}");
            }

            //do..while
            int i3 = 6;
            do
            {
                Console.WriteLine(i3);
                i3--;
            }
            while (i3 > 0);

            //while
            int i2 = 6;
            while (i2 > 0)
            {
                Console.WriteLine(i2);
                i2--;
            }
            //foreach
            foreach (char c in "Tom")
            {
                Console.WriteLine(c);
            }
        }
        //Switch
        public void Switch()
        {
            string name = "Tom";

            switch (name)
            {
                case "Bob":
                    Console.WriteLine("Bob");
                    break;
                case "Tom":
                    Console.WriteLine("Tom");
                    break;
                case "Sam":
                    Console.WriteLine("Sam");
                    break;
            }
        }
        //If
        public void If()
        {
            string name = "Alex";

            if (name == "Tom")
                Console.WriteLine("Tomas");
            else if (name == "Bob")
                Console.WriteLine("Robert");
            else if (name == "Mike")
                Console.WriteLine("Michael");
            else
                Console.WriteLine("Unknown");
        }

        public  Reminder AddReminder(int userId, Reminder reminderForAdd)
        {
            //+- and -=
            var a = 1;
            a += 10;
            a -= 10;
            //Line
            var reminder = new Reminder(reminderForAdd.DateTime,
                reminderForAdd.Name, reminderForAdd.Description, a);

           
            return reminder;
        }
    }
    //Record
    public record Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    //Structure
    struct Person2
    {
        public string name;
        public int age;

        public void Print()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    public class Reminder
    {
        public int ReminderId { get; set; }
        public DateTime DateTime { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        //Constructor
        public Reminder(DateTime DateTime, string Name, string Description, int UserId)
        {
            this.Name = Name;
            this.DateTime = DateTime;
            this.Description = Description;
            this.UserId = UserId;
        }
    }
}