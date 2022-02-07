using System;
using System.Collections.Generic;

 

// class 1 to store words list
class SecretWord
{

 
   //  declare a variable first before using
   //   wordlist and wordCount
   // use List of type string
   //   as a list for C#
   // random holds the random object
   //   to randomize a number
   //   between 0 and 9
   private List<string> wordlist;
   private int wordCount;
   private Random random;

 

   // init method
   public SecretWord()
   {

 

       // words list
       this.wordlist = new List<string> {"apple", "hello", "swimming", "dancing", "laptop",

 

 

       //  "computer", "window", "curtain", "orange", "fan"};
           "computer", "window", "curtain", "orange", "fan"};

 

       // total words in the list
       this.wordCount = 10;

 

       // instantiate random as a new
       //   Random object
       this.random = new Random();
   }

 

   // randomly get a word from the list
   public string GetRandomWord()
   {

 

       // generate random index within the range of word list

 

       // Random.Next(x, y) returns a random
       //   integer between x and y-1
       //   unlike Random.randint(x, y) returning
       //   a random integer between x and y
       //   so remove -1 and use this.wordCount
       //     only 
       int i = random.Next(0, this.wordCount);

 

       // return the word at the index
       return this.wordlist[i];
   }
}