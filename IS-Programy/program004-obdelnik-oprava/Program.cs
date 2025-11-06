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
    Console.Write("Zadejte šířku obdélníku: ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku obdélníku znovu: ");
    }
    Console.Write("Zadejte výšku obdélníku: ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obdélníku znovu: ");
    }

    for (int i = 1; i <= height ; i++){
        for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(300));
        }
    
    Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}