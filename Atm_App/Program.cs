using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter Your Pin Code");
            int pin = Convert.ToInt32(Console.ReadLine());
          
            int current = 1000;
            int rem = 0;
            
            if (pin == 1234)
            {
                Console.WriteLine("Press  1 _________to Check Balance");
                Console.WriteLine("Press  2 _________to Withdraw Balance");
                Console.WriteLine("Press  3 _________to Deposit Balance");
                Console.WriteLine("Press  4 _________to Exit");
                int trans = int.Parse(Console.ReadLine());
                switch (trans)
                {
                    case 1:
                        Console.WriteLine("Your Current Balance{0}", current);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Amount you want to Withdraw");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please collect your Cash");
                        rem = current - withdraw;
                        Console.WriteLine("Your Remaining Balance is{0}", rem);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Amount you want to deposit");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please collect your Cash");
                        int final = rem + deposit;

                        Console.WriteLine("Your Remaining Balance is{0}", final);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using Atm Service");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
