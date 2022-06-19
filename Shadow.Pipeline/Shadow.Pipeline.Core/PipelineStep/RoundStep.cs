using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.PipelineStep
{
    public class RoundStep : IPipelineStep<float, int>
    {
        public int Process(float input)
        {
            return (int)input;
        }
    }
}
