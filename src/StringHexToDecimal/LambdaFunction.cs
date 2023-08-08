using Nethereum.Web3;
using Amazon.Lambda.Core;
using Nethereum.Hex.HexTypes;
using StringHexToDecimal.Models;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace StringHexToDecimal;

public static class LambdaFunction
{
    public static OutputData[] Run(InputData[] input) =>
        input.Select(i => new OutputData
        {
            Name = i.Name,
            Value = Web3.Convert.FromWei(new HexBigInteger(i.Hexadecimal).Value, i.Decimals)
        }).ToArray();
}