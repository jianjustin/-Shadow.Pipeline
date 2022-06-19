using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.Pipeline
{
    public abstract class BatchPipelineStep<INPUT, OUTPUT, P> : IPipelineStep<IEnumerable<INPUT>, IEnumerable<OUTPUT>>
        where P : IPipelineStep<INPUT, OUTPUT>
    {
        protected P _child;

        public BatchPipelineStep(P child)
        {
            _child = child;
        }

        public virtual IEnumerable<OUTPUT> Process(IEnumerable<INPUT> input)
        {
            var result = new List<OUTPUT>();
            foreach (var item in input)
            {
                result.Add(_child.Process(item));
            }
            return result;
        }
    }
}
