# WeatherSimulator - Calculating the Average Temperature

We're going to create an extra Method for that .

```cs
namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of dats to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temprature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy"};
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temprature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            //double avarateTemp = CalculateAverageTemperature(temprature);
            //Console.WriteLine(avarateTemp);
            Console.WriteLine($"{CalculateAverageTemperature(temprature)}");
        }

        /// <summary>
        /// Calculates the average temperature from an array of temperatures.
        /// </summary>
        /// <param name="tempraturesArray">An array containing the temperature values.</param>
        /// <returns> The average temperature as an double. </returns>
        static double CalculateAverageTemperature(int[] temperaturesArray)
        {
            int sum = 0;
            for (int i = 0; i < temperaturesArray.Length; i++)
            {
                sum += temperaturesArray[i];
            }

            //foreach (int i in temperaturesArray)
            //{
            //    sum += i
            //}

            double avarageTemprature = sum / temperaturesArray.Length;

            return avarageTemprature;
        }
    }
}

```

```console
Enter the number of days to simulate:
7
AVARAGE TEMPRATURE IS: 13
```

- this `CalculateAverageTemperature` now will calculate the avarage of the values of an iteger array .

- 🔑 `We can use Methods directly inside of a string` .

- 🔑 See how we used this `CalculateAverageTemperature` which outside of the `Main` Method inside of it .

- We get differnet values each time .

🔑 If we devide an `integer` by an `integer` we're going to get an integer result so even thought we store it inside of a `double` ↓  

```cs
 static double CalculateAverageTemperature(int[] temperaturesArray)
        {
            int sum = 0;
            for (int i = 0; i < temperaturesArray.Length; i++)
            {
                sum += temperaturesArray[i];
            }

            //foreach (int i in temperaturesArray)
            //{
            //    sum += i
            //}

            double avarageTemprature = sum / temperaturesArray.Length;

            return avarageTemprature; 👈
        }
```
- 🛠✅ is instead of `int sum = 0;` we can have `double sum = 0;`