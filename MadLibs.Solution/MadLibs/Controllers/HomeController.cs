using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")] //home page or root path
    public ActionResult Form()
    { 
      return View();
    }

    [HttpPost("/madlib")]
    public ActionResult MadLib(string noun1, string name1, string place1, string place2, string noun2, string adjective1, string ominousNoun1, string noun3, string faceAdjective1, string faceNoun1, string food1, string characterAdjective1, string adjective2)
    {
      WordChoices myWordChoices = new WordChoices();
      myWordChoices.Noun1 = noun1;
      myWordChoices.Name1 = name1;
      myWordChoices.Place1 = place1;
      myWordChoices.Place2 = place2;
      myWordChoices.Noun2 = noun2;
      myWordChoices.Adjective1 = adjective1;
      myWordChoices.OminousNoun1 = ominousNoun1;
      myWordChoices.Noun3 = noun3;
      myWordChoices.FaceAdjective1 = faceAdjective1;
      myWordChoices.FaceNoun1 = faceNoun1;
      myWordChoices.Food1 = food1;
      myWordChoices.CharacterAdjective1 = characterAdjective1;
      myWordChoices.Adjective2 = adjective2;

      return View(myWordChoices);
    }
  }
}