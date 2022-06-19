using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.Pipeline
{
    public class BatchBranchingPipeline : BatchPipelineStep<int, string, BranchingPipeline>
    {
        public BatchBranchingPipeline(BranchingPipeline child) : base(child)
        {
            _child = child;
        }
    }
}
