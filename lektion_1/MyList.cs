using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace lektion1
{
    internal class MyList
    {
        private List<int> list = new List<int>();
        

     public void addNumber(int number)
        {
            list.Add(number);
        }  
     public void randomNumbers()
        {
            var Rand = new Random();
         for(int i = 0; i < 10;i++)
            {
                addNumber(Rand.Next(101));
            }
        }

       public void PrintNumbers()
        {
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
    
    
}
