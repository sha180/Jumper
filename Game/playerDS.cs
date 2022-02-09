using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace Jumper.Game
{
    public class PlayerDS
    {
        string word;
        string guess;
        bool isletterGuessed;

        public PlayerDS()
        {

        }
        public void setNewWord(RandomWord randomWord)
        { 
            word = randomWord.getNewWord();
            
            for (int i = 0; i < word.Length; i ++)
            {
                guess += '_';
            }
            
        }
        
        /// <summary>
        /// checkes if the "letter" is in the "word" and up dates guess if the letter is there.
        /// </summary>
        /// <param name="letter">The Letter to check.</param>
        /// <returns>Inputted number.</returns>
        public void updateGuess(string letter)
        {
            Debug.Assert(letter.Length == 1);

            isletterGuessed = false;

            char[] tmp = guess.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if(word[i] == letter[0] && tmp[i] == '_')
                {
                    tmp[i] = letter[0];
                    
                    isletterGuessed = true;

                }
            }

            guess = new string(tmp);
        }

        public string getGuess()
        {

            return guess;
        }
        public string getWord()
        {
            return word;
        }

        public bool CorrectLetter()
        {
            return isletterGuessed;
        }

        public bool WordComplete()
        {
            bool cont = false;
            int count = 0;
            foreach (char item in guess)
            {
                if (item != '_')
                {
                    count += 1;
                }
                
            }
            
            if (count == guess.Length)
                {
                    cont = true;
                }
                
            return cont;
        }
    }
}