using System;

namespace Coin_flip
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Press enter to flip a coin");
        Console.ReadLine();
        string flip = flipCoin();
        Console.WriteLine(flip);
        }

    static string flipCoin()
        {
        Random rnd = new Random();
        if (rnd.Next() % 2 ==0){
            return "Tails";
            }
        return "Heads";
        
        } 
    
    }

    
}
