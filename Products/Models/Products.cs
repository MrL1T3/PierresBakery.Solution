namespace PierresBakery.Models
{
  public class OrderBread
  {
    public string FoodNumber {get; set;}
    public int IndivCost = 5;
    public int OrderCost = 0;
    public OrderBread (int FoodNumber)
    {}
    public void LoafCost(int FoodNumber)
    {
      OrderCost = IndivCost * FoodNumber;
    }
  }
}