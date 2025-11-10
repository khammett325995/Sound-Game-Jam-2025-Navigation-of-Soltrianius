namespace NavigationOfSoltrianius.GameCode;

public class Result {

    //private fields
    private bool mySuccess = true;
    private Error myError = new Error();
    public Result(bool theSuccess, Error theError)
    {
        this.mySuccess = theSuccess;
        this.myError = theError;
    }

    public bool getSuccess()
    {
        return mySuccess;
    }

    public bool failureAchieved()
    {
        mySuccess = false;
        return mySuccess;
    }

    public Error getError()
    {
        return myError;
    }

    public static Result Success()
    {
        return new Result(true, Error.None);
    }
    
    public static Result Failed()
    {
        return new Result(false, Error.None);
    } 
}