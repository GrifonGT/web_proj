using NLog;

namespace Main;

public class Exercise6 : IExercise
{
    private readonly string[] phrases = new[] { "SQ", "QS" };
    private readonly ILogger logger = LogManager.GetCurrentClassLogger();
    public string Condition => "Check sequence for `SQ` or `QS` phrase";

    public void Execute()
    {
        logger.Debug("input sequence: ");
        string text = Console.ReadLine() ?? throw new ArgumentException("Empty line");

        logger.Debug($"Result: {(HasPhrases(text, phrases) ? "Contains" : "Doesn't contain")}");
    }

    private bool HasPhrases(string source, string[] phrases)
    {
        return phrases.Any(text => source.Contains(text));
    }
}