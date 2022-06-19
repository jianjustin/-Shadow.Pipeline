using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.PipelineStep
{
    public class ThirdStep : IPipelineStep<int, float>
    {
        public float Process(int input)
        {
            return input / 3f;
        }
    }
}
