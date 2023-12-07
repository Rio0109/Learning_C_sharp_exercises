
// See https://aka.ms/new-console-template for more information

#region Primjer 1
//string test = "Hello, World!";
//int broj = 10;
//double decimalni = 10.2;
//var _float = 10.2f;
//decimal _decimal = 10.2m;

//Console.WriteLine(test);
//Console.ReadLine();
#endregion

#region Zadatak 1
//int broj;
//Console.WriteLine("Unesi neki broj: ");


//Jedonstavno ali široko
//var odgovorKorsinika = Console.ReadLine();
//broj = int.Parse(Console.ReadLine());
//bool paran = false;

//if(broj % 2 == 0)
//{
//	paran = true;
//}

//if (paran)
//{
//	Console.WriteLine("Broj je paran");
//}
//else
//{
//	Console.WriteLine("Broj je neparan");
//}



//if(int.Parse(Console.ReadLine()) % 2 == 0)
//{
//	Console.WriteLine("Broj je paran");
//}
//else
//{
//	Console.WriteLine("Broj je neparan");
//}
#endregion





#region Zadatak 2
Console.WriteLine(float.MinValue);
Console.WriteLine(float.MaxValue);


Console.WriteLine("Unesi broj A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Unesi broj B");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Unesi znak");
char znak = char.Parse(Console.ReadLine());


switch (znak)
{
	case '+':
		Console.WriteLine("Zbroj je: " + (a+b));
		break;
	case '*':
		Console.WriteLine("Umozak je: " + (a * b));
		break;
	case '-':
		Console.WriteLine("Razlika je: " + (a - b));
		break;
	case '/':
		Console.WriteLine("Razlika je: " + (a / b));
		break;



	default:
		break;
}


//if (znak == '+')
//{
//	var rezultat = a + b;
//	Console.WriteLine("Zbroj je: " + rezultat);
//}

//else if (znak == '*')
//{
//	var rezultat = a * b;
//	Console.WriteLine("Umozak je: " + rezultat);
//}

//else
//{
//	var rezultat = a - b;
//	Console.WriteLine("Razlika je: " + rezultat);
//}
//var rezultat = a + b;
//Console.WriteLine("Zbroj je: " + rezultat);

//var rezultat = a * b;
//Console.WriteLine("Umozak je: " + rezultat);


#endregion