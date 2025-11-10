using System.Net;

namespace NavigationOfSoltrianius.GameCode.Model;

public record Error(HttpStatusCode theStatusCode, string theErrorType, string theErrorMessage)
{
    public Error None = new(HttpStatusCode.OK, "Error.None", "There are no errors, time to play Navigation of Soltrianius!");
    
    /// <summary>
    /// This ToString() helps to structure the custom error messages overall.
    /// </summary>
    /// <returns>Returns the custom error message whenever an Error is used in any of the backend files.</returns>
    public override string ToString()
    {
        return base.ToString("{theStatusCode}: {theErrorType} - {theErrorMessage}");
    }
}