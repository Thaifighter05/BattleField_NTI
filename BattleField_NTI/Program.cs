using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Elev> elever = new List<Elev>();

        // Hämta antal elever
        int antalElever = HämtaPositivtInt("Hur många elever?");

        // Hämta typ av elev
        string elevTyp = HämtaElevTyp();

        // Bestämmer vilken klass som ska skapas baserat på elevtypen
       Type elevKlass;

if (elevTyp == "te")
{
    elevKlass = typeof(TeElev);
}
else if (elevTyp == "es")
{
    elevKlass = typeof(EsElev);
}
else if (elevTyp == "it")
{
    elevKlass = typeof(ItElev);
}
else
{
    elevKlass = null;
}


        if (elevKlass != null)
        {
            // Skapar och lägger till elever i listan
            for (int i = 0; i < antalElever; i++)
            {
                // Hämtar elevens namn
                Console.WriteLine($"Vilket namn ska elev {i + 1} ha?");
                string elevNamn = Console.ReadLine();
                
                // Skapar en instans av elevklassen och lägger till den i listan
                Elev elev = (Elev)Activator.CreateInstance(elevKlass);
                elev.Namn = elevNamn;
                elever.Add(elev);
            }
        }
        else
        {
            Console.WriteLine("Du valde inget elevtyp!");
        }

        Console.WriteLine($"Skapade {elever.Count} elev/elever av {elevTyp}.");
        Console.ReadLine();
    }

    // Hämtar ett positivt heltal från användaren
    private static int HämtaPositivtInt(string prompt)
    {
        int resultat;
        do
        {
            Console.WriteLine(prompt);
        } while (!int.TryParse(Console.ReadLine(), out resultat) || resultat <= 0);
        return resultat;
    }

    // Hämtar elevtyp från användaren
    private static string HämtaElevTyp()
    {
        string typ;
        {
            Console.WriteLine("Vilken typ av elev? te/es/it");
            typ = Console.ReadLine().ToLower();
        } while (typ != "te" && typ != "es" && typ != "it");
        return typ;
    }
}
