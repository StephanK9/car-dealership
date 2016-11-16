using Nancy;
using Cars.Objects;
using System.Collections.Generic;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["add_new_car.cshtml"];
      };
      Post["/car_added"] = _ => {
        string inputMake = Request.Form["new-make-model"];
        int inputPrice = int.Parse(Request.Form["new-price"]);
        int inputMiles = int.Parse(Request.Form["new-miles"]);

        Car inputCar = new Car(inputMake, inputPrice, inputMiles);
        inputCar.AddToInventory();

        return View["car_added.cshtml", inputCar];
      };
      Get["/inventory"] = _ => {
        return View["inventory.cshtml", Car.ViewInventory()];
      };
      Post["/cleared_list"] = _ => {
        Car.ClearInventory();
        return View["inventory.cshtml"];
      };
    }
  }
}
