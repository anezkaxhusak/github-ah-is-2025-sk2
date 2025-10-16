// See https://aka.ms/new-console-template for more information
Console.WriteLine();

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("------------- Výpis číselné řady -------------");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("------------- Anežka Husáková -------------");
    Console.WriteLine("------------------ 2.10. ------------------");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine();



    //vstup hodnot do programu, ale špatně řešený
    // Console.Write("Zadejte první číslo řady: ");
    // int first = int.Parse(Console.ReadLine());

    //vstup hodnot do programu, řešen lépe
    Console.WriteLine("Zadejte první číslo řady: ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine("Nezadali jste celé číslo, zadejte první číslo znovu");
    }
    //vykřičník = negace
    Console.WriteLine("Zadejte poslední číslo řady: ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.WriteLine("Nezadali jste celé číslo, zadejte poslední číslo řady znovu");
    }

    Console.WriteLine("Zadejte diferenci (celé číslo) ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.WriteLine("Nezadali jste celé číslo, zadejte diferenci znovu");
    }



    //Výstup zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("===============================");
    Console.WriteLine("Zadali jste tyto hodnoty : ");
    Console.WriteLine("První číslo řady: {0}", first);
    Console.WriteLine("Poslední číslo řady: {0}", last);
    Console.WriteLine("Diference : {0}", step);
    Console.WriteLine("===============================");
    Console.WriteLine("První číslo: {0}; poslední číslo: {1}; difernce:{2}", first, last, step);
    Console.WriteLine("===============================");

    //výpis číslené řady

    Console.WriteLine();
    Console.WriteLine("===============================");
    Console.WriteLine("Výpis číselné řady");
    Console.WriteLine("===============================");
   // Console.WriteLine();

    int current = first;
    while (current <= last) { //dokud
        Console.WriteLine(current);
        current = current + step; //přičtení diference. důelžitá priorita operátorů, ' = ' má menší prioritu než ' + '. Nejdříve se provede pravá strana

    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}

