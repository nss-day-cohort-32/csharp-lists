using System;
using System.Collections.Generic;

namespace lists
{
    public class Program
    {
        public static void Main()
        {
            List<string> students = new List<string>() {
                "Megan", "Damon", "Chase", "Tekisha",
                "Castle", "Mark", "Keith", "Adam",
                "Patrick", "Hannah", "Mike"
            };

            students.ForEach(stu => Console.WriteLine(stu));

            // Can't do this easily with a base array
            students.Add("Melanie");
            Console.WriteLine("List of students after adding Melanie:");
            students.ForEach(stu => Console.WriteLine(stu));
            
            students.Insert(3, "Simon");
            Console.WriteLine("List of students after inserting Simon at index position 3:");
            students.ForEach(stu => Console.WriteLine(stu));

            if (students.Contains("DanceStorm")) {
                Console.WriteLine("Must be cohort 13");
            }
            else {
                Console.WriteLine("Another cohort");
            }

            List<string> newStudents = new List<string>() {
                "JR",
                "DanceStorm"
            };

            students.InsertRange(0, newStudents);

            Console.WriteLine("List of students after adding JR and DanceStorm");
            students.ForEach(stu => Console.WriteLine(stu));

            students.RemoveAt(5);
            Console.WriteLine("List of students after removing Simon:");
            students.ForEach(stu => Console.WriteLine(stu));

            string foundItem = students.Find(student => student.Length == 4);

            Console.WriteLine($"Found item: {foundItem}");

            List<String> foundItems = students.FindAll(student => student.Length == 4);

            Console.WriteLine("Found items:");
            foundItems.ForEach(stu => Console.WriteLine(stu));

            // This looks a lot like JavaScript!
        }
    }
}
