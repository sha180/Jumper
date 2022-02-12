using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Jumper.Game
{
    public class JumperDraw
    {
        List<string> JumperArt = new List<string>();
        public JumperDraw()
        {
            
            JumperArt.Add("  \\ /");
            JumperArt.Add(" \\   /");
            JumperArt.Add(" /___\\");
            JumperArt.Add( "  ___");

            JumperArt.Add("   O");
            JumperArt.Add("   X");
            
            JumperArt.Add("  /|\\");
            JumperArt.Add("  / \\");

        }


        public string stringBuilder(int lives)
        {
            string output = "";
            for (int i = lives - 1; i > -1; i --)
            {
                if(i <= lives)
                {
                    output += JumperArt[i] + "\n";
                }else
                {
                    output += "\n";
                }
            }

            if (lives == 0)
            {
                output += JumperArt[5] + "\n";
            }else
            {
                output += JumperArt[4] + "\n";
            }

                output += JumperArt[6] + "\n";

                output += JumperArt[7] + "\n";

            output += "\n^^^^^^^\n";

            return output;
        }
        // public static void DrawJumper(int lives){
        //     switch (lives)
        //     {
        //         case 4:
        //             Console.WriteLine("  ___\n");
        //             Console.WriteLine(" /___\\");
        //             Console.WriteLine(" \\   /");
        //             Console.WriteLine("  \\ /");
        //             Console.WriteLine("   O");
        //             Console.WriteLine("  /|\\");
        //             Console.WriteLine("  / \\");
        //             break;
        //         case 3:
        //             Console.WriteLine(" /___\\");
        //             Console.WriteLine(" \\   /");
        //             Console.WriteLine("  \\ /");
        //             Console.WriteLine("   O");
        //             Console.WriteLine("  /|\\");
        //             Console.WriteLine("  / \\");
        //             break;
        //         case 2:
        //             Console.WriteLine(" \\   /");
        //             Console.WriteLine("  \\ /");
        //             Console.WriteLine("   O");
        //             Console.WriteLine("  /|\\");
        //             Console.WriteLine("  / \\");
        //             break;
        //         case 1:
        //             Console.WriteLine("  \\ /");
        //             Console.WriteLine("   O");
        //             Console.WriteLine("  /|\\");
        //             Console.WriteLine("  / \\");
        //             break;
        //         case 0:
        //             Console.WriteLine("   x");
        //             Console.WriteLine("  /|\\");
        //             Console.WriteLine("  / \\");
        //             break;
        //         default:
        //             break;

        //     }
        //         Console.WriteLine("\n^^^^^^^\n");
        // }
        
        
    }
    
}