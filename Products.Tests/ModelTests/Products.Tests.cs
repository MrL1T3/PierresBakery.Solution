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
      Assert.AreEqual(5, New.OrderCost);
    }
    [TestMethod]
    public void IsBreadCost_Ten_True()
    {
      OrderBread New = new OrderBread(3);
      New.LoafCost(3);
      Assert.AreEqual(10, New.OrderCost);
    }
    [TestMethod]
    public void IsBreadCost_Twenty_True()
    {
      OrderBread New = new OrderBread(6);
      New.LoafCost(6);
      Assert.AreEqual(20, New.OrderCost);
    }
  }
}