using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApp1.src.Oop.Abstraction{
class EmailService
{
  public void sendEmail()
  {
    connect();
    authenticate();
    disconnect();
    System.Console.WriteLine("Sending email...");
  }

  // ALL THE BELOW METHODS ARE PRIVATE -- THEY ARE NOT EXPOSED TO OTHER CLASSES. OTHER CLASSES JUST WANT TO SEND EMAILS, NO NEED FOR THEM TO SEE ALL THE COMPLEX DETAILS OF CONNECTING TO MAIL SERVER, AUTHENTICATING, DISCONNECTING.

  private void connect()
  {
    System.Console.WriteLine("Connecting to email server...");
  }

  private void authenticate()
  {
    System.Console.WriteLine("Authenticating...");
  }

  private void disconnect()
  {
    System.Console.WriteLine("Disconnecting from email server...");
  }
}

}