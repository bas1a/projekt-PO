using System;
using System.Diagnostics;

public class SelectionSort
{
    private static int equalOperationCounter;

    private void SelectionSortAlgorithm(int[] tab)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            int smallest = i;
            for (int j = i + 1; j < tab.Length; j++)
            {
                equalOperationCounter++;
                if (tab[j] < tab[smallest])
                {
                    smallest = j;

                }
            }
            int temp = tab[smallest];
            tab[smallest] = tab[i];
            tab[i] = temp;
        }

    }


    
    public void SortRandomTable()
    {
        Table table = new Table();
        int[] tab = table.TableRandom();

        equalOperationCounter = 0;
        uint iterationsNumber = 10;
        long elapsedTime = 0;
        long minTime = long.MaxValue;
        long maxTime = long.MinValue;
        for (int n = 0; n < (iterationsNumber + 1 + 1); ++n)
        {
            long startingTime = Stopwatch.GetTimestamp();

            // Poniżej wywołujemy metodę sortowania, która jest w pętli 10 - ciu powtórzeń.
            SelectionSortAlgorithm(tab);

            long endingTime = Stopwatch.GetTimestamp();
            long iterationElapsedTime = endingTime - startingTime;
            elapsedTime += iterationElapsedTime;
            if (iterationElapsedTime < minTime)
            {
                minTime = iterationElapsedTime;
            }
            if (iterationElapsedTime > maxTime)
            {
                maxTime = iterationElapsedTime;
            }
        }

        elapsedTime -= (minTime + maxTime);
        double elapsedSeconds = elapsedTime * (1.0 / (iterationsNumber * Stopwatch.Frequency));

        Console.WriteLine("Sortowanie tablicy liczb losowych algorytmem przez wybieranie:" +
            "\n Liczba operacji sortowania: {0}. Średni czas przebiegu operacji: {1} [s]," +
            "\n zakładając odrzucenie czasów skrajnych.", equalOperationCounter, elapsedSeconds.ToString("F8"));

        Console.WriteLine();
        Console.WriteLine("\n===========================================\n");
    }




    public void SortIncreaseTable()
    {
        Table table = new Table();
        int[] tab = table.TableIncrease();

        equalOperationCounter = 0;
        uint iterationsNumber = 10;
        long elapsedTime = 0;
        long minTime = long.MaxValue;
        long maxTime = long.MinValue;
        for (int n = 0; n < (iterationsNumber + 1 + 1); ++n)
        {
            long startingTime = Stopwatch.GetTimestamp();

            // Poniżej wywołujemy metodę sortowania, która jest w pętli 10 - ciu powtórzeń.
            SelectionSortAlgorithm(tab);

            long endingTime = Stopwatch.GetTimestamp();
            long iterationElapsedTime = endingTime - startingTime;
            elapsedTime += iterationElapsedTime;
            if (iterationElapsedTime < minTime)
            {
                minTime = iterationElapsedTime;
            }
            if (iterationElapsedTime > maxTime)
            {
                maxTime = iterationElapsedTime;
            }
        }
        elapsedTime -= (minTime + maxTime);
        double elapsedSeconds = elapsedTime * (1.0 / (iterationsNumber * Stopwatch.Frequency));

        Console.WriteLine("Sortowanie tablicy liczb od najmniejszej do największej algorytmem przez wybieranie:" +
            "\n Liczba operacji sortowania: {0}. Średni czas przebiegu operacji: {1} [s]," +
            "\n zakładając odrzucenie czasów skrajnych.", equalOperationCounter, elapsedSeconds.ToString("F8"));

        Console.WriteLine();
        Console.WriteLine("\n===========================================\n");
    }




    public void SortDecreaseTable()
    {
        Table table = new Table();
        int[] tab = table.TableDecrease();        

        equalOperationCounter = 0;
        uint iterationsNumber = 10;
        long elapsedTime = 0;
        long minTime = long.MaxValue;
        long maxTime = long.MinValue;
        for (int n = 0; n < (iterationsNumber + 1 + 1); ++n)
        {
            long startingTime = Stopwatch.GetTimestamp();

            // Poniżej wywołujemy metodę sortowania, która jest w pętli 10 - ciu powtórzeń.
            SelectionSortAlgorithm(tab);

            long endingTime = Stopwatch.GetTimestamp();
            long iterationElapsedTime = endingTime - startingTime;
            elapsedTime += iterationElapsedTime;
            if (iterationElapsedTime < minTime)
            {
                minTime = iterationElapsedTime;
            }
            if (iterationElapsedTime > maxTime)
            {
                maxTime = iterationElapsedTime;
            }
        }
        elapsedTime -= (minTime + maxTime);
        double elapsedSeconds = elapsedTime * (1.0 / (iterationsNumber * Stopwatch.Frequency));

        Console.WriteLine("Sortowanie tablicy liczb od największej do najmniejszej algorytmem przez wybieranie:" +
            "\n Liczba operacji sortowania: {0}. Średni czas przebiegu operacji: {1} [s]," +
            "\n zakładając odrzucenie czasów skrajnych.", equalOperationCounter, elapsedSeconds.ToString("F8"));

        Console.WriteLine();
        Console.WriteLine("\n===========================================\n");
    }



    public void PrintTable()
    {
        Console.WriteLine("Wyświetlić tablicę liczb? T/N \n");
        string? choice = Console.ReadLine();

        if (choice == "t")
        {
            Table table = new Table();
            
            // Deklarujemy tablicę liczb losowych
            int[] tabR = table.TableRandom();

            Console.WriteLine("Tablica liczb losowych: \n");
            for (int i = 0; i < tabR.Length; i++)
            {
                Console.Write("{0}, ", tabR[i]);
            }
            Console.WriteLine("\n ======================================== \n");

            // Deklarujemy tablicę liczb od największej do najmniejszej
            int[] tabD = table.TableDecrease();

            Console.WriteLine("Tablica liczb od największej do najmniejszej: \n");
            for (int i = 0; i < tabD.Length; i++)
            {
                Console.Write("{0}, ", tabD[i]);
            }
            Console.WriteLine("\n ======================================== \n");
            
            // Sortujemy tablicę liczb losowych.
            SelectionSortAlgorithm(tabR);
            
            Console.WriteLine("Sortowanie przez wybieranie: " +
                "\n Posortowana tablica liczb losowych: \n");
            for (int i = 0; i < tabR.Length; i++)
            {
                Console.Write("{0}, ", tabR[i]);
            }
            Console.WriteLine("\n ======================================== \n");


            // Sortujemy tablicę liczb od największej do najmniejszej.
            SelectionSortAlgorithm(tabD);

            Console.WriteLine("Sortowanie przez wybieranie: " +
                "\n Posortowana tablica liczb od największej do najmniejszej: \n");
            for (int i = 0; i < tabD.Length; i++)
            {
                Console.Write("{0}, ", tabD[i]);
            }
            Console.WriteLine();
            Console.WriteLine("\n ======================================== \n");
        }
    }
}
