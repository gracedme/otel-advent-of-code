using Instrumentation;

namespace AdventOfCode;

public class InputReader
{
    public static IEnumerable<string> Strings(string twoDigitDay, bool useExample = false, bool tests = false)
    {
        using var span = OTel.StartActiveSpan("read file");
        span.SetAttribute("input.data_type", "strings");

        var lines = GetLines(twoDigitDay, useExample, tests);
        span.SetAttribute("input.line_count", lines.Count());

        var values = Enumerable.Empty<string>();
        foreach (string line in lines)
            values = values.Append(line);
        
        return values;
    }

    public static IEnumerable<int> Integers(string twoDigitDay, bool useExample = false, bool tests = false)
    {
        using var span = OTel.StartActiveSpan("read file");
        span.SetAttribute("input.data_type", "integers");

        var lines = GetLines(twoDigitDay, useExample, tests);
        span.SetAttribute("input.line_count", lines.Count());

        var values = Enumerable.Empty<int>();
        foreach (string line in lines)
            values = values.Append(Int32.Parse(line));

        return values;
    }

    private static IEnumerable<string> GetLines(string twoDigitDay, bool useExample = false, bool tests = false)
    {
        var actual   = $"/input/2022/day{twoDigitDay}-actual.txt";
        var example  = $"/input/2022/day{twoDigitDay}-example.txt";
        var path     = System.IO.Directory.GetCurrentDirectory();
        var fileName = useExample ? $"{path}/{example}" : $"{path}/{actual}";
        
        if (tests)
        {
            var split = "otel-advent-of-code";
            actual = $"input\\2022\\day{twoDigitDay}-actual.txt";
            example = $"input\\2022\\day{twoDigitDay}-example.txt";
            path = path.Split(split)[0];
            fileName = useExample ? $"{path}\\{split}\\{example}" : $"{path}\\{split}\\{actual}";
        }

        var lines = System.IO.File.ReadLines($"{fileName}");

        return lines;
    }

    
}