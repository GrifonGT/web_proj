using NLog;

namespace Main;

public class Exercise2 : IExercise
{
    private readonly ILogger logger = LogManager.GetCurrentClassLogger();

    string IExercise.Condition => "Return value based on `C` and `B` params";

    void IExercise.Execute()
    {
        logger.Debug("Input a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        logger.Debug("Input b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        logger.Debug("Input c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        logger.Debug("Input x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double result;

        if (c < 0 && b != 0)
        {
            result = a * x * x + b * b * x;
        }
        else if (c > 0 && b == 0)
        {
            result = (x + a) / (x + c);
        }
        else
        {
            result = x / c;
        }

        logger.Debug($"Result: {result}");
    }
}