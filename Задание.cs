using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText(@"C:\Users\user\Desktop\Первый.txt");
        Console.WriteLine(text);
    }
}