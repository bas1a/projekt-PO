using System;
using System.Diagnostics;

public class HeapSort
{
    private static int equalOperationCounter;

    private void Heapify(int[] tab, uint left, uint right)
    {
        equalOperationCounter++;
        uint i = left;
        uint j = 2 * i + 1;
        int buf = tab[i];
        while(j <= right)
        {
            if (j < right)
            {
                if (tab[j] < tab[j + 1])
                {
                    j++;
                }
            }
            if (buf >= tab[j])
            {
                break;
            }
            tab[i] = tab[j];
            i = j;
            j = 2 * i + 1;
        }
        tab[i] = buf;
    }



    private void HeapSortAlgorithm(int[] tab)
    {
        uint left = ((uint)tab.Length / 2);
        uint right = (uint)tab.Length - 1;
        while (left > 0)
        {
            left--;
            Heapify(tab, left, right);
        }
        while (right > 0)
        {
            int buf = tab[left];
            tab[left] = tab[right];
            tab[right] = buf;
            right--;
            Heapify(tab, left, right);
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
            HeapSortAlgorithm(tab);

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

        Console.WriteLine("Sortowanie tablicy liczb losowych algorytmem stogowym (heap sort):" +
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
            HeapSortAlgorithm(tab);

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

        Console.WriteLine("Sortowanie tablicy liczb od najmniejszej do największej algorytmem stogowym (heap sort):" +
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
            HeapSortAlgorithm(tab);

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

        Console.WriteLine("Sortowanie tablicy liczb od największej do najmniejszej algorytmem stogowym (heap sort):" +
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
            HeapSortAlgorithm(tabR);

            Console.WriteLine("Sortowanie algorytmem stogowym (heap sort): " +
                "\n Posortowana tablica liczb losowych: \n");
            for (int i = 0; i < tabR.Length; i++)
            {
                Console.Write("{0}, ", tabR[i]);
            }
            Console.WriteLine("\n ======================================== \n");


            // Sortujemy tablicę liczb od największej do najmniejszej.
            HeapSortAlgorithm(tabD);

            Console.WriteLine("Sortowanie algorytmem stogowym (heap sort): " +
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
