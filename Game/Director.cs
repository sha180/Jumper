using System.Diagnostics;


namespace Jumper.Game
{
    public class Director
    {
        bool playGame = true;
        int lives = 4;
        TerminalService terminalService = new TerminalService();
        PlayerDS player;

        RandomWord randomWord = new RandomWord();

        public Director()
        {
            player = new PlayerDS();


        }


        /// <summary>
        /// starts the game and runs the game loop.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted text.</returns>
        public void StartGame()
        {
            player.setNewWord(randomWord);
            while(playGame)
            {
                doOutputs();
                interact();
                isGameOver();
            }

        }

        /// <summary>
        /// output information the useser can interact with.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted text.</returns>
        private void doOutputs()
        {
            
            terminalService.printWord(player.getGuess());
            TerminalService.DrawJumper(lives);

        }
        /// <summary>
        /// Allow the user to interact with the game.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted text.</returns>
        private void interact()
        {
            string letter = terminalService.getOneInput("guess a letter [a-z]: ");
            Debug.Assert(letter.Length == 1);
            player.updateGuess(letter);
            terminalService.WriteText("");
            

        }

        /// <summary>
        /// test if the game over sequince is met.
        /// than asks if the player wants to go again.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted text.</returns>
        private void isGameOver()
        {
            if (!player.CorrectLetter())
            {
                lives --;
            }
            
            if (player.WordComplete()  !^ (lives < 1)) playGame = false;

            if (!playGame)
            {
                
                terminalService.printWord(player.getWord());
                TerminalService.DrawJumper(lives);

                
            }
            // terminalService.WriteText($"{playGame}");
            // playGame = player.WordComplete();
            // playGame = false;
        }
    }
}