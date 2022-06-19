using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core
{
    public static class PipelineStepExtensions
    {
        public static OUTPUT Step<INPUT, OUTPUT>(this INPUT input, IPipelineStep<INPUT, OUTPUT> step)
        {
            return step.Process(input);
        }

        public static OUTPUT Step<INPUT, OUTPUT>(this INPUT input, IPipelineStep<INPUT, OUTPUT> step, Action<INPUT> inputEvent = null, Action<OUTPUT> outputEvent = null)
        {
            if (inputEvent != null || outputEvent != null)
            {
                var eventDecorator = new EventStep<INPUT, OUTPUT>(step);
                eventDecorator.OnInput += inputEvent;
                eventDecorator.OnOutput += outputEvent;

                return eventDecorator.Process(input);
            }

            return step.Process(input);
        }
    }
}
