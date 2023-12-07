#region Zadatak1
//Console.WriteLine("Unesi neki tekst:");
//string unos = Console.ReadLine();
//int brojZnakova = unos.Length;
//Console.WriteLine($"Upisano je {brojZnakova} znakova.");
#endregion
#region Zadatak2
// Unos broja
Console.Write("Unesite broj: ");
int uneseniBroj = int.Parse(Console.ReadLine());

// Unos riječi
Console.Write("Unesite riječ: ");
string unesenaRijec = Console.ReadLine();

// Usporedba duljine broja i riječi
int duljinaRijeci = unesenaRijec.Length;

if (duljinaRijeci == uneseniBroj)
{
    Console.WriteLine($"Riječ ima točno {duljinaRijeci} slova.");
}
else if (duljinaRijeci < uneseniBroj)
{
    Console.WriteLine($"Riječ ima manje od {uneseniBroj} slova.");
}
else
{
    Console.WriteLine($"Riječ ima više od {uneseniBroj} slova.");
}
#endregion