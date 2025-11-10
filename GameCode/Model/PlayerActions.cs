using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
using NavigationOfSoltrianius.GameCode;

namespace NavigationOfSoltrianius.GameCode.Model;

public class PlayerActions
{
    public class CreateGame(int thePlayerTotal)
    {
        /*int totalPlayers = thePlayerTotal;
        if (totalPlayers < 3) 
        {
            return Result.Failure(GameErrorCodes.InvalidPlayerTotal);
       */ }
    }

    public class ResponseToCreatingAGame
    {
        public int getGameId()
        {
            return Gameplay.getGameId();
        }
    }