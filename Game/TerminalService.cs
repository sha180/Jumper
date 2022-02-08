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
        /// Displays the jumper based on how mnay lives. 
        /// </summary>
        /// <param name="text">lives int.</param>
        public static void DrawJumper(int lives){
            
            Debug.Assert(lives > -1 && lives < 5);

            switch (lives)
            {
                case 4:
                    Console.WriteLine("  ___");
                    Console.WriteLine(" /___\\");
                    Console.WriteLine(" \\   /");
                    Console.WriteLine("  \\ /");
                    Console.WriteLine("   O");
                    Console.WriteLine("  /|\\");
                    Console.WriteLine("  / \\");
                    break;
                case 3:
                    Console.WriteLine(" /___\\");
                    Console.WriteLine(" \\   /");
                    Console.WriteLine("  \\ /");
                    Console.WriteLine("   O");
                    Console.WriteLine("  /|\\");
                    Console.WriteLine("  / \\");
                    break;
                case 2:
                    Console.WriteLine(" \\   /");
                    Console.WriteLine("  \\ /");
                    Console.WriteLine("   O");
                    Console.WriteLine("  /|\\");
                    Console.WriteLine("  / \\");
                    break;
                case 1:
                    Console.WriteLine("  \\ /");
                    Console.WriteLine("   O");
                    Console.WriteLine("  /|\\");
                    Console.WriteLine("  / \\");
                    break;
                case 0:
                    Console.WriteLine("   x");
                    Console.WriteLine("  /|\\");
                    Console.WriteLine("  / \\");
                    break;
                default:
                    Console.WriteLine("not " + lives);
                    break;

            }
                Console.WriteLine("\n^^^^^^^\n");
                
        }

        public void printWord(string Guessedword){

            for (int i = 0; i < Guessedword.Length; i++){
                
                Console.Write($"{Guessedword[i]} ");
                
            }
            Console.WriteLine("\n");

        }


    }
}