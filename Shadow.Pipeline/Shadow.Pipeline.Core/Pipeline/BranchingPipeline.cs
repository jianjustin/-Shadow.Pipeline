using Shadow.Pipeline.Core.PipelineStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.Pipeline
{
    public class BranchingPipeline : Pipeline<int, string>
    {
        public BranchingPipeline()
        {
            PipelineSteps = input => input
            .Step(new OptionalStep<int, int>(
                    f => f > 50,
                    new InnerPipeline()
                ))
            .Step(new ChoiceStep<int, int>(
                    f => f > 100,
                    new HalfStep(),
                    new DoubleStep()
                ))
            .Step(new ToStringStep());
        }
    }
}
