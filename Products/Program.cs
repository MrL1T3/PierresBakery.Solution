using PierresBakery.Models;
using System;
namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! We sell Bread by the loaf and individual pastries");
      Console.WriteLine("How many loaves of bread would you like? Please answer with a number and not letters.");
      string BreadInput = Console.ReadLine();
      Console.WriteLine("And how many pastries would yo like?");
      string PastryInput = Console.ReadLine();
      int i = 0;
      if (int.TryParse(BreadInput, out i) == true && int.TryParse(PastryInput, out i) == true) {
        int BreadNumber = Int32.Parse(BreadInput);
        int PastryNumber = Int32.Parse(PastryInput);
        OrderBread NewBread = new OrderBread(BreadNumber);
        OrderPastry NewPastry = new OrderPastry(PastryNumber);
        NewBread.LoafCost(BreadNumber);
        NewPastry.TartCost(PastryNumber);
        int BreadCost = NewPastry.OrderCost;
        int PastryCost = NewBread.OrderCost;
        Console.WriteLine("Your Order will cost " + (BreadCost + PastryCost) + " dollars.");
      }
      else 
      {
        Console.WriteLine("Sorry, our system can't process written answers, try again with a number value please.");
      }
    }
  }
}
