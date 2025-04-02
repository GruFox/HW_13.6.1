using System.Diagnostics;

namespace HW_13._6._1_LinkedList;

internal class Program
{
    static string text = File.ReadAllText("C:\\Users\\777\\Desktop\\GruFox\\C#\\HW_13.6.1\\input.txt");

    static void Main(string[] args)
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        // Сохраняем символы-разделители в массив
        char[] delimiters = new char[] { ' ', '\r', '\n' };

        // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
        var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            linkedList.AddLast(word);
        }

        // запускаем новый таймер
        var stopWatch = Stopwatch.StartNew();

        linkedList.AddAfter(linkedList.First, "MIDDLE");

        // смотрим, сколько операция заняла, в миллисекундах
        Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds + "\n");
    }
}

