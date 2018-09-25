using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumbersMagicTrick
{
    class DoTheTrick
    {
        private int[] TrickCard1 = {16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31};
        private int[] TrickCard2 = {08,09,10,11,12,13,14,15,24,25,26,27,28,29,30,31};
        private int[] TrickCard3 = {04,05,06,07,12,13,14,15,20,21,22,23,28,29,30,31};
        private int[] TrickCard4 = {02,03,06,07,10,11,14,15,18,19,22,23,26,27,30,31};
        private int[] TrickCard5 = {01,03,05,07,09,11,13,15,17,19,21,23,25,27,29,31};
        private string input;
        private int sum;
        private int counter;

        public DoTheTrick()
        {
            Console.WriteLine("Velkommen til trylletricket. Tænk på et tal mellem 1 og 31.");

            showCard(TrickCard1);
            showCard(TrickCard2);
            showCard(TrickCard3);
            showCard(TrickCard4);
            showCard(TrickCard5);

            Console.WriteLine("Det tal du tænker på er " + sum);
        }

        private void showCard(int[] Card)
        {
            Console.WriteLine("---------------");
            foreach (int number in Card)
            {
                if (number < 10)
                {
                    Console.Write(" " + number + "| ");
                }
                else
                {
                    Console.Write(number + "| ");
                }
                
                counter++;

                if (counter==4)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
            Console.WriteLine("---------------");

            Console.WriteLine();
            Console.WriteLine("Er tallet på denne plade? (j)a eller (n)ej");

            input = Console.ReadLine();

            if (input == "j")
            {
                sum = sum + Card.First();
            }
        }
    }
}
