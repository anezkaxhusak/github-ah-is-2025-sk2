string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Název programu *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Anežka Husáková ***************");
    Console.WriteLine("************** datum *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte přesnost (číslo): ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost))
    {
        Console.Write("Nezadali jste správné číslo. Zadejte přesnost: ");
    } 
    
    
    double i = 1;
    double piCtvrt = 1;
    double znamenko = 1;

    while ((1 / i) >= presnost)
    {
        i = i + 2;
        znamenko = -znamenko;
        piCtvrt = piCtvrt + znamenko * (1 / i);
        
        if (znamenko == 1)
        {
            Console.WriteLine("Zlomek: +1/{0}; aktuální hodnota PI = {1}", i, 4 * piCtvrt);
        }
        else
        {
           Console.WriteLine("Zlomek: -1/{0}; aktuální hodnota PI = {1}", i, 4 * piCtvrt); 
        }
    } 

    Console.WriteLine("\n\n Hodnota čísla PI = {0}", 4 * piCtvrt);





    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

