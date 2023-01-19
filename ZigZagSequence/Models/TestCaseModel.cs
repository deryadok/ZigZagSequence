using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagSequence.Models
{
    internal class TestCaseModel
    {
        public int CaseNumber { get; set; }

        public List<TestCase> TestCases { get; set; } = new List<TestCase>();
    }
}
