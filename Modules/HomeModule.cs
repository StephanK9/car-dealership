using Nancy;
using ToDoList.Objects;
using System.Collections.Generic;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_car.cshtml"];
      Get["/view_all_cars"] = _ => {
        List<string> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };
      Post["/car_added"] = _ => {
        Car newCar = new Car (Request.Form["new-car"]);
        newCar.Save();
        return View["car_added.cshtml", newCar];
      };
      Post["/tasks_cleared"] = _ => {
        Task.ClearAll();
        return View["tasks_cleared.cshtml"];
      };
    }
  }
}
