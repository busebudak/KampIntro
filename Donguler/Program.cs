﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Phyton";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , 
                "Programlamaya Başlangıç İçin Temel Kurs" , 
                "Java" , "Phyton" , "C#"};


            for (int i = 0; i<kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}

