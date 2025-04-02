using System.Diagnostics;

namespace HW_13._6._1_List;

internal class Program
{
    static string text = File.ReadAllText("C:\\Users\\777\\Desktop\\GruFox\\C#\\HW_13.6.1\\input.txt");

    static void Main(string[] args)
    {
        List<string> list = new List<string>();

        // Сохраняем символы-разделители в массив
        char[] delimiters = new char[] { ' ', '\r', '\n' };

        // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
        var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        list.AddRange(words);

        // запускаем новый таймер
        var stopWatch = Stopwatch.StartNew();

        list.Insert(1, "MIDDLE");

        // смотрим, сколько операция заняла, в миллисекундах
        Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds + "\n");
    }
}
