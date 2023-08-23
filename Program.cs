using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seçiminizi yapın:");
        Console.WriteLine("1. Pozitif sayıların çift olanlarını yazdırma");
        Console.WriteLine("2. M'e eşit veya tam bölünen sayıları yazdırma");
        Console.WriteLine("3. Kelimeleri sondan başa doğru yazdırma");
        Console.WriteLine("4. Cümledeki kelime ve harf sayısını bulma");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Pozitif bir sayı girin: ");
                int n1 = int.Parse(Console.ReadLine());

                List<int> numbers1 = new List<int>();

                for (int i = 0; i < n1; i++)
                {
                    Console.Write($"{i + 1}. sayıyı girin: ");
                    int num = int.Parse(Console.ReadLine());
                    numbers1.Add(num);
                }

                Console.WriteLine("Çift sayılar:");
                foreach (int num in numbers1)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine(num);
                    }
                }
                break;

            case 2:
                Console.Write("Pozitif bir sayı girin (n): ");
                int n2 = int.Parse(Console.ReadLine());

                Console.Write("Pozitif bir sayı daha girin (m): ");
                int m = int.Parse(Console.ReadLine());

                List<int> numbers2 = new List<int>();

                for (int i = 0; i < n2; i++)
                {
                    Console.Write($"{i + 1}. sayıyı girin: ");
                    int num = int.Parse(Console.ReadLine());
                    numbers2.Add(num);
                }

                Console.WriteLine($"{m}'e eşit veya tam bölünen sayılar:");
                foreach (int num in numbers2)
                {
                    if (num == m || num % m == 0)
                    {
                        Console.WriteLine(num);
                    }
                }
                break;

            case 3:
                Console.Write("Pozitif bir sayı girin (n): ");
                int n3 = int.Parse(Console.ReadLine());

                List<string> words = new List<string>();

                for (int i = 0; i < n3; i++)
                {
                    Console.Write($"{i + 1}. kelimeyi girin: ");
                    string word = Console.ReadLine();
                    words.Add(word);
                }

                Console.WriteLine("Kelimeler sondan başa doğru:");
                for (int i = words.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(words[i]);
                }
                break;

            case 4:
                Console.Write("Bir cümle yazın: ");
                string sentence = Console.ReadLine();

                string[] words4 = sentence.Split(' ');
                int wordCount = words4.Length;

                int letterCount = 0;
                foreach (char c in sentence)
                {
                    if (char.IsLetter(c))
                    {
                        letterCount++;
                    }
                }

                Console.WriteLine($"Toplam kelime sayısı: {wordCount}");
                Console.WriteLine($"Toplam harf sayısı: {letterCount}");
                break;

            default:
                Console.WriteLine("Geçersiz seçim.");
                break;
        }
    }
}