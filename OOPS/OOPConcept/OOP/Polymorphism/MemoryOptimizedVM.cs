// namespace GoogleCloud{

// public class MemoryOptimizedVM :VirtualMachine,IManageable{

//     public MemoryOptimizedVM(){

//         MachineType = "Memory Optimized VM";
//         CPU = 4;
//         RAM = 64;
//         BaseCostPerHour = 0.08;
//     }
//         public override double CalculateCost(int hours)
//         {
//               return hours * BaseCostPerHour;
//         }
//         public void Restart(){
//         Console.WriteLine($"{MachineType} is Restarting");
//     }
// }

// }