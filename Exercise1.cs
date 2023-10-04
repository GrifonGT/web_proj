using NLog;

namespace Main;

public class Exercise1 : IExercise
{
    private readonly ILogger logger = LogManager.GetCurrentClassLogger();

    public string Condition => "Calculate '(h(s^2, t^2) + h^2(s + t, 1)) (1 + h^2(s * t, 2))'";

    public void Execute()
    {
        logger.Debug("Input S: ");
        double s = Convert.ToDouble(Console.ReadLine());

        logger.Debug("Input T: ");
        double t = Convert.ToDouble(Console.ReadLine());

        double result = (HFunction(s * s, t * t) + Math.Pow(HFunction(s + t, 1), 2))
                / (1 + Math.Pow(HFunction(s * t, 2), 2));

        logger.Debug($"Result: {result}");
    }

    private double HFunction(double x, double y)
    {
        return x * y / (1 + x * x * y * y);
    }
}