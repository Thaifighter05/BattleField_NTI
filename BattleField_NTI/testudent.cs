// Definition av klassen TeElev som ärver från klassen Elev
public class TeElev : Elev
{
    // Konstruktorn för TeElev-klassen
    public TeElev()
    {
        //Sätter ett slumpmässigt värde mellan 0 och 1 (inklusive 0 men exklusive 2)
        Fotografi = Random.Shared.Next(0, 2);
        
        // Sätter ett slumpmässigt värde mellan 2 och 6 (inklusive 2 men exklusive 7)
        Nätverk = Random.Shared.Next(2, 7);
        
        // Sätter ett slumpmässigt värde mellan 1 och 9 (inklusive 1 men exklusive 10)
        Teknik = Random.Shared.Next(1, 10);
    }
}
