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
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0};", myRandNumbs [i]);


    }
     

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}