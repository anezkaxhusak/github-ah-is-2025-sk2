using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;

string again = "a";
while (again == "a")
{ //součást Main
  Console.Clear();
  razitko(); //vlastní metoda - metoda pro výpis hlavičky/razítka 
  //místo volání metody
  ulong a = nactiCislo("Zadejte přirozené číslo a) : ");
  ulong b = nactiCislo("Zadejte přirozené číslo b) : ");

  ulong nsd = vypocitejNSD(a, b);
  ulong nsn = vypocitejNSN(a, b, nsd);

  zobrazitVysledky (a, b, nsd, nsn);

  



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
//vlastní metody psát ideálně až sem

static void razitko() //nic nevrací, nic nepotřebuje (prázdé závorky)
{
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Výpočet NSD a NSN *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Anežka Husáková **************");
    Console.WriteLine("************** 11. 12. 2025 ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("");
}
static ulong nactiCislo(string zprava)
{
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte číslo znovu: ");
    }
    return cislo;
}

static ulong vypocitejNSD(ulong a, ulong b)
{
    while (a != b)
    {
        if (a > b)
        {
            a = a - b;
        } else
        {
            b = b - a;
        }
    }
    return a;

}
static ulong vypocitejNSN(ulong a, ulong b, ulong nsd, ulong nsn)
{
    return (a*b)/nsd;
}

static void zobrazitVysledky (ulong a, ulong b, ulong nsd, ulong nsn)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine();
    Console.WriteLine("========================");
    Console.WriteLine($"Největší Společný Dělitel čísel {a} a {b} je {nsd}");
    Console.WriteLine("========================");
    Console.ForegroundColor = ConsoleColor.White;

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine();
    Console.WriteLine("========================");
    Console.WriteLine($"Nejmenší Společný Násobek čísel {a} a {b} je {nsn}");
    Console.WriteLine("========================");
    Console.ForegroundColor = ConsoleColor.White;
}