//The imports
using System.Reflection.Metadata;
using System.Security;
using NavigationOfSoltrianius.GameCode.BoardEnums;
using NavigationOfSoltrianius.GameCode.ErrorChecks;
using NavigationOfSoltrianius.GameCode.ManagerClasses;

namespace NavigationOfSoltrianius.GameCode;

public class Gameplay
{
    //Private Fields
    private Stack<DiceRolls> myDiceRolls = new Stack<DiceRolls>();

    public Gameplay(GameBoard theBoard, StateManager theStateManager, PlayerManager thePlayerManager, Stack<DiceRolls> theDiceRolls)
    {
        this.GameBoard = theBoard;
        this.StateManager = theStateManager;
        this.PlayerManager = thePlayerManager;
        this.DiceRolls = theDiceRolls;
    }

    public GameBoard getGameBoard()
    {
        GameBoard board = new GameBoard();
        return board;
    }

    public StateManager getStateManager()
    {
        StateManager stateManager = new StateManager();
        return stateManager;
    }

    public PlayerManager getPlayerManager()
    {
        PlayerManager playerManager = new PlayerManager();
        return playerManager;
    }

    public Stack<DiceRolls> getDiceRolls()
    {
        Stack<DiceRolls> diceRolls = new Stack<DiceRolls>();
        return diceRolls;
    }

    public Player CurrentPlayer()
    {
        return PlayerManager.CurrentPlayer;
    }

    public PlayerColor CurrentPlayerColor()
    {
        return PlayerManager.CurrentPlayerColor;
    }

    public bool isGameSetup()
    {
        return PlayerManager.isGameSetup;
    }

    public Result MoveState(ActionType theAction)
    {
        return StateManager.MoveState(theAction);
    }

    public Result BuySpaceColony()
    {
        return PurchaseHelper.BuyTown(CurrentPlayer);
    }
    
    
}