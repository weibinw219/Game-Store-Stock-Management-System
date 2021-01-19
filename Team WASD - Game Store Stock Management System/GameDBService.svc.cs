using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;

namespace Team_WASD___Game_Store_Stock_Management_System
{
    /*
    * Author: Wei Bin Wang
    */
    /// <summary>
    /// This class is the database class that implement methods for the interface.
    /// </summary>
    public class GameDBService : IGameDBService
    {
        /// <summary>
        /// All the database operations methods are implmented here.
        /// </summary>

        // Declare a DBEntities variable of context for quick access.
        GameStoreDBEntities context = new GameStoreDBEntities();

        /// <summary>
        /// Adds a new game to the database.
        /// </summary>
        /// <param name="game">A Game object.</param>
        public void AddGame(Game game)
        {
            // Add a new game object to the context that saiving all the games in database.
            context.Games.Add(game);
            context.SaveChanges();
        }

        /// <summary>
        /// Delete a slected game by using id finder.
        /// </summary>
        /// <param name="game">A Game object that is slected.</param>
        public void DeleteGame(Game game)
        {
            // Remove a game that is selected that associated by that id in database.
            context.Games.Remove(context.Games.Find(game.Id));
            context.SaveChanges();
        }

        /// <summary>
        /// Edit a slected game
        /// </summary>
        /// <param name="game">A Game object that is slected</param>
        public void EditGame(Game game)
        {
            // Edit a game info by changing the state to be modified.
            context.Entry(game).State = EntityState.Modified;
            context.SaveChanges();
        }

        /// <summary>
        /// Find a game by using id
        /// </summary>
        /// <param name="id">Id number associated with the game</param>
        /// <returns>The result Game object</returns>
        public Game FindAGame(int id)
        {
            // Return a single game by its associated id
            return context.Games.SingleOrDefault(g => g.Id == id);

        }

        /// <summary>
        /// Get a list of currently stored games
        /// </summary>
        /// <returns>A list of Game objects</returns>
        public List<Game> GetAllGames()
        {
            // return a list of games that are currently in the database
            return context.Games.ToList();
        }

        /// <summary>
        /// Get a list of specific platform games
        /// </summary>
        /// <param name="platformName"></param>
        /// <returns>A list of Game objects</returns>
        public List<Game> GetAllPlatformGames(string platformName)
        {
            // return a list of games that takes in an arugment of specific platform
            List<Game> games = context.Games.Where(g => g.Platform == platformName).ToList();
            return games;
        }

        /// <summary>
        /// Find a specific game by searching the game title.
        /// </summary>
        /// <param name="gameTitle">A string type of game title.</param>
        /// <returns>The searched game object</returns>
        public Game FindAGameByGameTitle(string gameTitle)
        {
            // Return the game that matched the game title in database
            return context.Games.SingleOrDefault(g => g.GameTitle == gameTitle);
        }
    }
}
