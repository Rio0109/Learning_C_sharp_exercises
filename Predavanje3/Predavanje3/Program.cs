Console.WriteLine("Izaberi jednu od opcija: 1: 'Crvena', 2:'Zuta', 3:'Plava', 4:'Siva', 5:'izlaz'");
string opcija = Console.ReadLine();

switch (opcija)
{
    case "1":
        Console.WriteLine("Odabrana boja je crvena ");
        break;
    case "2":
        Console.WriteLine("Odabrana boja je zuta");
        break;
    case "3":
        //Console.WriteLine("Godina je: {0}", DateTime.Now.Year);
        //Console.WriteLine($"Godina je: "+DateTime.Now.Year);
        Console.WriteLine("Odabrana boja je Plava");
        break;
    case "4":
        Console.WriteLine("Odabrana boja je Siva");
        break;
    case "5":
        break;
    default:
        Console.WriteLine("Ne poznajem opciju!");
        break;
}
