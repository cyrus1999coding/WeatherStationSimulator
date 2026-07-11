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

            Console.ReadKey();
        }

        /// <summary>
        /// Calculates the average temperature from an array of temperatures.
        /// </summary>
        /// <param name="tempraturesArray">An array containing the temperature values.</param>
        /// <returns> The average temperature as a double. </returns>
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
