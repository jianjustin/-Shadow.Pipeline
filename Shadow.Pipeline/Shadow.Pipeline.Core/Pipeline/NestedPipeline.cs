using Shadow.Pipeline.Core.PipelineStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.Pipeline
{
    public class NestedPipeline : Pipeline<int, string>
    {
        public NestedPipeline()
        {
            PipelineSteps = input => input
            .Step(new DoubleStep())
            .Step(new InnerPipeline())
            .Step(new ToStringStep());
        }
    }
}
