using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Jumper.Game
{
    /// <summary>
    /// <para>A service that handles terminal operations.</para>
    /// <para>
    /// The responsibility of a TerminalService is to provide input and output operations for the 
    /// terminal.
    /// </para>
    /// </summary>
    public class TerminalService
    {
        /// <summary>
        /// Constructs a new instance of TerminalService.
        /// </summary>
        public TerminalService()
        {
        }



        /// <summary>
        /// Gets numerical input from the terminal. Directs the user with the given prompt.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted number.</returns>
        public int ReadNumber(string prompt)
        {
            string rawValue = ReadText(prompt);
            return int.Parse(rawValue, System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets text input from the terminal. Directs the user with the given prompt.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted text.</returns>
        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            string text = Console.ReadLine();

            return text;
        }

        /// <summary>
        /// Gets a single character from the terminal. Directs the user with the given prompt.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted text.</returns>
        public string getOneInput(string prompt){
            string text = ReadText(prompt);
            if (text.Length > 1 )
            {
                Console.WriteLine("enter only one letter");
                return "";
            }else if (text.Length < 1)
            {
                Console.WriteLine("enter a letter");
                return "";
            }
            return text;
        }

        /// <summary>
        /// Displays the given text on the terminal. 
        /// </summary>
        /// <param name="text">The given text.</param>
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
        
        /// <summary>
        /// askes if the user wants to pay again and returns a bool 
        /// </summary>
        public bool PlayAgain()
        {
            string Again = ReadText("do you want to play Again [Y/N]: ").ToLower();
            switch (Again)
            {
                case "y":
                
                case "yes":

                    return true;
                case "n":

                case "no":
                    return false;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Displays the given text on the terminal with a space at the end of every char. 
        /// </summary>
        /// <param name="word">text to space out.</param>
        public void printSpacedWord(string Word){
            Console.WriteLine();
            for (int i = 0; i < Word.Length; i++){
                
                Console.Write($"{Word[i]} ");
                
            }
            Console.WriteLine("\n");
        }
    }
}