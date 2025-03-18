namespace ConsoleApp1.Coupling
{
  public class Order
  {
     private readonly INotificationService notificationService;

    public Order(INotificationService notificationService)
    {
      this.notificationService = notificationService;
    }

    public void PlaceOrder()
    {
      // Place order logic
      // ...

      // EmailSender emailSender  =  new EmailSender();
      // emailSender.SendNotification("Order placed Successfully");

      // Send email notification
     notificationService.SendNotification("Order placed successfully");
    }
  }
}