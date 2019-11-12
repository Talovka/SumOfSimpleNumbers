using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 100;
            int sumprost = 0;
            int[] mass = new int [a];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = i;
                if (IsPrime(mass[i]) == true) 
                {
                    sumprost += mass[i];
                }
                
            }
            Console.WriteLine(sumprost);
            
          
        }
        static bool IsPrime(int number)
        {
            if (number == 1)
                return false;

            if (number % 2 == 0)
            {
                if (number == 2)
                    return true;
                return false;
            }

            int max = (int)Math.Sqrt(number);
            for (int i = 3; i <= max; i += 2)
            {
                if ((number % i) == 0)
                    return false;
            }
            return true;
        }



    }
  

}

    

