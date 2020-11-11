using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyfryLab
{
    public class Tsezar : IEncrDecr
    {
        private int shift;
        public Tsezar()
        {
            shift = 3;
        }
        public Tsezar(int s)
        {
            shift = s;
        }
        public string Encrypt(string text)
        {
            int size = text.Length;
            StringBuilder stringBuilder = new StringBuilder(size);

            for (int i = 0; i < size; i++)
            {
                stringBuilder.Append((char)(text[i]+shift));
            }
            return stringBuilder.ToString();
        }
        public string Decrypt(string text)
        {
            int size = text.Length;

            StringBuilder stringBuilder = new StringBuilder(size);
            for (int i = 0; i < size; i++)
            {
                stringBuilder.Append((char)(text[i] - shift));
            }
            return stringBuilder.ToString();

        }
    }
}
