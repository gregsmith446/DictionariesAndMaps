using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8DictsAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            // create dictionary of strings with string keys and string values
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            // prompt user for how many entries they will add to the dict
            Console.WriteLine("# of entries adding to phonebook");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            // prompt user num number of times for entries
            while (i < num)
            {
                Console.WriteLine("Enter {0} entry/entries.", num);
                Console.WriteLine("The first value is an all lowercase first name, and the second value is an 8-digit phone number with no spaces. Example: 'greg 12345678'  Hit return after each complete entry.");

                try
                {
                    openWith.Add(Console.ReadLine(), Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Element with that name already exists.");
                }   
                i++;
            }

            // After the lines of phone book entries, there are an unknown number of lines of queries. 
            // Each line (query) contains a first name to look up, and you must continue reading lines until there is no more input.
            Console.WriteLine("Now please enter a first name to lookup in the phonebook.");

            string[] queryArray = new string[10];
            int test = 2;

            // if the console is still getting queries
            // add them to the query array
            if (Console.ReadLine() != null)
            {
                for (i = 0; i < test; i++)
                {
                    queryArray[i] = Console.ReadLine();
                    Console.WriteLine("Add another query? If not, press enter to complete program.");
                }
            }
            else
            {
                // do the query and print the results             
            }

            foreach (string query in queryArray)
            {
                Console.WriteLine(query);
            }


            // need a way to be able to open the key value pair if the name is given in the query
            /*
            if (openWith.ContainsKey(queries))
            {

            }
            */


            /*
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("They key is {0}, and the Value is {1}", kvp.Key, kvp.Value);
            }
            */
        }
    }
}
