using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isProgress = true;
            string inputUser;
            int[]bag = new int[1];
            
            while (isProgress)
            {
                inputUser = Console.ReadLine();
                
                if (inputUser == "sum")
                {
                    int sumBag = 0;

                    for (int i = 0; i < bag.Length; i++)
                    {
                        sumBag += bag[i];
                    }
                    Console.WriteLine(sumBag);
                }
                else if (inputUser == "exit")
                {
                    isProgress = false;
                }
                else
                {
                    int[] tempBag = new int[bag.Length + 1];
                    
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = Convert.ToInt32(inputUser);
                    bag = tempBag;
                }
            }
        }
    }
}
