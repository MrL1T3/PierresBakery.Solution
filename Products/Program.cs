using PierresBakery.Models;
using System;
namespace PierresBakery
{
  public class Program
{
  public static void Main()
  {
    Console.WriteLine("We sell Bread by the loaf, how many would you like?");
    int BreadNumber = Int32.Parse(Console.ReadLine());
    OrderBread NewBread = new OrderBread(BreadNumber);
    NewBread.LoafCost(BreadNumber);
    int BreadCost = NewBread.OrderCost;
    Console.WriteLine("Your Order will cost " + BreadCost + " dollars.");
  }
}
}
