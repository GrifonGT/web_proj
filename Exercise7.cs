using NLog;

namespace Main;

public class Exercise7 : IExercise
{
    private readonly ILogger logger = LogManager.GetCurrentClassLogger();
    public string Condition => "Concat 2 lanes";

    public void Execute()
    {
        logger.Debug("input 2 sequences: ");
        logger.Debug($"Result: {{{Console.ReadLine()}:{Console.ReadLine()}}}");
    }
}