using System;

 namespace Task1
 {
     internal class Program
     {
         static void Main(string[] args)
         {
             Console.Write("Введiть рiк: ");
            int year = int.Parse(Console.ReadLine() ?? "0");

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
             {
                 Console.WriteLine("Рiк є високосним");
             }
             else
             {
                 Console.WriteLine("Рiк не високосний");
             }

             Console.ReadLine();
         }
     }
 }
