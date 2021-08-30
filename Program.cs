
using System;
using rpsCSharp.Models;

namespace rpsCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome! To leave the game, type 'end'");
      bool isPlaying = true;
      while(isPlaying)
      {
        isPlaying = getInput();
      }
    }
    public static bool getInput()
    {
      Console.WriteLine("Rock, Paper Scissors!");
      string userChoice = Console.ReadLine();
      if(userChoice.ToUpper() != "ROCK" && userChoice.ToUpper() != "PAPER" && userChoice.ToUpper() != "SCISSORS")
      {
        if(userChoice.ToUpper() == "END"){
          return false;
        }
        else
        {
          Console.WriteLine("Please enter rock, paper, or scissors");
          getInput();
        }
      }
      else
      {
          Game myGame = new Game();  
          myGame.GetCompChoice();
          myGame.UpdateUserChoice(userChoice);
          Console.WriteLine(myGame.Play());
      }
      return true;
    }
  }
}
