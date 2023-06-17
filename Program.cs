namespace Zadanie_projektowe_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                RunProgram();
                Console.WriteLine();
            }
            while (EndProgram());
        }


        private static void RunProgram()
        {
            SelectionSort selectionSort = new SelectionSort();
            InsertionSort insertionSort = new InsertionSort();
            HeapSort heapSort = new HeapSort();
            CocktailSort cocktailSort = new CocktailSort();
            Quicksort quicksort = new Quicksort();


            Console.WriteLine("Przedmiot: Programowanie obiektowe" +
                "\n " +
                "\n Zadanie na zaliczenie: " +
                "\n Testowanie algorytmów sortowania:" +
                "\n " +
                "\n\t Autor: Barbara Sławińska " +
                "\n " +
                "\n Testujemy 3 tabele zawierające 500 liczb:" +
                "\n " +
                "\n\t 1. pierwsza tabela jest tabelą liczb losowych" +
                "\n\t 2. druga tabela jest tabelą liczb od najmniejszych do największych" +
                "\n\t 3. trzecia tabela jest tabelą liczb od największych do najmniejszych." +
                "\n " +
                "\n Na koniec aplikacja drukuje na konsoli tablicę posortowanych liczb." +
                "\n" +
                "\n Każdy z podanych niżej algorytmów, jak i tablice liczb są podzielone na osobne klasy zapisane w osobnych plikach.");

            Console.WriteLine("\n===========================================\n");

            Console.WriteLine("Jaki algorytm chcesz wybrać?" +
                "\n 1. Sortowanie przez wybieranie (Selection Sort)." +
                "\n 2. Sortowanie przez wstawianie (Insertion Sort)." +
                "\n 3. Sortowanie stogowe (Heap Sort)." +
                "\n 4. Sortowanie koktajlowe (Coctail Sort)." +
                "\n 5. Sortowanie szybkie iteracyjne i rekurencyjne (Quick Sort).");
            Console.WriteLine();

            string? n = Console.ReadLine();

            switch (n)
            {
                case "1":
                    Console.WriteLine();
                    selectionSort.SortRandomTable();
                    selectionSort.SortIncreaseTable();
                    selectionSort.SortDecreaseTable();
                    selectionSort.PrintTable();
                    break;
                case "2":
                    Console.WriteLine();
                    insertionSort.SortRandomTable();
                    insertionSort.SortIncreaseTable();
                    insertionSort.SortDecreaseTable();
                    insertionSort.PrintTable();
                    break;
                case "3":
                    Console.WriteLine();
                    heapSort.SortRandomTable();
                    heapSort.SortIncreaseTable();
                    heapSort.SortDecreaseTable();
                    heapSort.PrintTable();
                    break;
                case "4":
                    Console.WriteLine();
                    cocktailSort.SortRandomTable();
                    cocktailSort.SortIncreaseTable();
                    cocktailSort.SortDecreaseTable();
                    cocktailSort.PrintTable();
                    break;
                case "5":
                    Console.WriteLine();
                    quicksort.SortRandomTableIteration();
                    quicksort.SortRandomTableRecursion();
                    quicksort.PrintTable();
                    break;
            }
            Console.WriteLine();
        }


        private static bool EndProgram()
        {
            string? end;
            Console.WriteLine("Czy chcesz zakończyć program? \n" +
                "Tak - naciśnij Enter. \n" +
                "Nie - wpisz słowo 'nie'.");
            end = Console.ReadLine();
            Console.WriteLine();

            if (end == "nie")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
