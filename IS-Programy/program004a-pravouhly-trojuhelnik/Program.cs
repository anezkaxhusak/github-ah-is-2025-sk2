string again = "a";
while (again == "a")

{
    Console.Clear();
    Console.WriteLine("*********************************************");
    Console.WriteLine("********** Pravoúhlý trojúhelník ************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("************* Anežka Husáková ***************");
    Console.WriteLine("**************** 6.11. 2025 *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte délku odvěsny A: ");
    int odvesnaA;
    while (!int.TryParse(Console.ReadLine(), out odvesnaA))
    {
        Console.Write("Zadejte délku odvěsny B: ");
    }
    Console.Write("Zadejte výšku obdélníku: ");
    int odvesnaB;
    while (!int.TryParse(Console.ReadLine(), out odvesnaB))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obdélníku znovu: ");
    }
    double prepona = Math.Sqrt(Math.Pow(odvesnaA, 2) + Math.Pow(odvesnaB, 2));
    {
        Console.Write($"Přepona má délku {prepona} \n");
    }

    for (int i = 1; i <= odvesnaA; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}