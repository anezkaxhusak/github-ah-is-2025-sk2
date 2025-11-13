string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************************************");
    Console.WriteLine("****************** Maximum a minimum *********************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("******************* Anežka Husáková **********************");
    Console.WriteLine("********************* 13.11: 2025 ************************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine("**********************************************************");
    Console.WriteLine();

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
    Console.WriteLine("====================================");
    Console.WriteLine("Zadané hodnoty : ");
    Console.WriteLine($"Počet čísel : {n}, Dolní mez : {lowerBound}, Horní mez : {upperBound}");
    Console.WriteLine("====================================");
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


    // Hledání pozice maxima a pozice minima

    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0;
    int posMin = 0;

    // 7; 5; 9;
    for (int i = 1; i < n; i++) // int i = 1 <-- začínáme od druhého prvku, abychom neporovnávali první prvek s prvním prvkem -> (int i = 0)
    {
        if (myRandNumbs[i] > max) //9 > 7
        {
            max = myRandNumbs[i];
            posMax = i;
        }
        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }
    Console.WriteLine("");
    Console.WriteLine("==============================");
    Console.WriteLine($"Maximum : {max}");
    Console.WriteLine($"Pozice maxima : {posMax}");
    Console.WriteLine($"Minimum : {min}");
    Console.WriteLine($"Minimum : {posMin}");
    Console.WriteLine("==============================");
    Console.WriteLine("");



    //vykreslování přesýpacích hodin <--- :(( muset naučit 

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
