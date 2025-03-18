using System;
using System.Collections.Generic;

// namespace GoogleCloud{

//     class Program{

//         static void Main(string[] args){

//             List<VirtualMachine> vms = new List<VirtualMachine>{
//                 new ComputeOptimized(),
//                 new GeneralPurposeVM()
//             };
//             Console.WriteLine(vms);

//             foreach(var vm in vms){
//                 vm.Start();
//                 Console.WriteLine($"Cost for {vm.MachineType} is {vm.CalculateCost(24)}");
//                 Console.WriteLine($"{vm.MachineType} VM Cost for 10 hours (with discount): ${vm.CalculateCost(10, true)}");
//                 Console.WriteLine("-----------------------------------------");

//             }

//             Console.WriteLine("Restarting Manageable VMs");
//             foreach(var vm in vms){
//                 if(vm is IManageable){
//                     IManageable manageableVM = (IManageable)vm;
//                     manageableVM.Restart();
//                 }
//             }
//         }
//     }
// }

// namespace BankingServices{

//     class Program{

//         static void Main(string[] args){

//             ILogger logger = new ConsoleLogger();
//             IAuthentication authenticator = new BasicAuthenticator();
//             IDataSaver dataSaver = new SQLDatabase();
//             IBankAccount account = new SavingsAccount(logger);
//             BankService bankService = new BankService(account,authenticator,dataSaver);

//             bankService.PerformTransaction("user1", "password", 100, true);
//             bankService.PerformTransaction("user1", "password", 50, false);


//         }
//     }
// }


namespace RoomBooking_SOLID_Examples{

    class Program{

        static void Main(string[] args){
            IAuthentication authenticator = new BasicAuthenticator();;
            INotification notifier = new EmailNotification();
            IDataSaver dataSaver = new SQLDatabase();

            IRoomBooking roomBooking = new StandardRoom();
            IPaymentProcessor paymentProcessor = new PayPalPayment();

            HotelService hotelService = new HotelService(roomBooking, paymentProcessor, authenticator, dataSaver, notifier);

            hotelService.BookRoom("user1", "password", 1, 100);
        }
    }
}