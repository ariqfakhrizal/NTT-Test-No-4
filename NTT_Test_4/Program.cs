using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NTT_Test
{
    /*
     * Solusi : Ini adalah cara yang hanya mmelakukan comparing data antaraa open brackets dan close bracket
     *          Jika total open bracket dan close bracket sama, maka akan menghasilkan nilai 1
     *          dan jika tidak sama, maka akan menghasilkan nilai 0
     * 
     * Isu yang muncul menggunakan source code ini adalah 
     * Saya pribadi mengakui bahwa cara ini memungkinkan adanya kesalahan jika prosedur pengecekan nya harus valid antara brackets - 
     * Dan setahu saya, ini bisa diselesaikan menggunakan funsi stack.  
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input X: ");
            string x = Console.ReadLine();

            if (x != null)
            {
                functionBracket(x);
            }
            else {
                Console.WriteLine("Data Yang Anda Masukkan Salah.");
            }
        }

        private static void functionBracket(string dataInput)
        {
            char OpenBrackets = '(';
            char CloseBrackets = ')';


            int dataOpenBrackets = CountOpenBrackets(dataInput, OpenBrackets);
            int dataCloseBrackets = CountCloseBrackets(dataInput, CloseBrackets);
            if (dataOpenBrackets.Equals(dataCloseBrackets)) {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }

        }

        private static int CountOpenBrackets(string dataInput, char openBracket)
        {
            int count = 0;
            foreach (var ch in dataInput)
            {
                if (ch == openBracket)
                    count++;
            }
            return count;
        }

        private static int CountCloseBrackets(string dataInput, char closeBracket)
        {
            int count = 0;
            foreach (var ch in dataInput)
            {
                if (ch == closeBracket)
                    count++;
            }
            return count;
        }
    }
}
