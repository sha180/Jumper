using System.Diagnostics;


namespace Jumper.Game
{
    public class Director
    {
        bool playGame = true;
        int lives = 4;
        TerminalService terminalService = new TerminalService();
        PlayerDS player;
        JumperDraw jumper = new JumperDraw();

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
            string word = randomWord.getNewWord();
            player.setNewWord(word);
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
            string jumperArt = jumper.stringBuilder(lives);
            
            terminalService.printSpacedWord(player.getGuess());
            terminalService.WriteText(jumperArt);

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
                string jumperArt = jumper.stringBuilder(lives);
                terminalService.printSpacedWord(player.getWord());
                terminalService.WriteText(jumperArt);
                // TerminalService.DrawJumper(lives);

                
            }
            // terminalService.WriteText($"{playGame}");
            // playGame = player.WordComplete();
            // playGame = false;
        }
    }
}