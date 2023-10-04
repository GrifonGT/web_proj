using NLog;

namespace Main;

public class Exercise4 : IExercise
{
    private const int Threshold = 100;
    private readonly ILogger logger = LogManager.GetCurrentClassLogger();
    public string Condition => "Swap first element with the lowest even one of the array";

    public void Execute()
    {
        logger.Debug("input array size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        if (size <= 0)
        {
            logger.Warn("Empty array");
            return;
        }

        Random random = new Random();

        int[] array = Enumerable.Repeat(0, size)
                .Select(_ => random.Next(Threshold))
                .ToArray();

        logger.Debug($"Generated array: {{{string.Join(", ", array)}}}");

        int lowestPos = 0;
        int lowest = array.First();

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] % 2 == 0 && array[i] < lowest)
            {
                lowestPos = i;
                lowest = array[i];
            }
        }

        array[lowest] = array.FirstOrDefault();
        array[0] = lowest;

        logger.Debug($"Result: {{{string.Join(", ", array)}}}");
    }
}