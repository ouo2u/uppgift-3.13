using System;
namespace Uppgift_3._13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hur gammal är du?Svara I hela antal år");
            int ålder = int.Parse(Console.ReadLine());


            if (ålder > 19)
            {
                Console.WriteLine("du är för gammal för att vara med I tavlingen");
            }
            else if(ålder > 16)
            {
                Console.WriteLine("du kan vara med I tavlingen");
            }
            else 
            {
                Console.WriteLine("du är för ung för att vara med I tavlingen");
            }

        }
    }
}