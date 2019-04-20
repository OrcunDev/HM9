using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
             begin:
            int playerSum;
            int dealerSum;
            int playerCard3 = 0;
            do
            {
               
                Console.WriteLine("How much would you like to wager?");
                int wager = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
               
                int playerCard1 = rnd.Next(1, 10);
                int playerCard2 = rnd.Next(1, 10);
                playerSum = playerCard1 + playerCard2;
                Console.WriteLine("Player Total Sum " + playerSum);

                int dealerCard1 = rnd.Next(1, 10);
                int dealerCard2 = rnd.Next(1, 10);
                 dealerSum = dealerCard1 + dealerCard2;
                Console.WriteLine("Dealer Total Sum " + dealerSum);

                Console.WriteLine("Would you like another card? 'Y' for yes, 'N' for no :");
                string askThirdCard = Console.ReadLine();
                if (askThirdCard == "Y" || askThirdCard == "y") 
                {
                    playerCard3 = rnd.Next(1, 10);
                    playerSum += playerCard3;

                    if (dealerSum <= 17)
                    {
                        int dealerCard3 = rnd.Next(1, 10);
                        dealerSum += dealerCard3;

                    }
                    //Console.WriteLine("Player Total Sum " + playerSum);
                    //Console.WriteLine("Dealer Total Sum " + dealerSum);
                }
                else if (askThirdCard == "N" || askThirdCard == "n")
                {
                    if (dealerSum <= 17)
                    {
                        int dealerCard3 = rnd.Next(1, 10);
                        dealerSum += dealerCard3;

                    }
                    //Console.WriteLine("Player Total Sum " + playerSum);
                    //Console.WriteLine("Dealer Total Sum " + dealerSum);
                }
                Console.WriteLine("Player Total Sum " + playerSum);
                Console.WriteLine("Dealer Total Sum " + dealerSum);

                if (playerSum > 21)
                {
                    Console.WriteLine("Player Lost the Game!!!, Dealer Won!!!" + " $" + wager);
                    break;
                }
                else if (dealerSum >21)
                {
                    Console.WriteLine("Dealer Lost the Game!!!, Player Won!!!" + " $" + wager);
                    break;
                }
                else if (21-playerSum <21-dealerSum)
                {
                    Console.WriteLine("Dealer Lost the Game!!!, Player Won!!!" + " $" + wager);
                    break;
                }
                else if (21-dealerSum <21-playerSum)
                {
                    Console.WriteLine("Player Lost the Game!!!, Dealer Won!!!" + " $" + wager);
                    break;
                }
                else if (dealerSum > 21 && playerSum > 21 && dealerSum == playerSum)
                {
                    Console.WriteLine("Player and Dealer both Lost the Game!!! ");
                    break;
                }
                else if (dealerSum < 21 && playerSum< 21 && dealerSum == playerSum)
                {
                    Console.WriteLine("Player and Dealer both Lost the Game!!! ");
                    break;
                }

            } while (true);
          
            Console.WriteLine("The Game is Over!");
            Console.WriteLine("Would you like to continue? 'Y' for yes, 'N'for no:");
            string isUserContinue = Console.ReadLine();
            if (isUserContinue == "Y"|| isUserContinue == "y")
            {
                goto begin;

            }
            else
            {
                Console.WriteLine("Game over");
            }

        }
    }
}
