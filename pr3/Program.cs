using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            //Найти самое длинное слово из пяти введенных с клавиатуры.

            /*string st = "";
                int l = st.Length;

                string s = "";
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"");
                    string st1 = Console.ReadLine();
                    if(st1.Length > l)
                    {
                        l = st1.Length;
                        s = st1;
                    }
                }
                Console.WriteLine(l);
                Console.WriteLine(s);
                Console.ReadLine();*/

            //Task2
            //Составьте программу, удаляющую букву «е» («Е») из предложения
            // 1 способ
            /*Write("Enter a sentence: ");
            string sentence = ReadLine();
            sentence = sentence.Replace('E', ' ');
            sentence = sentence.Replace('e', ' ');
            sentence = sentence.Replace('е', ' ');
            sentence = sentence.Replace('Е', ' ');
            Write(sentence);*/

            //2 способ
            /*string sentence = ReadLine();
            //char r = ' ';
            for(int i = 0; i < sentence.Length-1; i++)
            {
                if (sentence[i] == 'е')
                {
                    sentence = sentence.Replace("е", "");
                }
                if (sentence[i] == 'Е')
                {
                    sentence = sentence.Replace("Е", "");
                }
            }
            WriteLine(sentence);*/


            //task3
            //Составьте программу вычисления количества букв «а» («А») в предложении.

            /*Write("Enter a word: ");     
            string word = ReadLine();
            int letter_a = word.Split('a', 'A', 'а', 'А').Length - 1;    
            WriteLine($"\nThe number of letters: {letter_a}");*/

            //Task4
            //Составьте программу, определяющую длину первого слова в предложении.

            /*string sentence = ReadLine();
            int i = 0;
            while (sentence[i] != ' ')
            {
                i++;
            }
            WriteLine(i);*/

            //task5
            // Составьте программу, определяющую длину последнего слова в предложении.
            //string sentence = ReadLine();
            //int count = 0;
            //for (int i = sentence.Length - 1; i >= 0; i--)
            //{
            //    if (sentence[i] != ' ')
            //    {
            //        count++;
            //    }
            //}
            //Write(count);

            //task6
            //Заменить в строке букву А на букву О

            /*string sentence = ReadLine();
            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if (sentence[i] == 'а')
                {
                    sentence = sentence.Replace("а", "о");
                }
                if (sentence[i] == 'А')
                {
                    sentence = sentence.Replace("А", "О");
                }
            }
            WriteLine(sentence);*/

            //task7
            //Написать программу для получения реверсированной строки.
            /*string sentence = ReadLine();
            int i = sentence.Length-1;
            while (sentence[i] != ' ')
            {
                i--;
            }
            WriteLine(i+1);*/
        }
    }
}
