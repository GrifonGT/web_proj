using NLog;

namespace Main;

public class Exercise3 : IExercise
{
    private const int Threshold = 19;

    private readonly ILogger logger = LogManager.GetCurrentClassLogger();
    public string Condition => "Calculate polynom ((k - N) / (k + N) + 1)";

    public void Execute()
    {
        logger.Debug("Input N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int i = n;
        double result = 1;

        while (i <= Threshold)
        {
            result *= Calculate(i, n);
            i++;
        }

        logger.Debug($"While result: {result}");

        i = n;
        result = 1;

        do
        {
            result *= Calculate(i, n);
        } while (++i <= Threshold);

        logger.Debug($"Do-while result: {result}");

        result = 1;

        for (i = n; i <= Threshold; i++)
        {
            result *= Calculate(i, n);
        }

        logger.Debug($"For++ result: {result}");

        result = 1;

        for (i = Threshold; i >= n; i--)
        {
            result *= Calculate(i, n);
        }

        logger.Debug($"For-- result: {result}");
    }

    private double Calculate(int k, int n)
    {
        return (double)(k - n) / (k + n) + 1;
    }
}