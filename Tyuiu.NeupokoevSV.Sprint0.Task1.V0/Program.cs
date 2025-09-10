using System;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Hello, World!");
        string name = "Семён";
        int age = 18;
        Console.WriteLine("Здравствуйте меня зовут" + name + " мне " + age + "!");
        Console.ReadKey();
    }
}