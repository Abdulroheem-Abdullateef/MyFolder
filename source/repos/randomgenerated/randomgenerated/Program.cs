using System;

namespace randomgenerated
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int deposit = random.Next(10000,20000);
            
            for (; ; )
            {
                Random random1 = new Random();
                int withdrawn = random.Next(100,500);
                
                Console.WriteLine(deposit);
                
                Console.WriteLine(withdrawn);
                
                
                if (deposit>500)
                {
                    int currentbalance = deposit - withdrawn;
                    Console.WriteLine($"withdrawn {withdrawn} from {deposit} is = {deposit}");
                    deposit = currentbalance;
                    Console.WriteLine($" balance is {deposit}");
                }

                else if (deposit>=500&&deposit>=100)
                {

                    Console.WriteLine($" Insulfficient balance {deposit} - {deposit}");
                    Console.WriteLine($" your balance is {deposit}");
                    break;
                }

                else if (deposit < 100)
                {
                    Console.WriteLine($" Insulfficient balance your balance is {deposit}");
                    break; 

                }


            }





        }
    }
}
