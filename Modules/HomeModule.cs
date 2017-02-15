using Nancy;
using System.Collections.Generic;
using GameApp.Objects;

namespace GameApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Post["/play"] = _ => {
                Game newGame = new Game();
                string result = newGame.Play(Request.Form["playerOneInput"], Request.Form["playerTwoInput"]);
                return View["index.cshtml", result];
            };
        }
    }
}
