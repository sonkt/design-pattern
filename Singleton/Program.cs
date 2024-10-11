﻿// See https://aka.ms/new-console-template for more information
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;
            instance1.SetName("SONKT");
            instance2.PrintMessage();
            instance2.SetName("ThinhNC");
            instance1.PrintMessage();
        }
    }
}