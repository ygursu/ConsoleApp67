using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedengirilensayipozitifnegatifsifir
{
    class Program
    {
        static void Main(string[] args)
        {

            //Klavyeden girilen sayının negatif, pozitif veya sıfır olduğunu bulan C#  programını yazın


            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Int32.Parse(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Sayı Pozitif");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Sayı Negatif");
            }
            else
            {
                Console.WriteLine("Sayı Sıfır");
            }

            Console.ReadLine();
        }