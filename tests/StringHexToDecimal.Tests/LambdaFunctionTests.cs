using Xunit;
using FluentAssertions;
using StringHexToDecimal.Models;

namespace StringHexToDecimal.Tests;

public class LambdaFunctionTests
{
    [Fact]
    public void Run()
    {
        var input = new InputData[]
        {
            new()
            {
                Hexadecimal = 123456789.ToString("X"),
                Name = "Value1"
            },
            new()
            {
                Decimals = 0,
                Hexadecimal = 123456789.ToString("X"),
                Name = "Value2"
            }
        };

        var result = LambdaFunction.Run(input);

        result[0].Should().BeEquivalentTo(new OutputData
        {
            Name = "Value1",
            Value = 0.000000000123456789m
        });
        result[1].Should().BeEquivalentTo(new OutputData
        {
            Name = "Value2",
            Value = 123456789
        });
    }
}