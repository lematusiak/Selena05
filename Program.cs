var name = "Ewa";
var sex = "kobieta";
var age = 30;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex != "kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyżna");
}
else
{
    Console.WriteLine("Ktoś inny");
}
if (age == 30)
{
    Console.WriteLine("Trzydziestolatkowie");
}

Console.ReadKey();


// 1. WAŻNE: Jeśli chcesz sprawdzić, GDZIE JEST BŁĄD naduś View i Error List
// Wyświetli Ci się, w któej linii jest błąd - podpowiedź AdamaŁĄD
// 2. W powyższych: pierwsza odpowiedź fałszywa bo w założeniach jest wiek 30 lat.
// Druga prawdziwa. Trzecia fałszywa bo w założeniach płeć jest kobietą.
// 3. Więc: warunki muszą się zgadzać z założeniami
// 4. Program sprawdza zawsze do pierszego prawdziwego ifa lub elsa.
// Jeśli taki się znajdzie, dalszych prawdziwych założeń już nie rozpatruje,
// chyba, że rozpatrzymy kolejnego ifa,
// jak w ostatnim przypadku "Trzydziestolatkowie", co również program pokaże.

// 5. Ostatni else można wypisać lub nie, zależy od nas. Estetyczny else .
// Czyli zadanie polega na tym, niczym detektyw. Szukamy, szukamy pierwszej
// prawdziwej odpowiedzi. Gdy ją znajdziemy zagadka rozwiązana!

// 6. Ciekawostka od Zuzi: bool isWomen = true. W warunkach if, else if wystarczy
// pisać isWomen lub !isWomen - bo jest określony jako prawdziwy