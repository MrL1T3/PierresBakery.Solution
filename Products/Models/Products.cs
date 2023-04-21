namespace PierresBakery.Models
{
  public class OrderBread
  {
    public int FoodNumber {get; set;}
    public int IndivCost = 5;
    public int OrderCost = 0;
    public int FreeNumber = 3;
    public OrderBread (int FoodNumber)
    {}
    public void LoafCost(int FoodNumber)
    {
      if ((FoodNumber) % FreeNumber == 0)
      {
        int FoodNumTrue = (FoodNumber-(FoodNumber/FreeNumber));
        OrderCost = FoodNumTrue * IndivCost;
      }
      else if (((FoodNumber) % FreeNumber != 0)&&(FoodNumber > FreeNumber))
      {
        int FoodExtra = 0;
        while (FoodExtra % FreeNumber != 0)
        {
          FoodExtra++;
          FoodNumber--;
        }
        int FoodNumTrue = (FoodNumber-(FoodNumber/FreeNumber));
        OrderCost = (FoodNumTrue + FoodExtra) * IndivCost;
      }
      else 
      {
        OrderCost = FoodNumber * IndivCost;
      }
    }
  }
  public class OrderPastry
  {
    public int FoodNumber {get; set;}
    public int EachCost = 2;
    public int OrderCost = 0;
    public int FreeNumber = 4;
    public OrderPastry (int FoodNumber)
    {}
    public void TartCost(int FoodNumber)
    {
      if ((FoodNumber) % FreeNumber == 0)
      {
        int FoodNumTrue = (FoodNumber-(FoodNumber/FreeNumber));
        OrderCost = FoodNumTrue * EachCost;
      }
      else if (((FoodNumber) % FreeNumber != 0)&&(FoodNumber > FreeNumber))
      {
        int FoodExtra = 0;
        while (FoodExtra % FreeNumber != 0)
        {
          FoodExtra++;
          FoodNumber--;
        }
        int FoodNumTrue = (FoodNumber-(FoodNumber/FreeNumber));
        OrderCost = (FoodNumTrue + FoodExtra) * EachCost;
      }
      else 
      {
        OrderCost = FoodNumber * EachCost;
      }
    }
  }
}