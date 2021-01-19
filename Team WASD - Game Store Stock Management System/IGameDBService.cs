using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Team_WASD___Game_Store_Stock_Management_System
{
    /*
     * Author: Wei Bin Wang
     */
    /// <summary>
    /// This interface implement all the database services.
    /// Contains all the operations for the database.
    /// </summary>
    [ServiceContract]
    public interface IGameDBService
    {
        /// <summary>
        /// Get all the games in the database.
        /// </summary>
        /// <returns>A list of Game objects.</returns>
        [OperationContract]
        List<Game> GetAllGames();

        /// <summary>
        /// Get a specific game by id.
        /// </summary>
        /// <param name="id">Id associated with this game.</param>
        /// <returns>The searched Game object.</returns>
        [OperationContract]
        Game FindAGame(int id);

        /// <summary>
        /// Add a new game.
        /// </summary>
        /// <param name="game">A Game object.</param>
        [OperationContract]
        void AddGame(Game game);

        /// <summary>
        /// Edit a currently selected game.
        /// </summary>
        /// <param name="game">A Game object.</param>
        [OperationContract]
        void EditGame(Game game);

        /// <summary>
        /// Delete a slected game.
        /// </summary>
        /// <param name="game">A Game object.</param>
        [OperationContract]
        void DeleteGame(Game game);

        /// <summary>
        /// Get a list of games that has specified their platform.
        /// </summary>
        /// <param name="platformName">String type of the platform name.</param>
        /// <returns>A list of Game objects.</returns>
        [OperationContract]
        List<Game> GetAllPlatformGames(string platformName);

        /// <summary>
        /// Search a game by title.
        /// </summary>
        /// <param name="gameTitle">String type of the game title.</param>
        /// <returns>A Game object.</returns>
        [OperationContract]
        Game FindAGameByGameTitle(string gameTitle);
    }
}
