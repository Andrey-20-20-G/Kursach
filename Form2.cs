using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Черновик
{
    public partial class Form2 : Form
    {
        //метод шифрования из рассмотренных выше
        public enum Method
        {
            Method1,
            Method2
        }

        public class PolybiusSquare
        {
            char[,] square;
            string alphabet;

            string alphabetrus;
            string alphabeten;
            Method encryptMethod;

            public PolybiusSquare(string alphabet = null, Method cipherMethod = Method.Method1)
            {
                this.alphabetrus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" + "0123456789!)_?,. (" + ("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ").ToLower();
                this.alphabeten = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +("ABCDEFGHIJKLMNOPQRSTUVWXYZ").ToLower();
                this.alphabet = alphabetrus+alphabeten;

                encryptMethod = cipherMethod;
            }

            //возвращает квадрат Полибия
            char[,] GetSquare(string key)
            {
                var newAlphabet = alphabet;
                //удаляем из алфавита все символы которые содержит ключ
                for (int i = 0; i < key.Length; i++)
                {
                    newAlphabet = newAlphabet.Replace(key[i].ToString(), "");
                }

                //добавляем пароль в начало алфавита, а в конец дополнительные знаки
                //для того чтобы избежать пустых ячеек
                newAlphabet = key + newAlphabet + "@#$%^*<>&=+-";

                //получаем размер стороны квадрата
                //округлением квадратного корня в сторону большего целого числа
                var n = (int)Math.Ceiling(Math.Sqrt(alphabet.Length));

                //создаем и заполняем массив
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

            //поиск символа в двухмерном массиве
            bool FindSymbol(char[,] symbolsTable, char symbol, out int column, out int row)
            {
                var l = symbolsTable.GetUpperBound(0) + 1;
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        if (symbolsTable[i, j] == symbol)
                        {
                            //значение найдено
                            row = i;
                            column = j;
                            return true;
                        }
                    }
                }

                //если ничего не нашли
                row = -1;
                column = -1;
                return false;
            }

            public string PolibiusEncrypt(string text, string password)
            {
                var outputText = "";
                var square = GetSquare(password);
                switch (encryptMethod)
                {
                    case Method.Method1:
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                            {
                                var newRowIndex = rowIndex == square.GetUpperBound(1)
                                    ? 0
                                    : rowIndex + 1;
                                outputText += square[newRowIndex, columnIndex].ToString();
                            }
                        }
                        break;

                    case Method.Method2:
                        var m = text.Length;
                        var coordinates = new int[m * 2];
                        for (int i = 0; i < m; i++)
                        {
                            if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                            {
                                coordinates[i] = columnIndex;
                                coordinates[i + m] = rowIndex;
                            }
                        }

                        for (int i = 0; i < m * 2; i += 2)
                        {
                            outputText += square[coordinates[i + 1], coordinates[i]];
                        }
                        break;
                }

                return outputText;
            }

            public string PolybiusDecrypt(string text, string password)
            {
                var outputText = "";
                var square = GetSquare(password);
                var m = text.Length;
                switch (encryptMethod)
                {
                    case Method.Method1:
                        for (int i = 0; i < m; i++)
                        {
                            if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                            {
                                var newRowIndex = rowIndex == 0
                                    ? square.GetUpperBound(1)
                                    : rowIndex - 1;
                                outputText += square[newRowIndex, columnIndex].ToString();
                            }
                        }
                        break;

                    case Method.Method2:
                        var coordinates = new int[m * 2];
                        var j = 0;
                        for (int i = 0; i < m; i++)
                        {
                            if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                            {
                                coordinates[j] = columnIndex;
                                coordinates[j + 1] = rowIndex;
                                j += 2;
                            }
                        }

                        for (int i = 0; i < m; i++)
                        {
                            outputText += square[coordinates[i + m], coordinates[i]];
                        }
                        break;
                }

                return outputText;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void ShiphrButton_Click(object sender, EventArgs e)
        {
            if ((PassBox.Text == "") || (MessageBoxTxt.Text.Length <= PassBox.Text.Length))
            {
                MessageBox.Show("Неверно введен ключ. Попробуйте еще раз");
            }
            else
            {
                PolybiusSquare polybius = new PolybiusSquare();
                var message = MessageBoxTxt.Text;
                var pass = PassBox.Text;
                var cipherText = polybius.PolibiusEncrypt(message, pass);
                ShiphBox.Text = cipherText;
            }
        }

        private void RashiprovatButton_Click(object sender, EventArgs e)
        {
            if ((PassBox.Text == "") || (MessageBoxTxt.Text.Length <= PassBox.Text.Length))
            {
                MessageBox.Show("Неверно введен ключ. Попробуйте еще раз");
            }
            else
            {
                PolybiusSquare polybius = new PolybiusSquare();
                var message = MessageBoxTxt.Text;
                var pass = PassBox.Text;
                var cipherText = polybius.PolybiusDecrypt(message, pass);
                ShiphBox.Text = cipherText;
            }
            
            
        }

        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string somepath = @"D:\Encrypter.txt";
            string text = ShiphBox.Text;
            using (StreamWriter sw = new StreamWriter(somepath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }
    }
}
