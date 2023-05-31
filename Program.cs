using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(DrawTriangle(5));
            // Console.WriteLine(DrawTriangleB(5));
            // Console.WriteLine(DrawTriangleC(5));

            Func<int, int, string> funcLeft = (rows, currentRow) => new string('*', currentRow);
            Func<int, int, string> funcRight = (rows, currentRow) => new string('*', currentRow).PadLeft(rows);
            Func<int, int, string> funcCenter = (rows, currentRow) 
            => new string(' ', rows - currentRow) + new string('*', 2 * currentRow - 1);

            //倒正triangle
            Func<int, int, string> funcInvertedCenter = (rows, currentRow) =>  new string(' ', currentRow - 1) + new string('*', 2 * (rows - currentRow) + 1);

            //倒左triangle
            Func<int, int, string> funcInvertedLeft = (rows, currentRow) =>  new string('*', rows - currentRow + 1);

            //倒右triangle
            Func<int, int, string> funcInvertedRight = (rows, currentRow) => new string('*', rows - currentRow + 1).PadLeft(rows);

            Console.WriteLine(DrawTriangleZ(5, funcLeft));
            Console.WriteLine(DrawTriangleZ(5, funcRight));
            Console.WriteLine(DrawTriangleZ(5, funcCenter));
            Console.WriteLine(DrawTriangleZ(5, funcInvertedLeft));
            Console.WriteLine(DrawTriangleZ(5, funcInvertedRight));
            Console.WriteLine(DrawTriangleZ(5, funcInvertedCenter));
        }

        static string DrawTriangleZ(int rows, Func<int, int, string> rowFunc)
        {
            string result = string.Empty;

            for (int i = 1; i <= rows; i++)
            {
                result += rowFunc(rows, i) + "\n";
            }

            return result;
        }
        /*static string DrawTriangle(int rows) // , Func<int, int, string> rowFunc)
        {
            string result = string.Empty;

            for(int i=1; i<= rows; i++)
            {
                result += new string('*', i) + "\n";
            }

            return result;
        }

        static string DrawTriangleB(int rows)
        {
            string result = string.Empty;

            for (int i = 1; i <= rows; i++)
            {
                result += new string('*', i).PadLeft(rows) + "\n";
            }

            return result;
        }

        static string DrawTriangleC(int rows)
        {
            string result = string.Empty;

            for (int i = 1; i <= rows; i++)
            {
                result += new string(' ', rows-i) + new string('*', 2*i-1) + "\n";
            }

            return result;
        }*/
    }
}
