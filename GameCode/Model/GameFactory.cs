using NavigationOfSoltrianius.GameCode;

namespace NavigationOfSoltrianius.GameCode;

internal class GameFactory
{
    public Gameplay CreateGame()
    {
        var gameOptions = new OptionsGameFactory();
        var startingGame = new Gameplay(gameOptions.PlayerTotal);
    }
}