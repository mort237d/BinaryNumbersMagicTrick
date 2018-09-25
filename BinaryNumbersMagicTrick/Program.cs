using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BinaryNumbersMagicTrick
{
    class Program
    {
        static void Main(string[] args)
        {Console.Title = "!!!Fuck dig!!!";

            for (int i = 1; i < Console.LargestWindowHeight-15; i++)
            {
                Console.SetWindowSize(i+i, i);
                System.Threading.Thread.Sleep(50);
            }

            string title = @"

  *   )            (   (           )            )     )           )  
` )  /( (    (     )\  )\   (   ( /( (   (   ( /(  ( /(    (   ( /(  
 ( )(_)))(   )\ ) ((_)((_) ))\  )\()))(  )\  )\()) )\())  ))\  )\()) 
(_(_())(()\ (()/(  _   _  /((_)(_))/(()\((_)((_)\ ((_)\  /((_)(_))/  
|_   _| ((_) )(_))| | | |(_))  | |_  ((_)(_)| |(_)| |(_)(_))  | |_   
  | |  | '_|| || || | | |/ -_) |  _|| '_|| || / / | / / / -_) |  _|  
  |_|  |_|   \_, ||_| |_|\___|  \__||_|  |_||_\_\ |_\_\ \___|  \__|  
             |__/                                                    

";
            string velkommen = "Velkommen til";
            Console.SetCursorPosition((Console.WindowWidth - velkommen.Length) / 2, Console.CursorTop);
            Console.WriteLine(velkommen);
            Console.WriteLine(title);
            DoTheTrick dothetrick = new DoTheTrick();
        }
    }
}
