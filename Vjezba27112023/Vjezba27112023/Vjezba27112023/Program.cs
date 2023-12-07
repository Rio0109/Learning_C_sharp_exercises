
#region Zadatak 1
//string pozdrav = "Dobar dan";
//int godina = 2023;
//double temperatura = 25.3;
//var brzina = 100.5f;
//decimal cijena = 99.99m;
//bool tocan = false;


//Console.WriteLine(pozdrav);
#endregion
#region Zdatak 2
//int uneseniBroj = 0;
//Console.WriteLine("Unesi broj:");
//uneseniBroj = int.Parse(Console.ReadLine());

//bool jeParan = uneseniBroj % 2 == 0;
//if(jeParan)
//{
//    Console.WriteLine("Uneseni broj je paran.");
//}

//else
//{
//    Console.WriteLine("Uneseni broj je neparan");
//}

#endregion
#region Zadatak 3
//Console.WriteLine("Najmanja vrijednost double: " + double.MinValue);
//Console.WriteLine("Najveća vrijednost double: " + double.MaxValue);

//Console.WriteLine("Najmanja vrijednost float: " + float.MinValue);
//Console.WriteLine("Najveća vrijednost float: " + float.MaxValue);

//Console.WriteLine("Najmanja vrijednost decimal: " + decimal.MinValue);
//Console.WriteLine("Najveća vrijednost decimal: " + decimal.MaxValue);


//Console.WriteLine("Unesi broj X:");
//int x = int.Parse(Console.ReadLine());


//Console.WriteLine("Unesi broj Y:");
//string tekstualniUnos = Console.ReadLine();
//int y = int.Parse(tekstualniUnos);

//Console.WriteLine("Unesi operaciju (+, -, *, /):");
//char operacija = char.Parse(Console.ReadLine());
////*

//switch (operacija)
//{
//	case '+':
//		Console.WriteLine("Rezultat zbrajanja: " + (x + y));
//		break;
//	case '-':
//		Console.WriteLine("Rezultat oduzimanja: " + (x - y));
//		break;
//	case '*':
//		Console.WriteLine("Rezultat množenja: " + (x * y));
//		break;
//	case '/':
//		Console.WriteLine("Rezultat dijeljenja: " + (x / y));
//		break;
//	default:
//		Console.WriteLine("Nepoznata operacija.");
//		break;
//}

#endregion
#region Zadatak 4
//DateTime trenutniDatum = DateTime.Now;
//DateTime rodendan = new DateTime(1995,5,23);
//TimeSpan razlika = trenutniDatum - rodendan;


//Console.WriteLine("Današnji datum: " + trenutniDatum.ToString("dd.MMMM.yyyy."));
//Console.WriteLine("Današnji datum: " + trenutniDatum.ToString("dd.MMM.yyyy."));
//Console.WriteLine("Današnji datum: " + trenutniDatum.ToString("dd.MM.yyyy."));
//Console.WriteLine("Rođendan: " + rodendan.ToString("dd.MM.yyyy."));
//Console.WriteLine("Prošlo je dana od rođendana: " + razlika.Days);
//Console.ReadLine();
#endregion
#region Zadatak 5
//Console.WriteLine("Unesi neku rijec:");
//string rijec = Console.ReadLine();


////TODO: za DZ napraviti dinmicni unos broja znakova
////int unioKorsinik = 0;

//if (rijec.Length > 5)
//{
//	Console.WriteLine("Riječ ima više od 5 slova.");
//}
//else if (rijec.Length == 5)
//{
//	//Console.WriteLine("Riječ ima točno {0} slova.", unioKorsinik);
//	Console.WriteLine("Riječ ima točno 5 slova.");
//}

//else
//{
//	Console.WriteLine("Riječ ima manje od 5 slova.");
//}

//var prviKorakZaIspisUnazad = rijec.Reverse();
//var drugiKorakZaIspisUnazad = prviKorakZaIspisUnazad.ToArray();
//var treciKorakZaIspisUnazad = new string(drugiKorakZaIspisUnazad);

//Console.WriteLine("Riječ unatrag: " + treciKorakZaIspisUnazad);
////Console.WriteLine("Riječ unatrag: " + new string(rijec.Reverse().ToArray()));
#endregion
#region Zadatak 6
// Zadatak: Zamijeniti sva pojavljivanja jednog slova drugim slovom
//Console.WriteLine("Unesi neki tekst:");
//string tekst = Console.ReadLine();


//Console.WriteLine("Koje slovo želiš zamijeniti?");
//char stariZnak = char.Parse(Console.ReadLine());


//Console.WriteLine("S kojim slovom želiš zamijeniti?");
//char noviZnak = char.Parse(Console.ReadLine());

//string izmijenjenTekst = tekst.Replace(stariZnak, noviZnak);
//Console.WriteLine("Izmijenjeni tekst: " + izmijenjenTekst);
#endregion
#region Zadatak 7
//Zadatak: Napisati program koji će tražiti od korisnika da unese tri broja, jedan po jedan, i
//zatim će izračunati i ispisati prosjek tih brojeva, kao i najmanji i najveći uneseni broj.

//Console.WriteLine("Unesi prvi broj:");
//int broj1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Unesi drugi broj:");
//int broj2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Unesi treći broj:");
//int broj3 = int.Parse(Console.ReadLine());

//int suma = broj1 + broj2 + broj3;
//double prosjek = (double)suma / 3;

//int najmanji = broj1;
//if(broj2 < najmanji)
//{
//	najmanji = broj2;
//}
//if(broj3 < najmanji)
//{
//	najmanji = broj3;
//}

//int najveci = broj1;
//if(broj2 > najveci)
//{
//	najveci = broj2;
//}

//if(broj3> najveci)
//{
//	najveci = broj3;
//}


//Console.WriteLine($"Prosjek: {prosjek:F2}");
//Console.WriteLine($"Najmanji broj: {najmanji}");
//Console.WriteLine($"Najveći broj: {najveci}");

#endregion

#region Zadatak 8
//Zadatak: Napisati program koji traži od korisnika da unese dva broja.
//Program treba provjeriti jesu li oba broja parna ili neparna.
//Ako jesu, ispisati "Oba broja su parna" ili "Oba broja su neparna". Ako nisu, ispisati "Brojevi su različiti".


Console.WriteLine("Unesi prvi broj:");
int prviBroj = int.Parse(Console.ReadLine());

Console.WriteLine("Unesi drugi broj:");
int drugiBroj = int.Parse(Console.ReadLine());


bool prviBrojParan = prviBroj % 2 == 0;
bool drugiBrojParan = drugiBroj % 2 == 0;

if (prviBrojParan && drugiBrojParan)
{
	Console.WriteLine("Oba broja su parna.");
}

else if (!prviBrojParan && !drugiBrojParan)
{
	Console.WriteLine("Oba broja su neparna");
}

else
{
	Console.WriteLine("Brojevi su različiti!");
}

#endregion

