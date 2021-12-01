using System;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => GetIBMInformation("IBM"),
                () => GetMicrosoftInformation("Microsoft")
                );

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }

        private static void GetMicrosoftInformation(string customerName)
        {
            DatabaseContext ms = DatabaseContext.GetDatabaseContext;
            ms.GetCustomer(customerName);
        }

        private static void GetIBMInformation(string customerName)
        {
            DatabaseContext ibm = DatabaseContext.GetDatabaseContext;
            ibm.GetCustomer(customerName);
        }
    }
}
