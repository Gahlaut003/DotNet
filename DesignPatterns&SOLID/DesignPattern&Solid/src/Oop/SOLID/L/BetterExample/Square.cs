namespace ConsoleApp1.SOLID.L.BetterExample
{
  public class Square : Rectangle
  {
    public double SideLength
    {
      get => Width;
      set
      {
        Width = value;
        Height = value;
      }
    }
  }
}