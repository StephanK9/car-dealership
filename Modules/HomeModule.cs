using Nancy;
using Cars.Objects;
using System.Collections.Generic;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/add_new_car.cshtml"] = _ => {
        return View["add_new_car.cshtml"];
      };
      Get["/car_added.cshtml"] = _ => {
        string inputMake = Request.Form["new-make-model"];
        int inputPrice = int.Parse(Request.Form["new-price"]);
        int inputMiles = int.Parse(Request.Form["new-miles"]);

        Car inputCar = new Car(inputMake, inputPrice, inputMiles);
        inputCar.AddToList();

        return View["car_added.cshtml", inputCar];
      };
      Get["/inventory"] = _ => {
        return View["inventory.cshtml", Car.ViewList()];
      };
      Post["/clear_list"] = _ => {
        Car.ClearList();
        return View["/cleared.list.cshtml"];
      };
    }
  }
}
