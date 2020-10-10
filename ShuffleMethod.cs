using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyfryLab1
{
    public class ShuffleMethod : IEncrDecr
    {
        private string key;
        private int nblock;
        private int[] keyIndex;
        //  private 
        public ShuffleMethod() { }
        public ShuffleMethod(string key)
        {
            this.key = key;
            nblock = key.Length;
            keyIndex = new int[nblock];
        }
        public string Decrypt(string text)
        {
            throw new NotImplementedException();
        }
        private void MakeKeyIndex(string keyText)
        {
            for (int i = 0; i < keyText.Length - 1; i++)
            {
                if (keyText[i] > keyText[i + 1])
                {
                    keyIndex[i] = i++;
                }
            }
        }
        public string Encrypt(string text)
        {
            int num = text.Length / nblock;
            string spText = text.Replace(" ", "");
            char[,] vocab = new char[nblock, num];
            StringBuilder result = new StringBuilder();


            for (int i = 0, index = 0, spLength = spText.Length; i < nblock; i++)
            {
                if (index == spLength)
                    break;
                for (int j = 0; j < num; j++, index++)
                {
                    vocab[i, j] = spText[index];
                }
            }
            //spText[i];
            for (int i = 0; i < nblock; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    result.Append(vocab[i, j]);
                }
            }

            return result.ToString();

        }
    }
}
