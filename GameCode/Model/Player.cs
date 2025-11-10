using System.Resources;
using System.Security.AccessControl;
using System.Xml.XPath;
using NavigationOfSoltrianius.GameCode.BoardEnums;
using NavigationOfSoltrianius.GameCode.ErrorChecks;
using NavigationOfSoltrianius.GameCode.ManagerClasses;

namespace NavigationOfSoltrianius.GameCode;

public class Player
{
    //Private Field
    PlayerColor myPlayerColor;
    PlayerManager myPlayerManager;
    GameResourceManager myResourceManager;
    public Player(PlayerColor thePlayerColor, PlayerManager thePlayerScore)
    {
        this.myPlayerColor = thePlayerColor;
        this.myPlayerManager = thePlayerScore;
    }

    /// <summary>
    /// This method is initally building a player as an object in the game in the setup.
    /// </summary>
    /// <param name="thePlayerColor"></param>
    public Player(PlayerColor thePlayerColor)
    {
        this.myPlayerColor = thePlayerColor;
        setupBoard();
    }

    private void setupBoard()
    {
        PieceManager.Set(DevelopmentType.AsteroidBelt, 34);
        PieceManager.Set(DevelopmentType.SpaceColony, 12);
    }

    public PlayerColor getPlayerColor()
    {
        return myPlayerColor;
    }

    public GameResourceManager getResourceManager()
    {
        return myResourceManager;
    }

    public void addResources(Dictionary<ResourcesType, int> theCards)
    {
        myResourceManager.Add(theCards);
        updateResourceTotal();
    }

    public void updateResourceTotal(ResourcesType theResourceType, int theResourcetotal)
    {
        theResourcetotal = 1;
        myResourceManager.add(theResourceType, theResourceTotal);
    }
    
    public bool HasResources(Dictionary<ResourcesType, int> theResources)
    {
        bool areThereResources = false;
        var resourcesTotal = myResourceManager.Has(theResources);
        if (resourcesTotal != null)
        {
            areThereResources = true;
        } if (resourcesTotal == null)
        {
            areThereResources = false;
        }
        return areThereResources;
    }
}