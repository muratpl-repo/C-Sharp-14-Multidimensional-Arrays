using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55DersCokBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ikiBoyutluDizi = { { 2, 3 }, { 4, 5 }, { 6, 7 } };

            for(int i = 0; i < 3; i++) // satir sayisi = i = 3
            {
                for(int j = 0; j < 2; j++) // sutun sayisi = i = 2
                {
                    Console.Write(ikiBoyutluDizi[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
