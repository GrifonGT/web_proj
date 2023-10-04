using NLog;

namespace Main;

public class Program
{
    private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
    private static readonly IDictionary<int, IExercise> exercises = new Dictionary<int, IExercise>() {
        {1, new Exercise1()},
        {2, new Exercise2()},
        {3, new Exercise3()},
        {4, new Exercise4()},
        {5, new Exercise5()},
        {6, new Exercise6()},
        {7, new Exercise7()},
    };

    public static void Main(string[] args)
    {
        while (true)
        {
            logger.Debug("Input exercise number: ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                IExercise exercise = exercises[number];

                logger.Debug($"Condition: {exercise.Condition}");
                exercise.Execute();
            }
            catch (Exception e)
            {
                logger.Error(e);
            }
        }
    }
}