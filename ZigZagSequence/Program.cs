using System;
using System.Diagnostics;
using ZigZagSequence.Helpers;
using ZigZagSequence.Models;

TestCaseModel model = FileHelper.ReadTestCases();
List<int> result = new List<int>();
List<string> output = new List<string>();

for (int i = 0; i < model.CaseNumber; i++)
{
    result = Helper.Calculate(model.TestCases[i]);
    FileHelper.WriteTestOutput(Helper.ConvertList(result));
}