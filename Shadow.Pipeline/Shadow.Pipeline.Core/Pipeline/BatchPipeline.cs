using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core.Pipeline
{
    public abstract class BatchPipeline<INPUT, OUTPUT, P> : Pipeline<INPUT[], OUTPUT[]>
        where P : Pipeline<INPUT, OUTPUT>
    {
        protected P _child;

        public BatchPipeline(P child)
        {
            _child = child;
        }

        public override OUTPUT[] Process(INPUT[] input)
        {
            var result = new List<OUTPUT>();
            foreach (var item in input)
            {
                result.Add(_child.Process(item));
            }
            return result.ToArray();
        }
    }
}
