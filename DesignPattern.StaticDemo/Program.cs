using static System.Console;

namespace DesignPattern.StaticDemo
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Customer(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        static Customer()
        {

        }
    }
    public static class Converter
    {
        static string Name;
        static Converter()
        {

        }
        public static double ToFahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }
        public static double ToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double celcius = 37; double fahrenheit = 98.6;
            WriteLine("Value of {0} celcius to fahrenheit is {1}",
                celcius, Converter.ToFahrenheit(celcius));
            WriteLine("Value of {0} fahrenheit to celcius is {1}",
                fahrenheit, Converter.ToCelcius(fahrenheit));
            ReadLine();
        }
    }
}
