using System;

namespace rpsCSharp.Models
{
  public class Game
  {
    public string CompChoice { get; private set; }
    public string UserChoice { get; set; }
    public string Play()
    {
      Console.WriteLine("Computer played " + CompChoice);
      if (CompChoice == UserChoice)
      {
        return "It's a tie. Try again!";
      }
      else if (CompChoice == "ROCK" && UserChoice == "PAPER" 
        || CompChoice == "PAPER" && UserChoice =="SCISSORS" 
        || CompChoice == "SCISSORS" && UserChoice =="ROCK")
        {
        return "You win! " + UserChoice + " beats " + CompChoice;
      }
      else
      {
        return "You lose! " + CompChoice + " beats " + UserChoice;
      }
      
    }
    public void GetCompChoice()
    {
      Random rand = new Random();
      string choice;
      int randInt = rand.Next(1, 4);
      if(randInt == 1){
        choice = "ROCK";
      }
      else if (randInt == 2){
        choice = "PAPER";
      }
      else{
        choice = "SCISSORS";
      }
      CompChoice = choice;
    }
    public void UpdateUserChoice(string userChoice)
    {
      UserChoice = userChoice.ToUpper();
    }

    public Game()
    {
      CompChoice = "";
      UserChoice = "";
    }
  }
}