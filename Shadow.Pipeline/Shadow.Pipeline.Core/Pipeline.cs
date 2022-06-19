using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core
{
    public abstract class Pipeline<INPUT, OUTPUT> : IPipelineStep<INPUT, OUTPUT>
    {
        public Func<INPUT, OUTPUT> PipelineSteps { get; protected set; }

        public virtual OUTPUT Process(INPUT input)
        {
            return PipelineSteps(input);
        }
    }

}
