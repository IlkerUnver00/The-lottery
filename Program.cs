using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.SayisalLoto.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //context , content


            int[] sayilar = new int[6];
            Random rnd = new Random();
            int eklenen = 0;
            while (eklenen < sayilar.Length)
            {
                int a = rnd.Next(1, 50);
                bool sayiVar = false;
                for (int j = 0; j < eklenen; j++)
                {
                    if (sayilar[j] == a)
                    {
                        sayiVar = true;
                        break;
                    }
                }
                if (!sayiVar)
                {
                    sayilar[eklenen] = a;
                    eklenen++;
                }
            }
            Array.Sort(sayilar);





            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i] + "-");
            }
            Console.ReadKey();
        }
    }
}
