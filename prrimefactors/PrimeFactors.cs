using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prrimefactors
{
    internal class PrimeFactors
    {
        public void prime(int x)
        {
            int num = x;
            
            
           
            for (int i=1;i<=num;i++)
            {
                if(num%i == 0)
                {
                    int count = 0;
                    for (int j = 1; j <= i; j++)
                    {

                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                        if (count == 2)
                        {
                            Console.WriteLine(i);
                        }

                    
                }

                

               
              


            }
           
            


        }
    }
}
