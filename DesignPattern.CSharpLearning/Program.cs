using System;
<<<<<<< HEAD
using System.Threading.Tasks;

namespace DesignPattern.Singleton
=======

namespace DesignPattern.CSharpLearning
>>>>>>> origin/master
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
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
=======
            Console.WriteLine("Hello World!");
        }
>>>>>>> origin/master
    }
}
