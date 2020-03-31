using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D3maryPoppins
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Morning Challenge: W1D3
            Conditionals & Loops Challenge
            Print every letter of the word "Supercalifragilisticexpialidocious" to the console. 
            Print every 'i' in the word and if the letter is not 'i' print “Not an i”

            Bonus: Print the count of how many letters in the word (do this without counting it yourself).

            Another Bonus: After you determine if the letter is or isn't, i determine if the letter is 'L'. If that is true, print that letter. Change the else message to make sense.


                     I have made this in a console app since the prompt does not ask for a method. It is just asking to print to the console. This could also be done in a Unit Test class*/

            //PART ONE
            var word = "Supercalifragilisticexpialidocious";
            
            //Print out each letter
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }
            //print out only the I
            foreach (char letter in word)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }

            //BONUS
            foreach (char letter in word)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }
            Console.WriteLine(word.Length);

            //ANOTHERBONUS 
            foreach (char letter in word)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else if(letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("I am not an I or a L");
                }
            }


            Console.ReadKey();

        }
    }
}
