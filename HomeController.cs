using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTCData;

namespace PTC.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      TrainingProductViewModel vm = new TrainingProductViewModel();

      vm.HandleRequest();

      return View(vm);
    }

    [HttpPost]
    public ActionResult Index(TrainingProductViewModel vm)
    {
      vm.IsValid = ModelState.IsValid;
      vm.HandleRequest();

      if (vm.IsValid) {
      
        ModelState.Clear();
      }
      else {
        foreach (KeyValuePair<string, string> item in vm.ValidationErrors) {
          ModelState.AddModelError(item.Key, item.Value);
        }
      }

      return View(vm);
    }

    public ActionResult About()
    {
      return View();
    }
  }
}