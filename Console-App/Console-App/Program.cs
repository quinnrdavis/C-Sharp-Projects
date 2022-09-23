using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART ONE
            // create array of strings
            string[] strings = new string[] { "this", "is", "an", "array", "of", "strings" };
            // ask for input text from user
            Console.WriteLine("Please input some text:");
            // store input
            string userInput = Console.ReadLine();

            // add input to each string in array
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] += userInput;
            }

            // print each string
            for (int j = 0; j < strings.Length; j++)
            {
                Console.WriteLine(strings[j]);
            }
            // --------------------------------------------------------

            // PART TWO
            // initialize variable for loop
            int x = 5;
            // was infinite loop at first when x didn't increment
            while (x < 10)
            {
                Console.WriteLine(x);
                // added a line to increment x so the loop is no longer infinite
                x++;
            }
            // --------------------------------------------------------

            // PART THREE
            // initialize variable for loop
            int y = 7;
            // loop with <
            while (y < 13)
            {
                Console.WriteLine(y);
                y++;
            }

            // initialize variable for loop
            int z = 4;
            // loop with <=
            while (z <= 8)
            {
                Console.WriteLine(z);
                z++;
            }
            // --------------------------------------------------------

            // PART FOUR
            // a list of unique strings
            List<string> stringList = new List<string>() { "this", "is", "a", "list", "of", "unique", "strings" };       
            // variable to control the loop
            bool looping = true;
            do
            {
                // ask for input
                Console.WriteLine("Please input text to search for a unique string in the list");
                // get input to search list
                string userInput2 = Console.ReadLine();
                // variable to keep track of list index
                int index = 0;
                foreach (string str in stringList)
                {                    
                    // check each item in list
                    // if match is found, print index, set looping to false to exit do while loop, and break foreach loop
                    if (str.Contains(userInput2)) {
                        Console.WriteLine(index);
                        looping = false;
                        break;
                    }
                    // if a match is not found, increment index and move on to next element of the list
                    index++;
                }
                // if index is greater than 6 then a match was not made, print error message
                if (index > 6)
                {
                    Console.WriteLine("Input not found in list, try again.");
                }
                
            }
            while (looping);
            // --------------------------------------------------------

            // PART FIVE
            // a list of non unique strings
            List<string> stringList2 = new List<string>() { "these", "are", "the", "strings", "the", "strings", "are", "not", "unique" };
            // ask for input
            Console.WriteLine("Please input text to search for any matching strings in the list");
            // get input
            string userInput3 = Console.ReadLine();
            // variable to keep track of index
            int index2 = 0;
            // initialize list to hold indices of matching items
            List<int> indices = new List<int>();
            // search list for matching
            foreach (string str in stringList2)
            {              
                // if current element matches, add index to list
                if (str.Contains(userInput3))
                {
                    indices.Add(index2);
                }
                // increment index
                index2++;
            }
            // if nothing was added to the list of indices, there was no match, print message telling the user
            if (indices.Count == 0)
            {
                Console.WriteLine("Your input was not in the list");
            } else
            // otherwise, print list of indices
            {
                foreach (int i in indices)
                {
                    Console.WriteLine(i);
                }
            }
            // --------------------------------------------------------

            // PART SIX
            // a list of strings that has at least two identical strings
            List<string> stringList3 = new List<string>() { "A", "B", "C", "A", "D", "C" };
            // string to hold strings that have been seen already
            string seenStrings = "";

            // iterate through each string in the list
            foreach (string str in stringList3)
            {
                // if the string is not in the container string, print it is unique and add it to the container string
                if (!seenStrings.Contains(str))
                {
                    Console.WriteLine(str + " - this item is unique");
                    seenStrings = seenStrings + str;
                }
                // otherwise print it is a duplicate
                else
                {
                    Console.WriteLine(str + " - this item is a duplicate");
                }
            }

            // --------------------------------------------------------

            Console.Read();
        }
    }
}
