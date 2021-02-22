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

        }

    static string flipCoin()
        {
        Random rnd = new Random();
        if ( rnd.Next() % 2 ==0){
            //Console.WriteLine("Even");
            return "Tails";
            }
        return "Heads";
        
        } 
    
    }

    
}
