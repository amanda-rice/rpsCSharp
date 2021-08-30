
using System;
using rpsCSharp.Models;

namespace rpsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
      bool isPlaying = true;
            while(isPlaying)
            {
        getInput();
      }
        }
        public static void getInput()
        {
      Console.WriteLine("Rock, Paper Scissors!");
            string userChoice = Console.ReadLine();
            if(userChoice.ToUpper() != "ROCK" && userChoice.ToUpper() != "PAPER" && userChoice.ToUpper() != "SCISSORS")
            {
                Console.WriteLine("Please enter rock, paper, or scissors");
                getInput();
            }
            else
            {
                Game myGame = new Game();  
                myGame.GetCompChoice();
                myGame.UpdateUserChoice(userChoice);
                Console.WriteLine(myGame.Play());
            }
    }
    }
}
