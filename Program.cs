// MODUŁ 5 (LISTA Z PĘTLĄ FOREACH) 19.02.2024

int[] grades = new int[365];
List<string>dayOfWeek = new List<string>(7);

dayOfWeek.Add("monday");
dayOfWeek.Add("tuesday");
dayOfWeek.Add("wednesday");
dayOfWeek.Add("thursday");
dayOfWeek.Add("friday");
dayOfWeek.Add("saturday");
dayOfWeek.Add("sunday");

// zwróci wszystkie dni tygodnia (PĘTLA FOR)

for (var i = 0; i < dayOfWeek.Count; i++)
{
    Console.WriteLine(dayOfWeek[i]);
}

// podobnie ta pętla również zwróci dni tygodnia (PĘTLA FOREACH)
// chodzi o to, że zrobi to dużo prościej

foreach (var day in dayOfWeek)
{
    Console.WriteLine(day); 
} 

Console.ReadKey();

// Pętla "for" jest bardziej ogólnym rodzajem pętli, która wykonuje blok kodu wielokrotnie na podstawie określonego warunku.
// Możemy zdefiniować początkową wartość liczby iteracji, warunek zatrzymania oraz zwiększanie wartości iteracji wewnątrz pętli.
// Pętla "for" jest przydatna, gdy znamy dokładną liczbę iteracji, jaką chcemy wykonać.

// Z drugiej strony pętla "foreach" jest używana do iterowania po elementach
// kolekcji, takich jak tablice, listy czy słowniki. Nie musimy określać wartości
// iteracji, warunków zatrzymania czy zwiększania wartości iteracji,
// ponieważ pętla "foreach" automatycznie przechodzi przez
// wszystkie elementy kolekcji.
// Jest to bardziej wygodne i czytelne rozwiązanie,
// gdy chcemy przetworzyć wszystkie elementy kolekcji.

// Przykładem z życia codziennego może być lista zakupów:
// używając pętli "for" można by przejść przez każdy element listy,
// jednocześnie zliczając ilość zakupionych przedmiotów.
// Pętla "foreach" byłaby przydatna, gdybyśmy chcieli wypisać wszystkie
// zakupione przedmioty bez konieczności zliczania ich ilości.

