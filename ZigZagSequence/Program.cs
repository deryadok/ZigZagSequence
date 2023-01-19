using System;
using ZigZagSequence.Helpers;
using ZigZagSequence.Models;

TestCaseModel model = FileHelper.ReadTestCases();
List<int> result = new List<int>();
List<string> output = new List<string>();

for (int i = 0; i < model.CaseNumber; i++)
{
    foreach (TestCase item in model.TestCases)
    {
        result = Helper.Calculate(item);
    }

    output.AddRange(Helper.ConvertList(result));
}

FileHelper.WriteTestOutput(output);