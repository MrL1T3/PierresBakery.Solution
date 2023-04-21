using PierresBakery.Models;
using System;
namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("We sell Bread by the loaf, how many would you like? Please answer with a number and not letters.");
      string BreadInput = Console.ReadLine();
      int i = 0;
      if (int.TryParse(BreadInput, out i) == true) {
        int BreadNumber = Int32.Parse(BreadInput);
        OrderBread NewBread = new OrderBread(BreadNumber);
        NewBread.LoafCost(BreadNumber);
        int BreadCost = NewBread.OrderCost;
        Console.WriteLine("Your Order will cost " + BreadCost + " dollars.");
      }
      else 
      {
        Console.WriteLine("Sorry, our system can't process written answers, try again with a number value please.");
      }
    }
  }
}
