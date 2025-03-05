using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_and_split_filter_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an instance of the Filter class
                Filter filter = new Filter();
            }
            catch (Exception ex)
            {
                // Catch any unexpected errors
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

    class Filter
    {
        // Constructor
        public Filter()
        {
            try
            {
                // Variable declaration and initialization
                ArrayList question = new ArrayList();
                ArrayList ignore = new ArrayList();

                // Store a sample question
                question.Add("password have to be protected");

                // Add words to be ignored
                ignore.Add("will");
                ignore.Add("the");
                ignore.Add("about");

                // Prompt the user for a question
                Console.WriteLine("Enter your question:");
                string ask = Console.ReadLine();

                // Handle empty input
                if (string.IsNullOrWhiteSpace(ask))
                {
                    throw new ArgumentException("Input cannot be empty. Please enter a valid question.");
                }

                // Split the user's input into an array of words
                string[] filtered_q = ask.Split(' ');
                ArrayList correct_filtered = new ArrayList();

                // Boolean flag to check if a word is found
                bool found = false;

                // Iterate over each word in the user's input
                for (int count = 0; count < filtered_q.Length; count++)
                {
                    // If the word is not in the ignore list, add it to the filtered list
                    if (!ignore.Contains(filtered_q[count]))
                    {
                        found = true;
                        correct_filtered.Add(filtered_q[count]);
                    }
                }

                // Check if at least one valid word was found
                if (found)
                {
                    bool matchFound = false;

                    // Loop through the filtered words
                    for (int counting = 0; counting < correct_filtered.Count; counting++)
                    {
                        // Compare filtered words with stored questions
                        for (int count = 0; count < question.Count; count++)
                        {
                            // If a match is found, display it
                            if (question[count].ToString().Contains(correct_filtered[counting].ToString()))
                            {
                                Console.WriteLine("Match found: " + question[count]);
                                matchFound = true;
                            }
                        }
                    }

                    // If no matches were found, notify the user
                    if (!matchFound)
                    {
                        Console.WriteLine("No relevant matches found in stored questions.");
                    }
                }
                else
                {
                    // Display message if no relevant words were found
                    Console.WriteLine("No matching words found.");
                }
            }
            catch (ArgumentException ex)
            {
                // Handle invalid input
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Catch unexpected errors
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
