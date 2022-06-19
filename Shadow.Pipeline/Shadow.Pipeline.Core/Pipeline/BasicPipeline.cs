using Shadow.Pipeline.Core.PipelineStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.Pipeline
{
    public class BasicPipeline : Pipeline<int, float>
    {
        public BasicPipeline()
        {
            PipelineSteps = input => input
                .Step(new DoubleStep())
                .Step(new ToStringStep())
                .Step(new DuplicateStep())
                .Step(new ToFloatStep());
        }
    }
}
