using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyfryLab
{
    class Polibius : IEncrDecr
    {
        char[,] square;
        string alphabet;
        string password;
        public Polibius(string key,string alphabet = null )
        {
            this.alphabet = alphabet ?? "abcdefghijklmnopqrstuvwxyz ";
            password = key;
        }

        char[,] GetSquare(string key)
        {
            var newAlphabet = alphabet;
            //видаляємо з алфавіту всі символи які містяться в ключі
            for (int i = 0; i < key.Length; i++)
            {
                newAlphabet = newAlphabet.Replace(key[i].ToString(), "");
            }

            //додаємо пароль на початок алфавіту, а в кінець додаткові знаки
            //щоб уникнути пустих комірок
            newAlphabet = key + newAlphabet + "0123456789!@#$%^&*)_+-=<>?,.";

            //отримуємо розмір сторони квадрату
            //округленням квадратного кореню в сторону більшого цілого числа
            var n = (int)Math.Ceiling(Math.Sqrt(alphabet.Length));

            //створюємо і заповнюємо масив
            square = new char[n, n];
            var index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (index < newAlphabet.Length)
                    {
                        square[i, j] = newAlphabet[index];
                        index++;
                    }
                }
            }

            return square;
        }
        bool FindSymbol(char[,] symbolsTable, char symbol, out int column, out int row)
        {
            var l = symbolsTable.GetUpperBound(0) + 1;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (symbolsTable[i, j] == symbol)
                    {
                        //значення знайдено
                        row = i;
                        column = j;
                        return true;
                    }
                }
            }

            //якщо нічого не знайшли
            row = -1;
            column = -1;
            return false;
        }

        public string Decrypt(string text)
        {
            var outputText = "";
            var square = GetSquare(password);
            for (int i = 0; i < text.Length; i++)
            {
                if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                {
                    var newRowIndex = rowIndex == 0
                        ? square.GetUpperBound(1)
                        : rowIndex - 1;
                    outputText += square[newRowIndex, columnIndex].ToString();
                }
            }
            return outputText;
        }

        public string Encrypt(string text)
        {
            var outputText = "";
            var square = GetSquare(password);
            var m = text.Length;
            for (int i = 0; i < m; i++)
            {
                if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                {
                    var newRowIndex = rowIndex == square.GetUpperBound(1)
                        ? 0
                        : rowIndex + 1;
                    outputText += square[newRowIndex, columnIndex].ToString();
                }
            }

            return outputText;
        }
    }
}
