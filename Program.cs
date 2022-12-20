using System;

namespace algoritma
{ 
    class program
    { 
        static void Main(string[]args)
        { 
            Console.WriteLine("Lütfen Kelime,Sayı Giriniz:");
            string input = Console.ReadLine();

            string[] input1= input.Split(",");
            string Kelime= input1[0];
            int cevir= Convert.ToInt32(input1[1]);
            string sonhali= Kelime.Remove(cevir-1,1);
            Console.WriteLine(sonhali);
        }
    }
}