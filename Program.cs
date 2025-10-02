using System;
using System.Text.RegularExpressions;

namespace Models
{

  internal class Program
  {

    public class Computer
    {
      private string? Motherboard { get; set; }
      private int CPUCores { get; set; }
      private bool HasWiFi { get; set; }
      private bool HasLTE { get; set; }
      private decimal Price { get; set; }
      private string? VideoCard { get; set; }
    }
    static void main(string[] args)
    {

    }
  }
}
