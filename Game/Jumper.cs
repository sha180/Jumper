using System;

namespace Jumper.Game
{
    public class JumperDraw
    {
        public JumperDraw()
        {

        }

        public static void DrawJumper(int lives){
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
                    break;

            }
                Console.WriteLine("\n^^^^^^^\n");
        }
        
        
    }
    
}