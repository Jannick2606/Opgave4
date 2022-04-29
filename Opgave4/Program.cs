using System;
using System.Threading;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWrite rw = new ReadWrite();
            Console.WriteLine("Terminate the program with Ctrl-C");
            Thread printer = new Thread(rw.Print);
            Thread reader = new Thread(rw.Read);
            printer.Start();
            reader.Start();
        }
        
    } 
    class ReadWrite
    {
        private char ch = '*';
        public void Read()
        {
            char current = '*';
            ConsoleKeyInfo cki;
            while (true)
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Enter)
                {
                    ch = current;
                    Console.WriteLine();
                }
                else
                {
                    current = cki.KeyChar;
                }
            }

        }
        public void Print()
        {
            while (true)
            {
                Console.Write(ch);
                Thread.Sleep(100);
            }
        }
    }
}
