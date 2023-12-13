#region vjezbam 

using System.ComponentModel.Design;
using System.Drawing;
using System.Xml.Linq;

Console.WriteLine("Dobrodosao korisnice!");

string ime = ("Ivan");

string prezime = ("Ristovski");

int novcanik = (100);

string punoIme = (ime +" "+ prezime);  // +" "+ znak za razmak izmedju stringova u istom redu , izmedju navodnika dodajem razmaka koliko ocu

int mojeGodine = (22);

int punoljetnaOsoba = (18);

double mojeGodineiMjeseci = (22.3);

char pocetnoSlovoImena = ('I');

bool daLiSamMusko = true;

double euroVrijednostKN = (7.53), euroVrijednostDollar = (1.03), eurVrijednostMarke = (1.87);

const  double vrijednostPI = (3.14159);        // Konstanta = Ne moguce prominit vrijednost ni ja sam ni neko drugi kasnije u kodu  deklarira se prije tipa podatka

string funFact = ($"Da li ste znali da je vrijednost PI-a: {vrijednostPI} = zanimljivoo");

Console.WriteLine($"Moji podatci:  \n {punoIme} \n {mojeGodine} \n {mojeGodineiMjeseci} \n {pocetnoSlovoImena} \n {daLiSamMusko} \n{funFact} ");

Console.WriteLine($"U novcaniku imam: {novcanik * euroVrijednostKN} kuna ili ti ga {novcanik} eura. \nDok dolara imam {novcanik*euroVrijednostDollar}.\nU markama bi to bilo: {novcanik*eurVrijednostMarke} maraka");


// drugi nacin losiji jer nema razmaka Console.WriteLine("Ovo su moji podatci:" + ime + mojeGodine +mojeGodineiMjeseci +pocetnoSlovoImena + daLiSamMusko +porukaSvijetu);

// \n komanda za ispis u novi red  , dodajem ju prije poziva funkcije

Console.WriteLine("Unesi ime");
string korisnikime = Console.ReadLine();
string imeKorisnikaa = ($"Unesi ime {korisnikime}.");
Console.WriteLine($"Dobrodosao u konzolu {korisnikime} ♥♥♥♥♥♥");

// Ovdi vidimo primjer castanja pretvaranaj int u string kako bi se moga odradit readline !
Console.WriteLine("Unesi godine");
int korisnikgodine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Vi imate {korisnikgodine} godine!");


/* Indeks pozivanje od 0

string myString = "Hello";
Console.WriteLine(myString[1]);

string myString2 = "Hello";
Console.WriteLine(myString2.IndexOf("e"));  // Outputs "1"

 */
if (korisnikgodine >= punoljetnaOsoba)
{
    Console.WriteLine("Punoljetni ste mozete nastaviti s pristupom");
}

else 
{
    Console.WriteLine("Zabranjen pristup maloljetnicima!");
}

#endregion
