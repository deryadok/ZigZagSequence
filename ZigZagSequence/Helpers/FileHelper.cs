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

            StreamReader reader = new StreamReader(path, Encoding.UTF8);
            int caseNumber = 0;

            if (int.TryParse(reader.ReadLine(), out caseNumber))
            {
                testCaseModel.CaseNumber = caseNumber;

                while (reader.Peek() > 0)
                {
                    testCaseModel.TestCases.Add(new TestCase()
                    {
                        LenghtOfArray = reader.ReadLine(),
                        CaseArray = reader.ReadLine()
                    });
                }
            }
            reader.Close();
            return testCaseModel;
        }

        public static void WriteTestOutput(string output)
        {
            string path = $@"{_solutionPath}\Output\TestOutput.txt";

            File.AppendAllText(path, output, Encoding.UTF8);
            File.AppendAllText(path, "\r\n", Encoding.UTF8);
            Console.WriteLine(output);
        }
    }
}
