# StringHexToDecimal

[![.NET](https://github.com/The-Poolz/StringHexToDecimal/actions/workflows/dotnet.yml/badge.svg)](https://github.com/The-Poolz/StringHexToDecimal/actions/workflows/dotnet.yml)
[![CodeFactor](https://www.codefactor.io/repository/github/the-poolz/stringhextodecimal/badge)](https://www.codefactor.io/repository/github/the-poolz/stringhextodecimal)

StringHexToDecimal is a simple AWS Lambda function written in C# that converts hexadecimal numbers to decimal format.
This Lambda function uses the `Nethereum.Web3` library for the conversion and is intended for simple use-cases like Ethereum-related calculations.

## How to Use
The function takes an array of `InputData` objects and returns an array of `OutputData` objects.

## Input
The `InputData` object has the following properties:

- `Decimals`: Number of decimal places to consider for conversion. Default is 18.
- `Name`: The name identifier for the hexadecimal string.
- `Hexadecimal`: The hexadecimal number that needs to be converted.

## Output
The `OutputData` object has the following properties:

- `Name`: The name identifier carried over from InputData.
- `Value`: The converted decimal value.

## Example

### Input:
```json
[
  {
    "Decimals": 18,
    "Name": "Value1",
    "Hexadecimal": "0x4a817c800"
  },
  {
    "Decimals": 18,
    "Name": "Value2",
    "Hexadecimal": "0x2b5e3af16b1880000"
  }
]
```

### Output:
```json
[
  {
    "Name": "Value1",
    "Value": 20.000000000000000000
  },
  {
    "Name": "Value2",
    "Value": 50000.000000000000000000
  }
]
```
