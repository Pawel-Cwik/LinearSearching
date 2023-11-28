using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
namespace projekt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generowanie tablic wypełnionych danymi
            Random rnd = new Random();
            Random randomN = new Random();
            int numberOfTables = 10;
            List<int[]> listOfTables = new List<int[]>();
            for (int i = 0; i < numberOfTables; i++)
            {
                int tableSize = (i + 1) * 10000000;
                int[] newTable = new int[tableSize];
                for (int j = 0; j < tableSize; j++)
                {
                    newTable[j] = rnd.Next();
                }
                listOfTables.Add(newTable);
            }
            //Przeszukiwanie Liniowe dla maksymalnej wartości tablicy
            int computiationalComplexity = 0;

            for (int j = 0; j < numberOfTables; j++)
            {        
                Array.Sort(listOfTables[j]);
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < listOfTables[j].Length; i++)
                {

                    stopWatch.Start();
                    if (listOfTables[j][i] == listOfTables[j][listOfTables[j].Length - 1])
                    {
                        computiationalComplexity++;
                        stopWatch.Stop();
                        TimeSpan elapsedTimeLinearSearching = stopWatch.Elapsed;
                        Console.WriteLine($"Znaleziono maksymalna wartosc tablicy o wielkosci {listOfTables[j].Length} | Wartość: {listOfTables[j][i]}");
                        Console.WriteLine($"Czas na wykonanie operacji: {elapsedTimeLinearSearching} | Złożoność obliczeniowa: {computiationalComplexity}");
                        computiationalComplexity = 0;
                        break;
                    }
                    else { computiationalComplexity++; }


                }

                /* // Przeszukiwanie liniowe dla losowo wybieranych wartości

                 int random = randomN.Next(0, listOfTables[j].Length);
                 for (int i = 0; i < listOfTables[j].Length; i++)
                 {

                     stopWatch.Start();
                     if (listOfTables[j][i] == listOfTables[j][random])
                     {
                         computiationalComplexity++;
                         stopWatch.Stop();
                         TimeSpan elapsedTimeLinearSearching = stopWatch.Elapsed;
                         Console.WriteLine($"Znaleziono poszukiwaną wartość tablicy o wielkosci {listOfTables[j].Length} | Wartość {listOfTables[j][i]}");
                         Console.WriteLine($"Czas na wykonanie operacji: {elapsedTimeLinearSearching} | Złożoność obliczeniowa {computiationalComplexity}");
                         computiationalComplexity = 0;
                         break;
                     }
                     else
                     {
                         computiationalComplexity++;

                     }


                 }

                 */


            }
 

        }



    }
}