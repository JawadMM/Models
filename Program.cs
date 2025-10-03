using System;
using System.Text.RegularExpressions;

namespace Models
{
  public class Computer
  {
    public string Motherboard { get; set; }
    public int CPUCores { get; set; }
    public bool HasWiFi { get; set; }
    public bool HasLTE { get; set; }
    public DateTime ReleaseDate { get; set; }
    public decimal Price { get; set; }
    public string VideoCard { get; set; }

    public Computer()
    {
      if (Motherboard == null)
      {
        Motherboard = "";
      }
      if (VideoCard == null)
      {
        VideoCard = "";
      }
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Computer newComputer = new Computer()
      {
        Motherboard = "ASUS",
        HasWiFi = true,
        HasLTE = false,
        ReleaseDate = DateTime.Now,
        Price = 944.44m,
        VideoCard = "RTX",
      };

      Console.WriteLine(newComputer.Motherboard);
      Console.WriteLine(newComputer.HasWiFi);
      newComputer.HasWiFi = false;
      Console.WriteLine(newComputer.HasWiFi);
      Console.WriteLine(newComputer.Price);
      Console.WriteLine(newComputer.ReleaseDate);
      Console.WriteLine(newComputer.VideoCard);
    }
  }
}
