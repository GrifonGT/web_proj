using NLog;

namespace Main;

public class Exercise5 : IExercise
{
    private const int Threshold = 100;
    private readonly ILogger logger = LogManager.GetCurrentClassLogger();
    public string Condition => "Swap max and min element of the each even row";

    public void Execute()
    {
        logger.Debug("input column count: ");
        int column = Convert.ToInt32(Console.ReadLine());

        logger.Debug("input row count: ");
        int row = Convert.ToInt32(Console.ReadLine());

        if (column <= 0 || row <= 0)
        {
            logger.Warn("Empty matrix");
            return;
        }

        Random random = new();

        var matrix = Enumerable
                .Repeat(Array.Empty<int>(), row)
                        .Select(e => Enumerable.Repeat(0, column)
                                .Select(_ => random.Next(Threshold))
                                .ToArray())
                        .ToArray();

        foreach (int[] line in matrix)
        {
            logger.Debug($"{{{string.Join(", ", line)}}}");
        }

        for (int i = 1; i < matrix.Length; i += 2)
        {
            int maxPos = 0;
            int minPos = 0;

            for (int j = 1; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] > matrix[i][maxPos])
                {
                    maxPos = j;
                }

                if (matrix[i][j] < matrix[i][minPos])
                {
                    minPos = j;
                }
            }

            int k = matrix[i][maxPos];
            matrix[i][maxPos] = matrix[i][minPos];
            matrix[i][minPos] = k;
        }

        logger.Debug("---------------------------------");

        foreach (int[] line in matrix)
        {
            logger.Debug($"{{{string.Join(", ", line)}}}");
        }
    }
}