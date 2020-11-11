using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyfryLab
{
    public class ShuffleMethod : IEncrDecr
    {
        private string key;
        private int nblock;
        private int[] keyIndex;      
        public ShuffleMethod() { }
        public ShuffleMethod(string key)
        {
            this.key = key;
            nblock = key.Length;
            keyIndex = new int[nblock];
        }
        public string Decrypt(string text)
        {
            int rows = (int)Math.Ceiling(((double)text.Length / (double)nblock));
            char[,] vocab = new char[rows, nblock];
            StringBuilder result = new StringBuilder();

            MakeKeyIndex(key);

            for (int i = 0, index = 0; i < nblock; i++)
            {
                int colm = FindIndex(keyIndex, i + 1);
                for (int j = 0; j < rows; j++, index++)
                {
                    if (j * nblock + colm + 1 > text.Length)
                        break;
                    vocab[j, colm] = text[index];
                }
            }

            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < nblock; i++)
                {
                    result.Append(vocab[j, i]);
                }
            }
            return result.ToString();
        }
        public void MakeKeyIndex(string keyText)
        {
            int textSize = keyText.Length;
            for (int i = 0; i < textSize; i++)
            {
                int index = 1;
                for (int j = 0; j < textSize; j++)
                {
                    if (keyText[i] > keyText[j])
                    {
                        index++;
                    }
                    else if (i == j)
                        continue;

                }
                keyIndex[i] = index;
            }
        }

        public string Encrypt(string text)
        {
            int rows = (int)Math.Ceiling(((double)text.Length / (double)nblock));

            char[,] vocab = new char[rows, nblock];
            StringBuilder result = new StringBuilder();

            MakeKeyIndex(key);

            for (int i = 0, index = 0, spLength = text.Length; i < rows || index != spLength; i++)
            {
                for (int j = 0; j < nblock; j++, index++)
                {
                    if (i * nblock + j + 1 > spLength || index == spLength)
                        break;

                    vocab[i, j] = text[index];
                }
            }

            for (int i = 0; i < nblock; i++)
            {
                int colm = FindIndex(keyIndex, i + 1);
                for (int j = 0; j < rows; j++)
                {
                    if (j * nblock + colm + 1 > text.Length)
                        break;
                    result.Append(vocab[j, colm]);
                }
            }

            return result.ToString();
        }
        private int FindIndex(int[] where, int what)
        {
            for (int i = 0; i < where.Length; i++)
            {
                if (where[i] == what)
                    return i;
            }
            return 0;
        }
    }
}
