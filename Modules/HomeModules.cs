using Nancy;
using System.Collections.Generic;
using LeetSpeakList.Objects;
namespace LeetSpeakList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/result"] = _ => {
        LeetSpeak newLeet = new LeetSpeak(Request.Query["stringWords"]);
        return View["result.cshtml", newLeet];
      };
    }
  }
}
