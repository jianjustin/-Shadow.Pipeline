using Shadow.Pipeline.Core.PipelineStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.Pipeline
{
    public class InnerPipeline : Pipeline<int, int>
    {
        public InnerPipeline()
        {
            PipelineSteps = input => input
                .Step(new ThirdStep())
                .Step(new RoundStep());
        }
    }

}
