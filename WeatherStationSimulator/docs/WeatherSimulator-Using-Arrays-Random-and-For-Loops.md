# WeatherSimulator - Using Arrays, Random, and For Loops

We're going to use :
- `Arrays`
- `Random`
- `For Loops`
- `Methods`
- checking highest value inside of an array
- Comparing strings to each other 


```cs
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of dats to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temprature = new int[days]; 👈
             
            Console.WriteLine("Hello, World!");
        }
    }
```
- `int[] temprature = new int[days];` :
  depends on how many we enter .


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

            Console.WriteLine("Hello, World!");
        }
    }
}

```
- `string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy"};` :  
  Holds different conditions that we can have .

- `string[] weatherConditions = new string[days];` :  
  Hoolds actual conditions for different days .  
  👀 ) Monday → Sunny , tuesday → Rainy 

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

            Console.WriteLine("Hello, World!");
        }
    }
}

```

- `weatherConditions[i] = conditions[random.Next(conditions.Length)];` :  
  ✅ get me random value out of however many conditions you have .  
  🔴 we could do `.Next(0,4)` too,  It's not future proof 

Next we're going to display avarage, highest and lowset temprature and the most common condition .