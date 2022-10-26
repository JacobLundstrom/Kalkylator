// Välkomnande meddelande
// En lista för att spara historik för räkningar
// Användaren matar in tal och matematiska operation
//OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
// Ifall användaren skulle dela 0 med 0 visa Ogiltig inmatning!
// Lägga resultat till listan
//Visa resultat
//Fråga användaren om den vill visa tidigare resultat.
//Visa tidigare resultat
//Fråga användaren om den vill avsluta eller fortsätta.




double num1 = 0;
double num2 = 0;
double resultat = 0;
List<double> historik = new List<double>();


while (true)
{
    Console.WriteLine("Skriv in ditt första nummer");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Skriv in ditt andra nummer");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Välj ett av dessa räknesätt");
    Console.WriteLine("\t+");
    Console.WriteLine("\t-");
    Console.WriteLine("\t*");
    Console.WriteLine("\t/");
    Console.Write(" ");
    switch (Console.ReadLine())
    {

        case "+":
            resultat = num1 + num2;
            Console.WriteLine($"Ditt resultat: {num1} + {num2} = " + resultat);
            break;
        case "-":
            resultat = num1 - num2;
            Console.WriteLine($"Ditt resultat: {num1} + {num2} = " + resultat);
            break;
        case "*":
            resultat = num1 * num2;
            Console.WriteLine($"Ditt resultat: {num1} + {num2} = " + resultat);
            break;
        case "/":
            if (num2 == 0)
            {
                Console.WriteLine("Ogiltig inmatning, du kan inte dela med 0");
                break;
            }
            resultat = num1 / num2;
            Console.WriteLine($"Ditt resultat: {num1} + {num2} = " + resultat);
            break;
    }

    historik.Add(resultat);

    Console.WriteLine("Vill du se dina tidigare uträckningar? Tryck J=JA eller N=NEJ");
    char calc = Console.ReadLine()[0];
    if (calc == 'J' ||
        calc == 'j')
    {
        Console.WriteLine("Här är dina uträckningar: " );
        foreach (double a in historik) { Console.WriteLine(a); }
    }

    else if (calc == 'N' ||
          calc == 'n')
    {
        Console.WriteLine("");
    }

    Console.WriteLine("Vill du fortsätta räkna? Tryck J=JA eller N=NEJ");
    char cont = Console.ReadLine()[0];
    if (cont == 'J' ||
        cont == 'j')
    {

    }

    else if (cont == 'n' ||
        cont == 'N')
            {
                break;
            }

}
    



