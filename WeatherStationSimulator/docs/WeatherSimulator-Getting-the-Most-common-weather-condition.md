# WeatherSimulator - Getting the Most common weather condition

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
            Console.WriteLine($"The Min temprature: {MinTemprature(temprature)}");
            Console.WriteLine($"Most Common condition was: {MostCommonConditions(weatherConditions)}"); 👈

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

        static string MostCommonConditions(string[] condtions) 👈
        {
            int count = 0;
            string mostCommon = condtions[0];

            for (int i = 0; i < condtions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < condtions.Length; j++)
                {
                    if (condtions[j] == condtions[i])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = condtions[i];
                }
            }

            return mostCommon;
        }
    }
}

```

```console
Enter the number of days to simulate:
5
AVARAGE TEMPRATURE IS: 13.8
The Max temprature was: 35
The Min temprature: -5
The Min temprature: -5
Most Common condition was: Cloudy
```