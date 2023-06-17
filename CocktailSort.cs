using System;
using System.Diagnostics;

public class CocktailSort
{
    private static int equalOperationCounter;

    private void CocktailSortAlgorithm(int[] tab)
    {
        int Left = 1, Right = tab.Length - 1, k = tab.Length - 1;
        do
        {
            for (int j = Right; j >= Left; j--)
            {
                if (tab[j - 1] > tab[j])
                {
                    equalOperationCounter++;
                    int Buf = tab[j - 1];
                    tab[j - 1] = tab[j];
                    tab[j] = Buf;
                    k = j;
                }
            }
            Left = k + 1;
            for (int j = Left; j <= Right; j++)
            {
                if (tab[j - 1] > tab[j])
                {
                    equalOperationCounter++;
                    int Buf = tab[j - 1];
                    tab[j - 1] = tab[j];
                    tab[j] = Buf;
                    k = j;
                }
            }
            Right = k - 1;
        }
        while (Left <= Right);
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
            CocktailSortAlgorithm(tab);

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

        Console.WriteLine("Sortowanie tablicy liczb losowych algorytmem mieszanym, tzw. koktajlowym:" +
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
            CocktailSortAlgorithm(tab);

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

        Console.WriteLine("Sortowanie tablicy liczb od najmniejszej do największej algorytmem mieszanym, tzw. koktajlowym:" +
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
            CocktailSortAlgorithm(tab);

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

        Console.WriteLine("Sortowanie tablicy liczb od największej do najmniejszej algorytmem mieszanym, tzw. koktajlowym:" +
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
            CocktailSortAlgorithm(tabR);

            Console.WriteLine("Sortowanie mieszane, tzw. koktajlowe: " +
                "\n Posortowana tablica liczb losowych: \n");
            for (int i = 0; i < tabR.Length; i++)
            {
                Console.Write("{0}, ", tabR[i]);
            }
            Console.WriteLine("\n ======================================== \n");


            // Sortujemy tablicę liczb od największej do najmniejszej.
            CocktailSortAlgorithm(tabD);

            Console.WriteLine("Sortowanie mieszane, tzw. koktajlowe: " +
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
