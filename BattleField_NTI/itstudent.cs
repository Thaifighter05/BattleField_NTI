
public class ItElev : Elev
{
  public ItElev()
  {
     // Sätter ett slumpmässigt värde mellan 4 och 7 (inklusive 4 men exklusive 8)
    Nätverk=Random.Shared.Next(4, 8);
     // Sätter ett slumpmässigt värde mellan 0 och 3 (inklusive 0 men exklusive 4)
    Fotografi=Random.Shared.Next(0, 4);
     // Sätter ett slumpmässigt värde mellan 3 och 7 (inklusive 0 men exklusive 3)
    Teknik=Random.Shared.Next(3, 8);
  }
}