using Nancy;
using ParcelProject.Objects;

namespace ParcelProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      // Get["/"] = _ => {
      //   ParcelVariables myParcelVariables = new ParcelVariables();
      //   myParcelVariables.SetRecipient("Eric");
      //   myParcelVariables.SetSender("John");
      //   return View["hello.cshtml", myParcelVariables];
      //
      // };

      Get["/"] = _ => {
        return View["form.cshtml"];
      };

      Get["/costToShipPage"] = _ => {
        //get length width weight and put into variables
      double length = (Request.Query["length"]);
      double width =  (Request.Query["width"]);
      double weight = (Request.Query["weight"]);



        //pass variables into constructor

        Parcel parcel = new Parcel(length, width, weight);
        System.Console.WriteLine(parcel.Volume());

        return View["costToShipPage.cshtml", parcel];
      };

    }
  }
}
