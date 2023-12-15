using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
using Stride.Engine;

namespace TestIssue
{
    [ComponentCategory("Test")]
    public class TestA : StartupScript
    {
        public TestB? a { get; set; }
        public TestB? b { get; set; }

    }
}
