using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core
{
    public class ChoiceStep<INPUT, OUTPUT> : IPipelineStep<INPUT, OUTPUT> where INPUT : OUTPUT
    {
        private IPipelineStep<INPUT, OUTPUT> _first;
        private IPipelineStep<INPUT, OUTPUT> _second;
        private Func<INPUT, bool> _choice;

        public ChoiceStep(Func<INPUT, bool> choice, IPipelineStep<INPUT, OUTPUT> first, IPipelineStep<INPUT, OUTPUT> second)
        {
            _choice = choice;
            _first = first;
            _second = second;
        }

        public OUTPUT Process(INPUT input)
        {
            if (_choice(input))
            {
                return _first.Process(input);
            }
            else
            {
                return _second.Process(input);
            }
        }
    }
}
