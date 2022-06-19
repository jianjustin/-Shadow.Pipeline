using Shadow.Pipeline.Core.PipelineStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.Pipeline
{
    public class EventPipeline : Pipeline<int, float>
    {
        public EventPipeline()
        {
            PipelineSteps = PipelineSteps = input => input
                .Step(new DoubleStep(), new Action<int>(p =>
                {
                    p++;
                }));
        }
    }
}
