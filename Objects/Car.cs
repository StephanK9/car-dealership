using System.Collections.Generic;

namespace Cars.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private static List<string> _inventory = new List<Car>{};

    public Car(string MakeModel, int Price, int Miles)
    {
      _makeModel = MakeModel;
      _price = Price;
      _miles = Miles;
    }

    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = MakeModel;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }
    public int GetMiles()
    {
      return _miles;
    }
    public void AddToInventory()
    {
      _inventory.Add(this);
    }
    public static List<Car> ViewInventory()
    {
      return _inventory;
    }
    public static void ClearInventory()
    {
      _inventory.Clear();
    }
  }
}
