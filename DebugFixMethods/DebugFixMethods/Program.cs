/* Ryan Hutton
 * Module 3 Activity - Debug and Fix Errors
 * SNHU IT 230 - Software Dev with C#.NET
 * 11/13/19
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFixMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            string choice = "";

            writePrompt();
            choice = readChoice();
            writeChoice(choice);
        }

        void writePrompt()
        {
            Console.WriteLine("Please select a course for which you want to register by typing the number inside []");
            Console.WriteLine("[1]IT 145\n[2]IT 200\n[3]IT 201\n[4]IT 270\n[5]IT 315\n[6]IT 328\n[7]IT 330");
            Console.Write("Enter your choice : ");
        }

        string readChoice()
        {
            string s = "";
            s = Console.ReadLine();
            return (s);
        }

        void writeChoice(string choice)
        {
            Console.WriteLine("Your choice is {0}", choice);
        }
    }
}
