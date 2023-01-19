using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigZagSequence.Models;

namespace ZigZagSequence.Helpers
{
    internal static class FileHelper
    {
        private readonly static string _solutionPath = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName;
        public static TestCaseModel ReadTestCases()
        {
            string path = $@"{_solutionPath}\TestCases\TestCase2.txt";
            TestCaseModel testCaseModel = new TestCaseModel();

            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                int caseNumber = 0;
                if (int.TryParse(reader.ReadLine(), out caseNumber))
                {
                    testCaseModel.CaseNumber = caseNumber;

                    while (!reader.EndOfStream)
                    {
                        testCaseModel.TestCases.Add(new TestCase()
                        {
                            LenghtOfArray = reader.ReadLine(),
                            CaseArray = reader.ReadLine()
                        });
                    }
                }
            }
            return testCaseModel;
        }

        public static void WriteTestOutput(List<string> outputs)
        {
            string path = $@"{_solutionPath}\Output\TestOutput.txt";
            using (StreamWriter writer = File.CreateText(path))
            {
                foreach (string item in outputs)
                {
                    if (item is not @"/n")
                        writer.Write(item + " ");
                    else
                        writer.WriteLine();
                }

            }
        }
    }
}
