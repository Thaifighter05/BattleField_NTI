using System;

public class Elev
{
    // Egenskap för elevens namn
    public string Namn { get; set; }
    
    // Egenskap för elevens nivå inom fotografi
    public int Fotografi { get; set; }
    
    // Egenskap för elevens nivå inom teknik
    public int Teknik { get; set; }
    
    // Egenskap för elevens nivå inom nätverk
    public int Nätverk { get; set; }

    // Statisk instans av Random-klassen för att generera slumpmässiga betyg
    private static readonly Random random = new Random();

    // Metod för att generera ett slumpmässigt betyg baserat på elevens nivå inom ett visst område
   public string GetGrade(int kunskap)
{
    // Generera ett slumpmässigt betyg från 0 till betygsnivån
    int slumpmässigBetygsnivå = random.Next(kunskap + 1);
    
    // Returnera betyg baserat på den slumpmässiga betygsnivån
    if (slumpmässigBetygsnivå == 0)
    {
        return "F";
    }
    else if (slumpmässigBetygsnivå == 1)
    {
        return "E";
    }
    else if (slumpmässigBetygsnivå == 2)
    {
        return "C";
    }
    else
    {
        return "A";
    }
}


    // Generera ett slumpmässigt betyg inom fotografi
    public string GetFotoBetyg()
    {
        return GetGrade(Fotografi);
    }

    // Generera ett slumpmässigt betyg inom teknik
    public string GetTeknikBetyg()
    {
        return GetGrade(Teknik);
    }

    // Generera ett slumpmässigt betyg inom nätverk
    public string GetNätverksBetyg()
    {
        return GetGrade(Nätverk);
    }
}
