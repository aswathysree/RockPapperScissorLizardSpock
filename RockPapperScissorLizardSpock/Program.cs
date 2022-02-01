using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerA, playerB;
            int randomInt;
            
            bool playAgain = true;

            while (playAgain)
            {

                int playerAscore = 0;
                int playerBscore = 0;

                while (playerAscore < 3 && playerBscore < 3)
                {
                    

                    Console.Write("Choose between ROCK, PAPER,SCISSORS,LIZARD and  SPOCK:    ");
                    playerA = Console.ReadLine();
                    playerA = playerA.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            playerB = "ROCK";
                            Console.WriteLine("PlayerB chose ROCK");
                            if (playerA == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (playerA == "PAPER")
                            {
                                Console.WriteLine("PLAYERA WINS!!\n\n");
                                playerAscore++;
                            }
                            else if (playerA == "SCISSORS")
                            {
                                Console.WriteLine("PLAYERB WINS!!\n\n");
                                playerBscore++;
                            }
                           
                            else if (playerA == "LIZARD")
                            {
                                Console.WriteLine("PLAYERB WINS!!\n\n");
                                playerBscore++;
                            }
                            else if (playerA == "SPOCK")
                            {
                                Console.WriteLine("PLAYERA WINS!!\n\n");
                                playerAscore++;
                            }
                            break;
                        case 2:
                            playerB = "PAPER";
                            Console.WriteLine("PlayerB choose PAPER");
                            if (playerA == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (playerA == "ROCK")
                            {
                                Console.WriteLine("PLAYERB WINS!!\n\n");
                                playerBscore++;
                            }
                            else if (playerA == "SCISSORS")
                            {
                                Console.WriteLine("PLAYERA WINS!!\n\n");
                                playerAscore++;
                            }
                            else if (playerA == "LIZARD")
                            {
                                Console.WriteLine("PLAYERA WINS!!\n\n");
                                playerAscore++;
                            }
                            else if (playerA == "SPOCK")
                            {
                                Console.WriteLine("PLAYERA WINS!!\n\n");
                                playerAscore++;
                            }
                            break;
                        case 3:
                            playerB = "SCISSORS";
                            Console.WriteLine("PlayerB choose SCISSORS");
                            if (playerA == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (playerA == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerAscore++;
                            }
                            else if (playerA == "PAPER")
                            {
                                Console.WriteLine("PLAYERB WINS!!\n\n");
                                playerBscore++;
                            }
                            else if (playerA == "LIZARD")
                            {
                                Console.WriteLine("PLAYERA WINS!!\n\n");
                                playerAscore++;
                            }
                            else if (playerA == "SPOCK")
                            {
                                Console.WriteLine("PLAYERB WINS!!\n\n");
                                playerBscore++;
                            }
                            break;
                        case 4:
                            playerB = "LIZARD";
                            Console.WriteLine("PlayerB choose LIZARD");
                            if (playerA == "LIZARD")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (playerA == "ROCK")
                            {
                                Console.WriteLine("PlayerA WINS!!\n\n");
                                playerAscore++;
                            }
                            else if (playerA == "SCISSORS")
                            {
                                Console.WriteLine("PLAYERA WINS!!\n\n");
                                playerAscore++;
                            }
                            else if (playerA == "PAPPER")
                            {
                                Console.WriteLine("PLAYERB WINS!!\n\n");
                                playerBscore++;
                            }

                            else if (playerA == "SPOCK")
                            {
                                Console.WriteLine("PLAYERA WINS!!\n\n");
                                playerAscore++;
                            }
                            break;
                        case 5:
                            playerB = "SPOCK";
                            Console.WriteLine("PlayerB choose SPOKE");
                            if (playerA == "SPOCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (playerA == "ROCK")
                            {
                                Console.WriteLine("PlayerB WINS!!\n\n");
                                playerBscore++;
                            }
                            else if (playerA == "SCISSORS")
                            {
                                Console.WriteLine("PLAYERB WINS!!\n\n");
                                playerBscore++;
                            }
                            else if (playerA == "PAPPER")
                            {
                                Console.WriteLine("PLAYERA WINS!!\n\n");
                                playerAscore++;
                            }

                            else if (playerA == "LIZARD")
                            {
                                Console.WriteLine("PLAYERA WINS!!\n\n");
                                playerAscore++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYERA:\t{0}\tPLAYERB:\t{1}", playerAscore, playerBscore);

                }

                if (playerAscore == 3)
                {
                    Console.WriteLine("PlAYER  A WON!");
                }
                else if (playerBscore == 3)
                {
                    Console.WriteLine("PLAYER B WON!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                { 
                
                }

            }
        }
    }
}