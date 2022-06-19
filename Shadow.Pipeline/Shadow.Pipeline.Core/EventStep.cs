using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core
{
    public class EventStep<INPUT, OUTPUT> : IPipelineStep<INPUT, OUTPUT>
    {
        public event Action<INPUT> OnInput;
        public event Action<OUTPUT> OnOutput;

        private IPipelineStep<INPUT, OUTPUT> _innerStep;

        public EventStep(IPipelineStep<INPUT, OUTPUT> innerStep)
        {
            _innerStep = innerStep;
        }

        public OUTPUT Process(INPUT input)
        {
            OnInput?.Invoke(input);

            var output = _innerStep.Process(input);

            OnOutput?.Invoke(output);

            return output;
        }
    }
}
