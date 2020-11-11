using ShyfryLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyfryLab
{
    class Vernama : IEncrDecr
    {
        private string[] uniqueBinaryKey;
        private StringBuilder codedText;
        public Vernama()
        {

        }
        public Vernama(string key)
        {

        }
        public string Decrypt(string text)
        {
            codedText = new StringBuilder();
            int code;
            int beginIndex = 0;
            Symbol.generateSymbols();
            for (int i = 0; i < text.Length / 6; i++, beginIndex += 6)
            {
                var stringNum = text.Substring(beginIndex, 6);
                int var1 = Convert.ToInt32(stringNum, 2);
                int var2 = Convert.ToInt32(uniqueBinaryKey[i], 2);
                code = var1 ^ var2;
                foreach (var s in Symbol.symbols)
                {
                    if (s.code == code)
                    {
                        codedText.Append(s.symbol);
                        break;
                    }
                }
            }
            return codedText.ToString();
        }

        public string Encrypt(string text)
        {
            text = text.ToLower().Replace("[ ,.]", "");
            uniqueBinaryKey = new string[text.Length];
            codedText = new StringBuilder();
            generateKey(text);
            char[] charText = text.ToCharArray();
            int code = 0;
            Symbol.generateSymbols();
            string temp;
            for (int i = 0; i < charText.Length; i++)
            {
                foreach (var s in Symbol.symbols)
                {
                    if (s.symbol == charText[i])
                    {
                        code = s.code;
                        break;
                    }
                }
                temp = Symbol.binar(code ^ Convert.ToInt32(uniqueBinaryKey[i], 2));
                if (temp.Length > 6)
                {
                    temp = temp.Substring(1);
                }
                codedText.Append(temp);
            }
            return codedText.ToString();
        }
       
        public void generateKey(string text)
        {
            StringBuilder s = new StringBuilder();
            Random random = new Random();
            int index = 1;
            for (int i = 0; i < text.Length * 6; i++, index++)
            {
                s.Append(random.Next(2).ToString());
                if (index % 6 == 0)
                {
                    uniqueBinaryKey[i / 6] = s.ToString();
                    s = new StringBuilder();
                }
            }
        }
 
        public string Key()
        {
            var res = new StringBuilder();
            foreach (var s in uniqueBinaryKey)
            {
                res.Append(s + " ");
            }
            return res.ToString();
        }
    }
}
