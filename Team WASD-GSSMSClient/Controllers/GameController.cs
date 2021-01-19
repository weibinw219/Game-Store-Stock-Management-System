using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team_WASD_GSSMSClient.GameDBServiceReference;

namespace Team_WASD_GSSMSClient.Controllers
{
    /*
     * Author: Anran Qin
     */
    /// <summary>
    /// A controller class for all the pages related to games operations.
    /// </summary>
    public class GameController : Controller
    {
        /// <summary>
        /// A ServiceClient type of the object that will use the services from the WCF and implement the methods to hanlde game pages.
        /// </summary>
        GameDBServiceClient client = new GameDBServiceClient();
        
        /// <summary>
        /// Author: Wei Bin Wang, for checking if the games are correctly displayed.
        /// Page for getting all the games to a list.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            // Use GetAllGames to return a list of all games
            return View(client.GetAllGames().ToList());
        }

        /// <summary>
        /// Page for getting all PS5 games.
        /// </summary>
        /// <returns>A list of games that are on PS5.</returns>
        public ActionResult PS5Games()
        {
            return View(client.GetAllPlatformGames("PS5"));
        }

        /// <summary>
        /// Page for getting all Xbox Series games.
        /// </summary>
        /// <returns>A list of games that are on Xbox Series.</returns>
        public ActionResult XboxSeriesGames()
        {
            return View(client.GetAllPlatformGames("Xbox Series"));
        }

        /// <summary>
        /// Page for getting all PS4 games.
        /// </summary>
        /// <returns>A list of games that are on PS4.</returns>
        public ActionResult PS4Games()
        {
            return View(client.GetAllPlatformGames("PS4"));
        }

        /// <summary>
        /// Page for getting all XBox One games.
        /// </summary>
        /// <returns>A list of games that are on XBox One.</returns>
        public ActionResult XBoxOneGames()
        {
            return View(client.GetAllPlatformGames("XBox One"));
        }

        /// <summary>
        /// Page for getting all Nintendo Switch games.
        /// </summary>
        /// <returns>A list of games that are on Nintendo Switch.</returns>
        public ActionResult NintendoSwitchGames()
        {
            return View(client.GetAllPlatformGames("Nintendo Switch"));
        }

        /// <summary>
        /// Page for getting all PC games.
        /// </summary>
        /// <returns>A list of games that are on PC.</returns>
        public ActionResult PCGames()
        {
            return View(client.GetAllPlatformGames("PC"));
        }

        /// <summary>
        /// Detail page for a single game.
        /// </summary>
        /// <param name="id">Id associated with this game.</param>
        /// <returns>A page for this game's detail.</returns>
        public ActionResult Details(int id)
        {
            return View(client.FindAGame(id));
        }

        /// <summary>
        /// Search a single game by using game's title.
        /// </summary>
        /// <returns>A page to search the game title.</returns>
        public ActionResult SearchGameByTitleEntry()
        {
            // Show the search page
            return View();
        }

        /// <summary>
        /// Post method of seaching a single game using game's title.
        /// </summary>
        /// <param name="gameTitle">A string type of game title.</param>
        /// <returns>A page showing the result of the searched game.</returns>
        [HttpPost]
        public ActionResult SearchGameByTitle(string gameTitle)
        {
            Game game = client.FindAGameByGameTitle(gameTitle);
            if (game == null)
            {
                return RedirectToAction("SearchGameByTitleEntry");
            }
            return View(game);
        }



        /// <summary>
        /// A page to insert a new game.
        /// </summary>
        /// <returns>A page showing the create page.</returns>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Post method of adding a new game.
        /// </summary>
        /// <param name="game">A game object to be inserted.</param>
        /// <returns>Result page that redirect to the main game page.</returns>
        [HttpPost]
        public ActionResult Create(Game game)
        {
            try
            {
                // Use AddGame to insert a new game to the database.
                client.AddGame(game);
                // Redirect to the main page after insertion.
                return RedirectToAction("Index");
            }
            catch
            {
                // Return to current page if there is any error.
                return View();
            }
        }

        /// <summary>
        /// Edit page for a single game.
        /// </summary>
        /// <param name="id">Id associated with this game.</param>
        /// <returns>The page showing the game being edited.</returns>
        public ActionResult Edit(int id)
        {
            // Game that is being selected by macthing the id.
            var game1 = client.FindAGame(id);
            // A new game object that is waiting to be assigned to the newly edited game.
            Game game = null;

            // Try to match the id
            if (game1.Id == id)
            {
                game = game1;
            }

            // If error orrcured when there is not game matching
            if (game == null)
            {
                return HttpNotFound();
            }

            // retuen the information of this game.
            return View(game);
        }

        /// <summary>
        /// Post method to when a game is finishing editing.
        /// </summary>
        /// <param name="game">A game object that is being edited.</param>
        /// <returns>Back to main game page</returns>
        [HttpPost]
        public ActionResult Edit(Game game)
        {

            try
            {
                client.EditGame(game);
                // Redirect to the main game page when finishing editing.
                return RedirectToAction("Index");
            }
            catch
            {
                // Return to current page if there is any error.
                return View();
            }
        }

        /// <summary>
        /// A page to delete selected game.
        /// </summary>
        /// <param name="id">Id associated with </param>
        /// <returns>Return the page showing the game waiting to be deleted.</returns>
        public ActionResult Delete(int id)
        {
            // Find the game associated with the id.
            Game game = client.FindAGame(id);
            return View(game);
        }

        /// <summary>
        /// Post method to delete a pecific game.
        /// </summary>
        /// <param name="game">A game object that is being deleted.</param>
        /// <returns>Return back to the main page after successfully deleted a game.</returns>
        [HttpPost]
        public ActionResult Delete(Game game)
        {
            try
            {
                // Use deleteGame method to delete a selected game.
                client.DeleteGame(game);
                // Return to the main game page
                return RedirectToAction("Index");
            }
            catch
            {
                // Return to current page if there is any error.
                return View();
            }
        }

        

    }
}
