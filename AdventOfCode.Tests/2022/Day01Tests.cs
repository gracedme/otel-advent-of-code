using Xunit;

namespace AdventOfCode.Tests;

public class Day01Tests
{
    [Fact]
    public void PartAExample()
        => Assert.Equal(24000, Day01_2022.PartA(useExample: true, tests: true));
    
    [Fact]
    public void PartAForRealsies()
        => Assert.Equal(68923, Day01_2022.PartA(useExample: false, tests: true));
}
