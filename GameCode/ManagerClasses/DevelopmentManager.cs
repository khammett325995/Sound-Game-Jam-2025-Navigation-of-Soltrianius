//Import statements
using System.Runtime.CompilerServices;
using System.Xml.XPath;
using NavigationOfSoltrianius.GameCode.BoardEnums;
using NavigationOfSoltrianius.GameCode.ErrorChecks;

namespace NavigationOfSoltrianius.GameCode.ManagerClasses;

/// <summary>
/// DevelopmentManager is a class that builds all the data needed for developments like Asteroid Belts and Space Colonies.
/// </summary>
public class DevelopmentManager
{
    //Private fields
    private List<SpaceColony> mySpaceColonies = new List<SpaceColony>(); //Can be done in the same way as Java
    private List<AsteroidBelts> myAsteroidBelts = new List<AsteroidBelts>();

    /// <summary>
    /// Constructor method with SpaceColony and AsteroidBelt parameters for BuildingManager
    /// </summary>
    public DevelopmentManager()
    {

    }

    /// <summary>
    /// Constructor method with zero parameters for BuildingManager
    public DevelopmentManager(List<SpaceColony> theSpaceColonies, List<AsteroidBelts> theAsteroidBelts)
    {
        this.mySpaceColonies = theSpaceColonies;
        this.myAsteroidBelts = theAsteroidBelts;
    }

    /// <summary>
    /// A getter method to get the space colonies that a player has developed.
    /// </summary>
    /// <returns>
    /// The return is of the Space Colonies that a player has developed.
    /// </returns>
    public List<SpaceColony> getSpaceColonies()
    {
        return mySpaceColonies;
    }

    /// <summary>
    /// A getter method to get the asteroid belts that a player has developed.
    /// </summary>
    /// <returns>
    /// The return is of the Asteroid Belts that a player has developed,
    /// </returns>
    public List<AsteroidBelts> getAsteroidBelts()
    {
        return myAsteroidBelts;
    }

    public Result CanYouAddAsteroidBelt (AsteroidBelt theAsteroidBelt)
    {
        var existingAsteroidBelt = getAsteroidBelts(theAsteroidBelt.FirstPoint, theAsteroidBelt.SecondPoint);
        if (theAsteroidBelt.Color == PlayerColor.None)
        {
            return Result.Failure(GameErrorCodes.InvalidPlayerColor);
        }
        if (existingAsteroidBelt == null)
        {
            return Result.Failure(GameErrorCodes.InvalidRoadPoints);
        }
        if (existingAsteroidBelt == PlayerColor.None)
        {
            Result.Success();
        } else
        {
            Result.Failure(GameErrorCodes.RoadAlreadyExists);
        }
    }

    public void AddAsteroidBelt(AsteroidBelt theAsteroidBelt)
    {
        var existingAsteroidBelt = getAsteroidBelts(theAsteroidBelt.FirstPoint, theAsteroidBelt.SecondPoint);
        if (existingAsteroidBelt = null)
        {
            throw new InvalidOperationException("The asteroid belt not found.");
        }
        existingAsteroidBelt.SetColor(theAsteroidBelt.Color);
    }
}