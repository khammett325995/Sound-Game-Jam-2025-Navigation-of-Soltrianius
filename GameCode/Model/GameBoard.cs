//The imports via using statements
using System.Numerics;
using NavigationOfSoltrianius.GameCode.BoardEnums;
using NavigationOfSoltrianius.GameCode.ErrorChecks;
using NavigationOfSoltrianius.GameCode.ManagerClasses;

namespace NavigationOfSoltrianius.GameCode.Model;

public class GameBoard
{
    //Private Fields of the Manager Objects
    private TriangleManager myTriangleManager;
    private DevelopmentManager myDevelopmentManager;

    public GameBoard(TriangleManager theTriangleManager, DevelopmentManager theDevelopmentManager)
    {
        int[,] board = new int[7, 7]; //To Hold a 34 Triangle Game Board where triangle lengths = 1 Unit & triangle heights = 0.5 Units
        this.myTriangleManager = theTriangleManager;
        this.myDevelopmentManager = theDevelopmentManager;
    }

    public TriangleManager getTriangleManager()
    {
        return myTriangleManager;
    }

    public DevelopmentManager getDevelopmentManager()
    {
        return myDevelopmentManager;
    }
    
    public TriangleManager getTriangles()
    {
        return myTriangleManager.getTriangles();
    }
    public List<SpaceColony> getSpaceColonies()
    {
        return myDevelopmentManager.getSpaceColonies();
    }

    public List<AsteroidBelt> 
}