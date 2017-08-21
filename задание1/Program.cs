using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,k,sum=0,str=0,max=0;            
            Vvod("введите количество глав", out N);
            Proverka("количество глав", ref N);
            
            int[] mas = new int[N];

            for (int i=0;i<N;i++)
            {
                Vvod("введите количество страниц в " + (i + 1) + " главе", out mas[i]);
                Proverka("количество страниц", ref mas[i]);
                if (max > mas[i]) max = mas[i];
                sum = sum+mas[i];
            }

            Vvod("введите количество новых глав", out k);
            Proverka("количество глав", ref k);

            if (k == N) str = max;
            else if (k == 1) str = sum;
            else str = (sum / k) + 1;
            Console.WriteLine(str);
            Console.ReadKey();

        }
        static double Vvod(string s, out int n)//ввод числа
        {
            bool ok;
            string buf;
            do
            {
                Console.Write(s + " = ");
                buf = Console.ReadLine();
                ok = Int32.TryParse(buf, out n);
                if (!ok) Console.WriteLine("Введите " + s + " заново");
            } while (!ok);
            return n;
        }
        static void Proverka(string s, ref int a)//проверка ввода на отрицательность
        {
            bool ok = false;
            string buf;
            do
            {
                if (a > 0) ok = true;
                else
                {
                    if (!ok) Console.WriteLine("\aВведите " + s + " заново");
                    Console.Write(s + " = ");
                    buf = Console.ReadLine();
                    ok = Int32.TryParse(buf, out a);
                    ok = false;
                }
            } while (!ok);
        }
    }
}
