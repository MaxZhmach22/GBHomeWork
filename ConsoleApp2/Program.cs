using System;
using System.IO;
struct Element
{
    public string Surname;
    public string Name;
    public string FIO;
    public int N;
}
class Program
{
    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader(@"C:\Users\Max\Desktop\GeekBrains\C#\HomeWorkAnketa\ConsoleApp2\TextFile1.txt");
        int N = int.Parse(sr.ReadLine());
        Element[] a = new Element[N];
        for (int i = 0; i < N; i++)
        {
            string[] s = sr.ReadLine().Split(' ');
            a[i].FIO = s[0] + s[1];
            a[i].N = int.Parse(s[2]);
        }
        sr.Close();
        int[] massiv = new int[100];
        for (int i = 0; i < N; i++) massiv[a[i].N]++;
        int min = 100;
        for (int i = 0; i < 100; i++)
            if (massiv[i] != 0 && massiv[i] < min) min = massiv[i];
        for (int i = 0; i < 100; i++)
            if (massiv[i] == min) Console.WriteLine(i);
        Console.ReadKey();
    }
}