using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyfryLab
{
    class Gronsfeld : IEncrDecr
    {
        private int[] key = null;

        public Gronsfeld()
        {

        }
        public Gronsfeld(string _key)
        {
            SetKey(_key.Split(' '));
        }
        public void SetKey(string[] _key)
        {
            key = new int[_key.Length];
            for (int i = 0; i < _key.Length; i++)
                key[i] = Convert.ToInt32(_key[i]);
        }      
        public string Decrypt(string input)
        {
            string result = "";
            for (int i = 0,j=0; i < input.Length; i++,j++)
            {
                if (j == key.Length) j = 0;
                result += (char)(input[i] - key[j]);
            }
            return result;
        }

        public string Encrypt(string input)
        {
            string result = "";
            for (int i = 0, j = 0; i < input.Length; i++,j++)
            {
                if (j == key.Length) j = 0;
                result += (char)(input[i] + key[j]);
            }

            return result;
        }
    }
}
