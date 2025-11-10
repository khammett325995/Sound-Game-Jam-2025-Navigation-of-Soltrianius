using System.Net;
using System.Reflection.Metadata;

namespace NavigationOfSoltrianius.GameCode
{

    public static class GameErrorCodes
    {
        //Game Errors that Players can cause
        /// <summary>
        /// This error is for if the gameplay data can't be found.
        /// </summary>
        public static Error GameNotFound = new(HttpStatusCode.NotFound,
        "Gameplay.NotFound",
        "Your gameplay of Navigation of Soltrianius has not been found by a specified identifer.");

        /// <summary>
        /// This error is for if you don't have enough or have too many players.
        /// </summary>
        public static Error InvalidPlayerTotal = new(HttpStatusCode.BadRequest,
        Gameplay.InvalidPlayerTotal,
        "You don't have the amount of players needed to play Navigation of Soltrianius.");

        /// <summary>
        /// This error is for if an invalid resource type.
        /// </summary>
        public static Error InvalidResourceType = new(HttpStatusCode.BadRequest,
        Gameplay.InvalidResourceType,
        "This resource is an invalid type of resource.");

        /// <summary>
        /// This error is for if you don't have enough resources to perform an action.
        /// </summary>
        public static Error NotEnoughResources = new(HttpStatusCode.BadRequest,
        Gameplay.NotEnoughResources,
        "You don't have enough resources to perform the action.");

        //Player Errors that Players can cause

        /// <summary>
        /// This error is in regards to the color selection for a player.
        /// </summary>
        public static Error InvalidPlayerColor = new(HttpStatusCode.BadRequest,
        InvalidPlayerColor.InvalidPlayerColor,
        "The color isn't able to be a player color.");

        //Board Errors that Players can cause

        //State Management Errors that Players can cause

        //Inventory Management Errors that Players can cause
    }
}