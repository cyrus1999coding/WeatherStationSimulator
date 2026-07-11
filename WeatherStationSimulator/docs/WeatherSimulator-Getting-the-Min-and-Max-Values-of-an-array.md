# WeatherSimulator - Getting the Min and Max Values of an array

We're going to get the Maximum temprature ouf of our array .

```cs
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
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
            Console.WriteLine($"AVARAGE TEMPRATURE IS: {CalculateAverageTemperature(temprature)}");
            Console.WriteLine($"The Max temprature was: {temprature.Max()}");
            Console.WriteLine($"The Min temprature: {temprature.Max()}");

            Console.ReadKey();
        }
```

```console
Enter the number of days to simulate:
15
AVARAGE TEMPRATURE IS: 18
The Max temprature was: 37
The Min temprature: 3
 
```

- `temprature.Max()`
- `temprature.Min()`

That's it, However we want to show how we can get them bu using our own Methods .


```cs
        static int MinTemprature(int[] temperaturesArray) 
        {
            int min = temperaturesArray[0];

            foreach (int temp in temperaturesArray)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }

            return min;

        }
```

And we can use that :


```cs
namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
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
            Console.WriteLine($"AVARAGE TEMPRATURE IS: {CalculateAverageTemperature(temprature)}");
            Console.WriteLine($"The Max temprature was: {temprature.Max()}");
            Console.WriteLine($"The Min temprature: {temprature.Min()}");
            Console.WriteLine($"The Min temprature: {MinTemprature(temprature)}"); 👈

            Console.ReadKey();
        }

        /// <summary>
        /// Calculates the average temperature from an array of temperatures.
        /// </summary>
        /// <param name="tempraturesArray">An array containing the temperature values.</param>
        /// <returns> The average temperature as a double. </returns>
        static double CalculateAverageTemperature(int[] temperaturesArray)
        {
            //int sum = 0;
            double sum = 0;
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


        /// <summary>
        /// Getting an Array of Integers And return the Minimum value 
        /// </summary>
        /// <param name="temperaturesArray"> an Integers Array</param>
        /// <returns>Minimum value of an Array</returns>
        static int MinTemprature(int[] temperaturesArray) 
        {
            int min = temperaturesArray[0];

            foreach (int temp in temperaturesArray)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }

            return min;

        }
    }
}

```

```console
Enter the number of days to simulate:
10
AVARAGE TEMPRATURE IS: 14
The Max temprature was: 35
The Min temprature: -10
The Min temprature: -10 👈
```