// TABLICE

using System.Security.Cryptography;

// PIERWSZY SPOSÓB

int[] grades = new int[365];
string[] dayOfWeek = new string[7];
dayOfWeek[0] = "monday";
dayOfWeek[1] = "tuesday";
dayOfWeek[2] = "wednesday";
dayOfWeek[3] = "thursday";
dayOfWeek[4] = "friday";
dayOfWeek[5] = "saturday";
dayOfWeek[6] = "sunday";

// Console.WriteLine(dayOfWeek[3]);

// DRUGI SPOSÓB

// string[] dayOfWeek2 = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };

// Console.WriteLine(dayOfWeek2[0]);

// i++ to to samo, co i = i + 1
// to pętla w najczystszej postaci, wyświetlą się wszystkie dni tygodnia

for (var i = 0; i < 7; i++)
{
    Console.WriteLine(dayOfWeek[i]);
}

// a w tej pętli zabezpieczamy się przed tym, gdyby ktoś w kodzie kiedys
// wartość 7 na inną

for (var i = 0; i < dayOfWeek.Length; i++)
{
    Console.WriteLine(dayOfWeek[i]);
}

// a w ostatniej pętli zwrócony zostanie monday, thursday, sunday (co trzeci dzień)
for (var i = 0; i < dayOfWeek.Length; i= i+3)
{
    Console.WriteLine(dayOfWeek[i]);
}

Console.ReadKey();
