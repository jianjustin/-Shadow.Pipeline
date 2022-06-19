using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.PipelineStep
{
    public class HalfStep : IPipelineStep<int, int>
    {
        public int Process(int input)
        {
            return input / 2;
        }
    }
}
