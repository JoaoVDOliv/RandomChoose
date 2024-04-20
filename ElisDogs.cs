using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseRandom
{
    internal class ElisDogs
    {
        public static void ElisDogOptions(int _randomNumber) 
        {
            switch (_randomNumber)
            {
                case 1:
                    Console.WriteLine("Nina");
                    break;
                case 2:
                    Console.WriteLine("Thor");
                    break;
                case 3:
                    Console.WriteLine("Leão");
                    break;
                case 4:
                    Console.WriteLine("Neguinha");
                    break;
                case 5:
                    Console.WriteLine("Akira");
                    break;
                default:
                    Console.WriteLine("Elis doesn't have so many Dogs :(");
                    break;
            }
        }
    }
}
