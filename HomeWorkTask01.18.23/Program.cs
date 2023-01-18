using System;

namespace HomeWorkTask01._18._23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod 
            int[] numbers = { 45, 25, 12, 32, 41, 14 };
            int result = MinNumer(numbers);
            Console.WriteLine($" En kicik eded {result}");
            #endregion

            Console.WriteLine("-------------------------------");

            #region Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod
            Console.Write("Sozu daxil edin : ");
            string word = Console.ReadLine();
            Console.Write("Axtarmaq istediyiniz herfi daxil edin : ");
            char wantedChar = Convert.ToChar(Console.ReadLine());
            var result2 = CountChar(word, wantedChar);
            Console.WriteLine($"{result2} dene axtardiginiz herf var");
            #endregion

            Console.WriteLine("---------------");

            #region Verilmiş ədədlər siyahısında verilmiş ədədin yerləşdiyi indexi tapan metod
            int[] number = { 45, 12, 75, 25, 15, 10, 11 };
            Console.WriteLine("Axtarmaq istediyiniz reqemi daxil edin");
            int wantedNumber = int.Parse(Console.ReadLine());
            var result3 = IndexNumber(number, wantedNumber);
            if (result3 != -1)
            {
                Console.WriteLine($"Axtardiginiz reqemin indeks nomresi {result3}");
            }
            else
            {
                Console.WriteLine("Axtardiginiz reqem ededler listinde yoxdur");
            }
            #endregion
            
            Console.WriteLine("-----------------------");

            #region Verilmiş yazını əksinə çevirən metod

            Console.WriteLine("Yazini daxil edin : ");
            string getValue = Console.ReadLine();
             var result4 = OppositeWord(getValue);
            Console.WriteLine($"Yazinin tersden yazilisi : {result4}");
            #endregion

            Console.WriteLine("-----------");

            #region  Verilmiş yazıda rəqəm olub olmadığını tapan metod
            Console.WriteLine("Sozu daxil edin");
            string getWord = Console.ReadLine();
            var result5 =WantedNumber(getWord);
            if (result5==true)
            {
                Console.WriteLine("Daxil etdiyiniz yazida reqem var");
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz yazida reqem yoxdur");
            }
            
            #endregion

        }

        static int MinNumer(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        static int CountChar(string str, char cr)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == cr)
                {
                    count++;
                }
            }
            return count;
        }
        static int IndexNumber(int[] arr , int wantedNumber)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (wantedNumber == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }
        static string OppositeWord(string word)
        {
            string oppositeStr = "";
            for (int i = word.Length-1; i >= 0; i--)
            {
               oppositeStr += word[i];
               
            }
            return oppositeStr;
        }

        static bool WantedNumber(string word)
        {
            char[] symbol = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            for (int i = 0; i < symbol.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == symbol[i])
                    {
                        return true;
                    }
                }
            }
            return false;

        }
    }
}
