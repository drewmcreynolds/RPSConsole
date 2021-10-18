using System;
using System.Collections.Generic;

namespace RPSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello! Lets play Rock, Paper, Scissors");
           List<string> options = new List<string>() { "rock", "paper", "scissors" };
           bool playAgain = true;
           Random random = new Random();
           string comp;
           string player;
           Dictionary<string, List<string>> winCond = new Dictionary<string, List<string>>(){
               { "rock", new List<string>(){"scissors"}},
               { "paper", new List<string>(){"rock"}},
               { "scissors", new List<string>(){"paper"}}
           };
        while (playAgain){
            comp = options[random.Next(options.Count)];
            Console.Write("Pick your weapon: ");
            foreach (var option in winCond){
                Console.Write(" " + option.Key);
            }
            System.Console.WriteLine("");
            player = Console.ReadLine().ToLower();
            if(winCond.ContainsKey(player)){
                System.Console.WriteLine("you choose " + player);
                System.Console.WriteLine("comp choose " + comp);
                if(player == comp){
                    System.Console.WriteLine("tie");
                }
                else if (winCond[player].Contains(comp)){
                    System.Console.WriteLine("you win");
                }
                else{
                    System.Console.WriteLine("you lose");
                }
            }
            System.Console.WriteLine("play again? Y/n: ");
            var playoption = Console.ReadKey();
            if(playoption.Key != ConsoleKey.Y){
                playAgain = false;
            }
        }
        }
    }
}
