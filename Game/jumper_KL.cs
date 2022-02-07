
using System;
using System.Collections.Generic;

 

// class 2 to manage jumper image
class Jumper
{

 
   //   a variable first before using to declare jumper
   // use List of type string
   
   private List<string> jumper;

 

   // init method
   public Jumper()
   {

 

       // jumper image stored in a list


       this.jumper = new List<string> {"  ___ ",
           " /___\\ ",
           "  \\ / ",
           "  \\ / ",
           "   0 ",
           "  /|\\ ",
           "  / \\ ",
           " ",
           "^^^^^^^"};
   }

 

   // print jumper diagram
   public void Draw()
   {

 

       // use foreach and in
       //   for the enhanced
       //   for loop for C#
       foreach (string line in this.jumper)
       {
           Console.WriteLine(line);
       }
   }

 

   // update for a wrong guess
   public void Reduce()
   {

 

       // remove 0th row of jumper image

 

       // use RemoveAt with parameter
       //   0 to remove the 0th
       //   row of jumper image
       this.jumper.RemoveAt(0);
       if (this.jumper.Count == 5)
       {
           this.jumper[0] = " X ";
       }
   }

 

   // check if exhausted all wrong guess
   public bool Finished()
   {

 

       // jumper image list has only 5 rows
       if (this.jumper.Count == 5)
       {

 

           // game over
           return true;
       }
       else
       {

 

           // game not over
           return false;
       }
   }
}