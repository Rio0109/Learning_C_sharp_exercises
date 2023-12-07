#region Zadatak1

//string pozdrav = "Dobar dan";
//int godina = 2023;
//double temperatura = 22.5;
//var brzina = 100.5f;
//decimal cijena = 99.50m;

//Console.WriteLine(pozdrav);

#endregion
#region Zadatak 2 
//int unesiBroj = 0;
//Console.WriteLine("Unesi broj:");
//unesiBroj = int.Parse(Console.ReadLine());

//bool jeParan = unesiBroj % 2 == 0;
//if(jeParan)
//{
//   Console.WriteLine("Uneseni broj je paran.");
//}
//else
//{
//   Console.WriteLine("Uneseni broj je neparan");
//}

#endregion
#region Zadatak 3
Console.WriteLine("Unesi broj X:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Unesi broj Y:");
var tekstualniUnos = Console.ReadLine();
int y = int.Parse(tekstualniUnos);
Console.WriteLine("Unesi operaciju(+,-,*,/)");
char operacija = char.Parse(Console.ReadLine());

char znak = Console.ReadLine()[0];
switch (operacija);
{
     case '+':
        Console.WriteLine("Rezultat zbrajanja:" + (x + y));
        break;
    case '-':
        Console.WriteLine("Rezultati oduzimanja:" + (x-y));
        break;
    case '*':
        Console.WriteLine("Rezultati mnozenja:" + (x * y));
        break;
    case '/':
        Console.WriteLine("Rezultati djelenja:" + (x / y));
        break;

    }
#endregion
#region Zadatak 4




#endregion