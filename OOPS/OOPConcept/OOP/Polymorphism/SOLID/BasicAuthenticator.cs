namespace BankingServices
{
 public class BasicAuthenticator:IAuthentication{

    public bool Authenticate(string username, string password)
    {
   Console.WriteLine("Authenticating user with basic authentication");
            return true;
      
    }
 }
}