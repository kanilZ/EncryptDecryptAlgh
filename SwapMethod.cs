using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyfryLab1
{
    public class SwapMethod : IEncrDecr
    {
        private string alphabet = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя-, .";
        private string encrAlphabet;
        private StringBuilder result;
        private Random rnd;
        public SwapMethod()
        {
            rnd = new Random();
            ShuffleAlphabet();
        }
        public string Decrypt(string text)
        {
            result = new StringBuilder(text.Length);
            for (int i = 0; i < text.Length; i++)
            {
                result.Append(alphabet[FindIndex(text[i],encrAlphabet)]);
            }
            return result.ToString();
        }
        public string Encrypt(string text)
        {
            result = new StringBuilder(text.Length);
            for (int i = 0; i < text.Length; i++)
            {
                result.Append(encrAlphabet[FindIndex(text[i],alphabet)]);
            }
            return result.ToString();
        }
        private int FindIndex(char text, string voc)
        {         
            for (int i = 0; i < voc.Length; i++)
            {
                if (text == voc[i])
                {
                    return i;
                }
            }
            return 0;
        }
        private void ShuffleAlphabet()
        {
            encrAlphabet =  new string(alphabet.ToCharArray().OrderBy(s => (rnd.Next(2) % 2) == 0).ToArray());
        }
    }
}
