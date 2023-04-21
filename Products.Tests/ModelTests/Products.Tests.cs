using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace Products.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void IsBreadCost_Five_True()
    {
      OrderBread New = new OrderBread(1);
      New.LoafCost(1);
      Assert.AreEqual(5, New.LoafCost);
    }
  }
}