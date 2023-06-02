using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int, string> ChickenNum = (cock, hen, chicken) => $"Cock:{cock}隻,Hen:{hen}隻,Chicken{chicken}隻\n";
            Console.WriteLine(BuyChicken(5, 3, 1, 100, 100, ChickenNum));
        }


        public static string BuyChicken(int cockP, int henP, int chickenP, int totalp, int totalnum, Func<int, int, int, string>Handler)
        {
            string result = string.Empty;
            Enumerable.Range(1, totalp / cockP).ToList().ForEach(cock =>
                   Enumerable.Range(1, totalp / henP).ToList().ForEach(hen =>
                   {
                       int chicken = totalnum - cock - hen;
                       if (cock * cockP + hen * henP + (chicken * chickenP) / 3 == totalp && chicken % 3 == 0)
                       {
                          // result += $"公雞：{cock} 隻，母雞：{hen} 隻，小雞：{chicken} 隻\n";
                           result += Handler(cock, hen, chicken) ;
                       }
                   })
               );
            return result;
        }
    }
}
