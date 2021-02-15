using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    class Game
    {
        Dictionary<string, List<string>> moveList = new Dictionary<string, List<string>>();
        public Game()
        {
          moveList.Add("Rock", new List<string>(){"Scissors", "Lizard"});
          moveList.Add("Paper", new List<string>(){"Rock", "Spock"});
          moveList.Add("Scissors", new List<string>(){"Paper", "Lizard"});
          moveList.Add("Lizard", new List<string>(){"Paper", "Spock"});
          moveList.Add("Spock", new List<string>(){"Scissors", "Rock"});
        }

        public void Run()
        {
          bool running = true;
          while(running)
          {
            Console.WriteLine("Welcome to Rock, Paper, Scissors...Lizard Spock! Enter your move, or enter Q to exit.");
            string input = Console.ReadLine();
            if (moveList.ContainsKey(input))
            {
              Random ran = new Random();
              int oppRandom = ran.Next(moveList.Count);
              string oppMove = moveList.Keys.ElementAt(oppRandom);
              string result;
              List<string> playerBeats = moveList[input];
              if (playerBeats.Contains(oppMove))
              {
                result = "Win";
              }
              else if (input == oppMove)
              {
                result = "Tie";
              }
              else
              {
                result = "Lose";
              }
              Console.WriteLine("You " + result +"! You played " + input + ", and your opponent played " + oppMove + ".");
            }
            else if (input == "Q")
            {
              running = false;
            }
            else
            {
              Console.WriteLine("Invalid Input");
            }
          }
        }
    }
}
