using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChooseRandom
{
    public class MenuClass
    {
        public int menuIterator { get; set; }        

        public void Menu()
        {            
            do
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Welcome to the Randometer!");
                Console.WriteLine("You give me something and I will give you a something");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Do you want to start?");
                Console.WriteLine("0 - No");
                Console.WriteLine("1 - Yes");

                menuIterator = Convert.ToInt32(Console.ReadLine());

                if (menuIterator == 1)
                {
                    this.menuChoices();
                }
                else if (menuIterator == 0)
                {
                    Console.WriteLine("Bye");
                }
                else
                {
                    Console.WriteLine("Wrong value");
                }
            } while (menuIterator != 0);
        }

       public void menuChoices()
       {
            Random random = new Random();   
            
            int menuIterator = 0;
            int numberRandom = 0;

            do
            {
                numberRandom = random.Next(1, 10);
                
                Console.WriteLine("Please, choose a menu option:");
                Console.WriteLine("1-Elis dogs");
                Console.WriteLine("------------------------------");
                
                menuIterator = Convert.ToInt32(Console.ReadLine());

                switch (menuIterator) 
                {
                    case 0:
                        Console.WriteLine("Back to main menu");
                        break;
                    case 1:
                        ElisDogs.ElisDogOptions(numberRandom);
                        break;
                    default:
                        Console.WriteLine("You must choose between the options");
                        break;                                
                }                           
            
            } while (menuIterator != 0);
       }
    }
}
