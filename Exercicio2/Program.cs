using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime agora = DateTime.Now;
        string cumprimento = ClassLibrary.Cumprimento.ObterCumprimento(agora);
        Console.WriteLine(cumprimento);
    }
}