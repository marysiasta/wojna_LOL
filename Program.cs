using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoL_wojna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Witaj w grze Wojna League of Legends...");
            Console.WriteLine("Tutaj bohaterowie legendarnego LoLa, stana oko w oko w bitwie.");
            Console.WriteLine("Wygra ten gracz, który pokona wszystkich przeciwników swoją mocą.");
            Console.WriteLine("Sprawdźmy komu sprzyja los szczęścia.");

            int liczba_kart_gracz1 = 5;
            int liczba_kart_gracz2 = 5;

            string[] bohaterowie_gracz1 ={ "Fiora", "Katarina", "Garen", "Soraka", "Sivir" };
            string[] bohaterowie_gracz2 = { "Jax", "Diana", "Bard", "Azir", "Galio" };
            int[] moc_bohaterow_gracz1 = { 1, 2, 3, 4, 5 };
            int[] moc_bohaterow_gracz2 = { 1, 2, 3, 4, 5 };
            
            bool czy_koniec = false;
            Random random = new Random();
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Liczba kart gracz1:{liczba_kart_gracz1} || Liczba kart gracz2:{liczba_kart_gracz2}");
                int losowa_liczba_gracz1 = random.Next(0, 5);
                int losowa_liczba_gracz2 = random.Next(0, 5);
                Console.WriteLine("Walkę stoczy:");
                Console.WriteLine($"G2:{bohaterowie_gracz2[losowa_liczba_gracz2]}    vs.   G1:{bohaterowie_gracz1[losowa_liczba_gracz1]}");
                Console.WriteLine($"Porównanie mocy:");
                if(moc_bohaterow_gracz1[losowa_liczba_gracz1]>moc_bohaterow_gracz2[losowa_liczba_gracz2])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{moc_bohaterow_gracz1[losowa_liczba_gracz1]}  >   {moc_bohaterow_gracz2[losowa_liczba_gracz2]}");
                     Console.WriteLine("Kartę zdobywa gracz1!!");
                     liczba_kart_gracz1 = liczba_kart_gracz1+1;
                     liczba_kart_gracz2 = liczba_kart_gracz2-1;

                    
                }
                else if (moc_bohaterow_gracz1[losowa_liczba_gracz1] < moc_bohaterow_gracz2[losowa_liczba_gracz2])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{moc_bohaterow_gracz1[losowa_liczba_gracz1]}  <  {moc_bohaterow_gracz2[losowa_liczba_gracz2]}");
                    Console.WriteLine("Kartę zdobywa gracz2!!");
                    liczba_kart_gracz1 = liczba_kart_gracz1 - 1;
                    liczba_kart_gracz2 = liczba_kart_gracz2 + 1;
                }
                else
                {
                    Console.WriteLine($"{moc_bohaterow_gracz1[losowa_liczba_gracz1]}  =  {moc_bohaterow_gracz2[losowa_liczba_gracz2]}");
                    Console.WriteLine("Użyj kolejnej karty by wygrać");
                  
                }
                    System.Threading.Thread.Sleep(1000);
                if(liczba_kart_gracz1==0 || liczba_kart_gracz2==0)
                {
                    czy_koniec = true;
                }
            } while (czy_koniec == false);

            if(liczba_kart_gracz2==0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wygrał gracz1!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wygrał gracz2!");
            }
            Console.ReadKey();
         }
    }
}
