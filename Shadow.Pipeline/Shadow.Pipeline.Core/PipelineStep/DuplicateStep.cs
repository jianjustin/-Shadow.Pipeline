using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.PipelineStep
{
    public class DuplicateStep : IPipelineStep<string, string>
    {
        public string Process(string input)
        {
            return input + "." + input;
        }
    }
}
