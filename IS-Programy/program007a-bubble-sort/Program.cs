using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************************************");
    Console.WriteLine("*********** Generátor pseoudonáhodných čísel *************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("******************* Anežka Husáková **********************");
    Console.WriteLine("********************* 20.11. 2025 *************************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte počet generovaných čísel (celé číslo): \n");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: \n");
    }
    Console.Write("Zadejte dolní mez (celé číslo): \n");
    int lowerBound; //lower bound = dolní mez 
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: \n");
    }
    Console.Write("Zadejte horní mez (celé číslo): \n");
    int upperBound; //lower bound = dolní mez 
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez čísel znovu: \n");
    }


    Console.WriteLine("");
    Console.WriteLine("===========================");
    Console.WriteLine("Zadané hodnoty : ");
    Console.WriteLine($"Počet čísel : {n}, Dolní mez : {lowerBound}, Horní mez : {upperBound}");
    Console.WriteLine("============================");
    Console.WriteLine("");

    //Deklarace pole (array)
    int[] myRandNumbs = new int[n];

    //příprava pro využití třídy Random
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(15); stejný vstup --> stejné výsledky


    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)

    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0};", myRandNumbs[i]);


    }

    Stopwatch myStopwatch = new Stopwatch();

    int compare = 0; //počet porovnávání, ke kterým došlo
    int change = 0;  //počet výměn


    myStopwatch.Start();

    for (int i = 0; i < n - 1; i++) //n - 1 - abychom nepřešvihli pole. i < n - aby to projelo všechny čísla
    {
        //tento cyklus musí zajistit porovnávání dvou sousedních hodnot
        // musí dále zajistit aby se zmenšoval počet porovnávaných hodnot
        for (int j = 0; j < n - i - 1; j++)
        {
            if (myRandNumbs[j] > myRandNumbs[j + 1])
            {
                int tmp = myRandNumbs[j + 1]; //to co je vpravo se objeví na dalším řádku vlevo
                myRandNumbs[j + 1] = myRandNumbs[j];
                myRandNumbs[j] = tmp;
                compare++;
            }
            change++;
        }


    }
    myStopwatch.Stop();


    Console.WriteLine("");
    Console.WriteLine("=====================================");
    Console.WriteLine("Seřazená pole: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}, ", myRandNumbs[i]);
    }
    Console.WriteLine("");
    Console.WriteLine("\nPočet porovnávání: {0}", compare);
    Console.WriteLine("Počet výměn: {0}", change);

    Console.WriteLine("");
    Console.WriteLine("Čas seřazení pomocí bubble sort: {0}", myStopwatch.Elapsed);
    Console.WriteLine("");
        
   

    // Console.WriteLine("");
    // Console.WriteLine("");
    // Console.WriteLine("");
    // Console.WriteLine("");
    // Console.WriteLine("");


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}