namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a temperature in Fahrenheit that you would like to convert to Celcius:");
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine($"{temp} degrees Fahrenheit is {TempConverter.FahrenheitToCelsius(temp)} degrees Celcius.");
            Console.WriteLine();
            Console.WriteLine("Please enter a temperature in Celcius that you would like to convert to Fahrenheit:");
            double temp2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{temp2} degrees Celcius is {TempConverter.CelsiusToFahrenheit(temp2)} degrees Fahrenheit.");
        }
    }
}
