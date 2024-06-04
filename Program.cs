using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Завдання 5
//Розробіть додаток, який знаходитиме мінімальне і
//максимальне значення у двовимірному масиві.

//Завдання 7
//Користувач вводить речення з клавіатури. Вам необхідно перевернути кожне слово речення і вивести результат
//на екрані.
//Наприклад:
//користувач ввів: sun cat dogs cup tea;
//після перевороту: nus tac sgod puc aet.

//Завдання 9
//Створіть додаток для підрахунку кількості входжень
//підрядка в рядок. Користувач вводить вихідний рядок і
//слово для пошуку. Додаток відображає результат пошуку.
//Наприклад:
//користувач ввів: Why she had to go. I don't know, she
//wouldn't say;
//підрядок для пошуку: she;
//результат пошуку: 2.

namespace HW_02_29_05_2024
{
    internal class Program
    {
        //Розробіть додаток, який знаходитиме мінімальне і
        //максимальне значення у двовимірному масиві.
        public static void randomFillArr(int[] arr, int minValue, int maxValue)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = random.Next(minValue, maxValue + 1);
            }
        }
        public static void showArr(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public static int maxValInArr(int[] arr)
        {
            int maxVal = arr[0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] > maxVal)
                {
                    maxVal = arr[i];
                }
            }
            return maxVal;
        }
        public static int minValInArr(int[] arr)
        {
            int minVal = arr[0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] < minVal)
                {
                    minVal = arr[i];
                }
            }
            return minVal;
        }
        //Користувач вводить речення з клавіатури. Вам необхідно перевернути кожне слово речення і вивести результат
        //на екрані.
        static string ReverseWord(string word)
        {
            char[] charArray = word.ToCharArray();// слово в массив символов
            Array.Reverse(charArray);// реверс
            return new string(charArray); 
        }
        static void Main(string[] args)
        {
            //HWT1
            Console.WriteLine("Введите размер массива");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrSize];
            Console.WriteLine("Введите минимальное значение");
            int minNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение");
            int maxNum = Convert.ToInt32(Console.ReadLine());
            randomFillArr(arr,minNum,maxNum);
            showArr(arr);
            Console.WriteLine($"Min in arr: {minValInArr(arr)}");
            Console.WriteLine($"Max in arr: {maxValInArr(arr)}");
            Console.WriteLine("Press Enter");
            Console.ReadKey();

            //HWT2
            
            Console.WriteLine("Введите строку:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' '); // делаем массив из слов
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseWord(words[i]);// каждое слово разворачиваем
            }
            string newSentence = string.Join(" ", words);// обьеденяем
            Console.WriteLine("Новая строка: ");
            Console.WriteLine(newSentence);
            Console.WriteLine("Press Enter");
            Console.ReadKey();

            //HWT3
            Console.WriteLine("Введите строку:");
            string sentence2 = Console.ReadLine();
            Console.WriteLine("Введите искомое слово:");
            string searchWord = Console.ReadLine();
            int inCounter = 0;
            string[] words2 = sentence2.Split(' '); // делаем массив из слов
            for (int i = 0; i < words2.Length; i++)
            {
                if (searchWord == words2[i])
                {
                    inCounter++;
                }
            }
            Console.WriteLine($"Слово {searchWord} встретилось {inCounter} раз");
            Console.ReadKey();
        }
    }
}
