using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyfryLab1
{
    class Symbol
    {
        public static List<Symbol> symbols = new List<Symbol>();
        public char symbol { get; set; }
        public int code { get; set; }
        public string binaryCode { get; set; }
        public Symbol() { }
        public Symbol(char symbol, int code, string binaryCode)
        {
            this.symbol = symbol;
            this.code = code;
            this.binaryCode = binaryCode;
        }
        public static void generateSymbols()
        {
            int code = 1;
            for (int i = 97; i < 123; i++, code++)
            {
                symbols.Add(new Symbol((char)i, code, binar(code)));
            }
            for (int i = 48; i < 58; i++, code++)
            {
                symbols.Add(new Symbol((char)i, code, binar(code)));
            }
            symbols.Add(new Symbol((char)32, code, binar(code)));
        }
        public static string binar(int a)
        {
            int b;
            StringBuilder stringC = new StringBuilder();
            while (a != 0)
            {
                b = a % 2;
                stringC.Append(b);
                a /= 2;
            }
            for (int j = stringC.Length; j < 7; j++)
            {
                stringC.Append(0);
            }
            var arr = stringC.ToString().ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
