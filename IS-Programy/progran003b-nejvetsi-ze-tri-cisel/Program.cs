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
    Console.Write("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo A: ");
    }
    Console.Write("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo B: ");
    }
    Console.Write("Zadejte celé číslo C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo C: ");
    }



    /* if (a > b)
    {
        Console.WriteLine($"Číslo A {a}  je větší než číslo B {b}");

    }
    else
    {
        Console.WriteLine($"číslo B {b} je větší než číslo A {a}");
    }
    if (b > c)
    {
        Console.WriteLine($"číslo B {b} je větší než číslo C {c}");
    }
    else
    {
        Console.WriteLine($"číslo C {c} je větší než číslo B {b}");
    }
    if (a > c)
    {
        Console.WriteLine($"číslo A {a} je větší než číslo C {c}");
    }
    else
    {
        Console.WriteLine($"číslo C {c} je větší než číslo A {a}");
    } */

 if (a > b)
    {
        if (a > c)
        {
            Console.WriteLine($"Největší číslo je číslo A {a} ");
            if (b > c)
            {
                Console.WriteLine($"Druhé největší číslo je číslo B {b} ");
                Console.WriteLine($"Nejmenší číslo je číslo C {c} ");
            }
            else
            {
                Console.WriteLine($"Druhé největší číslo je číslo C {c} ");
                Console.WriteLine($"Nejmenší číslo je číslo B {b} ");
            }
        }
        else
        {
            Console.WriteLine($"Největší číslo je číslo C {c} ");
        }
        
    }
    else
    {
        if (b > c)
        {
            Console.WriteLine($"Největší číslo je číslo B {b} ");
            if (a > c)
            {
                Console.WriteLine($"Druhé největší číslo je číslo A {a} ");
                Console.WriteLine($"Nejmenší číslo je číslo C {c} ");
            }
            else
            {
                Console.WriteLine($"Druhé největší číslo je číslo C {c} ");
                Console.WriteLine($"Nejmenší číslo je číslo A {a} ");
            }

        }else
        {
            Console.WriteLine($"Největší číslo je číslo C {c} ");
            Console.WriteLine($"Druhé největší číslo je číslo B {b} ");
            Console.WriteLine($"Nejmenší číslo je číslo A {a} ");
            
        }

    }







        Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}