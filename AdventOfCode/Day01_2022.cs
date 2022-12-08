using Instrumentation;

namespace AdventOfCode;

public class Day01_2022
{
    private static string TWO_DIGIT_DAY = "01";

    public static int PartA(bool useExample = false, bool tests = false)
    {
        var lines = InputReader.Strings(TWO_DIGIT_DAY, useExample, tests);

        var runningTotalCalories = 0;
        var mostCalories = 0;
        foreach (string line in lines)
        {
            using var span = OTel.StartActiveSpan("read one line");
            if (!String.IsNullOrEmpty(line) && !String.IsNullOrWhiteSpace(line))
            {
                runningTotalCalories += Int32.Parse(line);
            }
            else
            {
                if (runningTotalCalories > mostCalories)
                {
                    mostCalories = runningTotalCalories;
                }
                span.SetAttribute("calories.running_total", runningTotalCalories)
                    .SetAttribute("calories.highest", mostCalories);
                runningTotalCalories = 0;
            }
        }

        return mostCalories;
    }
}