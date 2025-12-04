string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("****** Převod z desítkové do binární/dvojkové soustavy *****");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Anežka Husáková ***************");
    Console.WriteLine("************** 27.11. *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte desítkové číslo(přirozené číslo): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte desítkové číslo znovu: ");
    }

    uint[] myArray = new uint[32];
    uint backupNumber10 = number10;
    uint zbytek;

    uint i;
    for(i = 0; number10 > 0; i++){
        zbytek = number10 % 2;
        number10 = (number10-zbytek)/2;
        myArray[i] = zbytek;

    Console.WriteLine("Celá část: {0}; Zbytek:{1} ", number10, zbytek);

    

    Console.Write("Desítkové číslo {0} ve dvojkové soustavě = ",backupNumber10);
    for (uint j = i-1; j >= zbytek; j--)
    {
        Console.Write ("{0}", myArray[j] );
    }

}


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

