using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core
{
    public class OptionalStep<INPUT, OUTPUT> : IPipelineStep<INPUT, OUTPUT> where INPUT : OUTPUT
    {
        private IPipelineStep<INPUT, OUTPUT> _step;
        private Func<INPUT, bool> _choice;

        public OptionalStep(Func<INPUT, bool> choice, IPipelineStep<INPUT, OUTPUT> step)
        {
            _choice = choice;
            _step = step;
        }

        public OUTPUT Process(INPUT input)
        {
            if (_choice(input))
            {
                return _step.Process(input);
            }
            else
            {
                return input;
            }
        }
    }

}
