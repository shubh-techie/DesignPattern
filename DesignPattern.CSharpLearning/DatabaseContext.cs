using System;

namespace DesignPattern.Singleton
{
    public sealed class DatabaseContext
    {
        private static int Rating;
        private static readonly Lazy<DatabaseContext> _databaseContext = new Lazy<DatabaseContext>(() => new DatabaseContext());
        public static DatabaseContext GetDatabaseContext
        {
            get
            {
                return _databaseContext.Value;
            }
        }

        private DatabaseContext()
        {
            Rating++;
        }

        public void GetCustomer(string customerName)
        {
            Console.WriteLine($"Customer Name {customerName} and rating :{Rating}");
        }

    }

    public sealed class DatabaseContext1
    {
        private static int Rating;
        private static DatabaseContext1 _databaseContext = null;
        private static readonly object lockObj = new object();
        public static DatabaseContext1 GetDatabaseContext
        {
            get
            {
                if (_databaseContext == null)
                {
                    lock (lockObj)
                    {
                        if (_databaseContext == null)
                            _databaseContext = new DatabaseContext1();
                    }
                }
                return _databaseContext;
            }
        }

        private DatabaseContext1()
        {
            Rating++;
        }

        public void GetCustomer(string customerName)
        {
            Console.WriteLine(customerName + $"Rating is {Rating}");
        }

    }

}
