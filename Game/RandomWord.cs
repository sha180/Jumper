using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Jumper.Game
{
    public class RandomWord
    {
        
        static string DATA_PATH = "Game/wordlist.txt";
        List<string> wordlist = File.ReadAllLines(DATA_PATH).ToList<string>();
        public RandomWord()
        {

        }
        
        
        public string getNewWord()
        { 
            Random random = new Random();
            int index = random.Next(wordlist.Count);
            return wordlist[index];

            
        }
        


    }
    
}