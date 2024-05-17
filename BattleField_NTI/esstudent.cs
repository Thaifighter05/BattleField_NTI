
public class EsElev: Elev
{
  public EsElev()
  {
     // Sätter ett slumpmässigt värde mellan 1 och 5 (inklusive 1 men exklusive 6)
    Nätverk = Random.Shared.Next(1, 6);
     // Sätter ett slumpmässigt värde mellan 6 och 9 (inklusive 6 men exklusive 10)
    Fotografi = Random.Shared.Next(6, 10);
    // Sätter ett slumpmässigt värde mellan 1 och 2 (inklusive 1 men exklusive 3)
    Teknik= Random.Shared.Next(1, 3);
  }
}
