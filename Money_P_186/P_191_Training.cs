using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_P_186
{
    public class Player
    {
        public string? name;
        public int cash; 

        public void Info()
        {
            Console.WriteLine($"{name} has {cash} bucks.");
        }
    }

    public class P_191_Training
    {
        static void Main1()
        {
            Random random = new Random();
            float odds = 0.75f;
            Player player = new Player() {name = "The Player", cash = 100 };

            Console.WriteLine($"Welcome to the casino. The odds : {odds}");
            

            while (player.cash > 0)
            {
                player.Info();
                Console.Write("How much do you want to bet : ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    if (amount <= player.cash)
                    {
                        int pot = amount * 2;
                        double num = random.NextDouble();

                        if (num > odds)
                        {
                            player.cash += pot;
                            Console.WriteLine("Good Luck, you win");
                        }
                        else
                        {
                            player.cash -= amount;
                            Console.WriteLine("Bad Luck, you lose");
                        }
                    }
                    else
                        Console.WriteLine($"Cash :{player.cash} < Amount : {amount}");
                }
                else Console.WriteLine("Plase enter a valid number");
            }
            Console.WriteLine("The house always wins");
        }
    }

}
