using System;
using System.IO;

namespace TextProcessor
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите имя входного файла (например, input.txt): ");
            string inputFile = Console.ReadLine();

            if (!File.Exists(inputFile))
            {
                Console.WriteLine("Файл не найден!");
                return;
            }

            Console.Write("Введите символ, который нужно заменить: ");
            char oldChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Введите символ для замены: ");
            char newChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Читаем файл
            string content = File.ReadAllText(inputFile);
            
            // Заменяем символы
            string newContent = content.Replace(oldChar, newChar);
            
            // Сохраняем в новый файл
            string outputFile = "output.txt";
            File.WriteAllText(outputFile, newContent);

            Console.WriteLine($"\nГотово! Результат сохранен в {outputFile}");
        }
    }
}
