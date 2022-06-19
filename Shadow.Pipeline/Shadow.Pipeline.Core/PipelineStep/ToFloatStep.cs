using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.PipelineStep
{
    public class ToFloatStep : IPipelineStep<string, float>
    {
        public float Process(string input)
        {
            return float.Parse(input);
        }
    }
}
