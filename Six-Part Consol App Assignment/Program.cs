using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Build sentences by merging arrays and user input
        string[] wordstart = {
            "Welcome to the ",
            "I'm Principal, ",
            "Our goal is to provide our students with a "
        };
        string[] wordend = {
            " Academy.",
            ".",
            " learning experience."
        };

        var responses = new List<string>();
        Console.WriteLine("Please enter a noun:");
        responses.Add(Console.ReadLine());
        Console.WriteLine("Please enter the name of someone infamous:");
        responses.Add(Console.ReadLine());
        Console.WriteLine("Please enter an adjective:");
        responses.Add(Console.ReadLine());

        // Part 2
        // Fixed loop: no longer decrements i, so it terminates properly
        for (int i = 0; i < wordstart.Length; i++)
        {
            wordstart[i] += responses[i];
            Console.WriteLine(wordstart[i] + wordend[i]);
        }

        Console.WriteLine("\nThe strings we used:");
        for (int i = 0; i < wordstart.Length; i++)
        {
            Console.WriteLine(wordstart[i] + wordend[i]);
        }
        Console.ReadLine();

        // Part 3: StringBuilder with '<' and '<=' conditions
        Console.WriteLine("Is that a ghost?!");
        var boo = new StringBuilder("B");
        while (boo.Length < 10)
        {
            boo.Append("o");
        }
        boo.Append("!");
        Console.WriteLine(boo);
        Console.ReadLine();

        var ahh = new StringBuilder("A");
        while (ahh.Length <= 10)
        {
            ahh.Append("h");
        }
        ahh.Append("!");
        Console.WriteLine(ahh);
        Console.ReadLine();

        // Part 4: Search NBA teams and report index + standing
        var teams = new List<string> {
            "Lakers","Warriors","Nets","Bucks","Celtics",
            "Raptors","Heat","76ers","Suns","Mavericks",
            "Clippers","Jazz","Nuggets","Wizards","Hawks"
        };

        Console.WriteLine("NBA Eastern Conference Standings");
        int standing;
        int index;
        bool isValid = false;

        while (!isValid)
        {
            Console.WriteLine("Please enter the name of an NBA team:");
            string request = Console.ReadLine();
            standing = 0;
            index = -1;

            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Equals(request, StringComparison.OrdinalIgnoreCase))
                {
                    standing = i + 1;
                    index = i;
                    break; // stop iterating once we find the team
                }
            }

            if (standing == 0)
            {
                Console.WriteLine("That is not a valid NBA team. Please try again.");
            }
            else
            {
                Console.WriteLine($"Processing... Index is: {index}. So...");
                Console.WriteLine($"Standing is: {standing}");
                isValid = true;
            }
        }
        Console.ReadLine();

        // Part 5: Table status lookup
        var tables = new List<string> {
            "Reserved","Vacant","Taken","Vacant",
            "Vacant","Reserved","Taken"
        };

        Console.WriteLine(
            "Welcome to Swell Taco!\n" +
            "Due to COVID restrictions, we have a computerized check-in system.\n" +
            "If you have a reservation type \"Reserved\".\n" +
            "If you are joining a party that is already here type \"Taken\".\n" +
            "Otherwise, type \"Vacant\"."
        );

        Console.WriteLine("Enter selection:");
        string selection = Console.ReadLine();
        while (!tables.Contains(selection, StringComparer.OrdinalIgnoreCase))
        {
            Console.WriteLine("Please enter one of the 3 choices:");
            selection = Console.ReadLine();
        }

        Console.WriteLine("The tables that match your selection are numbered:");
        for (int i = 0; i < tables.Count; i++)
        {
            if (tables[i].Equals(selection, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine(i);
        }
        Console.ReadLine();

        // Part 6: Detect repeated names in a roster
        var names = new List<string> {
            "Alice","Bob","Charlie","Alice","Eve","Bob","Frank"
        };
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        Console.WriteLine("Class Roster:");
        foreach (var name in names)
        {
            Console.Write(name);
            if (seen.Contains(name))
            {
                Console.WriteLine(" - This name has been repeated. Use last name initial when referring to this student.");
            }
            else
            {
                Console.WriteLine(" - This name has not been repeated.");
                seen.Add(name);
            }
        }
        Console.ReadLine();
    }
}