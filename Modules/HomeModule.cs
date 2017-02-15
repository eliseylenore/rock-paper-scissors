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
                var playerOne = Request.Form["playerOneInput"];
                var playerTwo = Request.Form["playerTwoInput"];
                string result = newGame.Play(playerOne, playerTwo);
                Dictionary<string, string> model = new Dictionary<string, string>();
                model.Add("winner", result);
                model.Add("playerOne", playerOne);
                model.Add("playerTwo", playerTwo);
                return View["index.cshtml", model];
            };
        }
    }
}
