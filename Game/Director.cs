using System.Diagnostics;

namespace Jumper.Game
{
    public class Director
    {
        bool playGame = true;
        TerminalService terminalService = new TerminalService();


        public Director()
        {

        }


        /// <summary>
        /// starts the game and runs the game loop.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted text.</returns>
        public void StartGame()
        {
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

        }
        /// <summary>
        /// Allow the user to interact with the game.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted text.</returns>
        private void interact()
        {
            string letter = terminalService.getOneInput("guess a letter [A-z]: ");
            Debug.Assert(letter.Length == 1);
            

        }

        /// <summary>
        /// test if the game over sequince is met.
        /// than asks if the player wants to go again.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted text.</returns>
        private void isGameOver()
        {

        }
    }
}