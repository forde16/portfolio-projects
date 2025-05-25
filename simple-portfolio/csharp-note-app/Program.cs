using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> notes = new List<string>();
        while (true)
        {
            Console.WriteLine("1. Add Note\n2. View Notes\n3. Exit");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Write("Enter note: ");
                string note = Console.ReadLine();
                notes.Add(note);
            }
            else if (input == "2")
            {
                Console.WriteLine("Your Notes:");
                foreach (var n in notes)
                {
                    Console.WriteLine("- " + n);
                }
            }
            else if (input == "3")
                break;
            else
                Console.WriteLine("Invalid choice.");
        }
    }
}
