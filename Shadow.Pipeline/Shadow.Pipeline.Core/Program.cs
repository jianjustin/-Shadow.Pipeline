using Shadow.Pipeline.Core.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Pipeline.Core
{
    class Program
    {
        private static void BasicPipelineTest()
        {
            Console.WriteLine("Basic Pipeline Test");

            var input = 49;
            Console.WriteLine(string.Format("Input Value: {0} [{1}]", input, input.GetType().Name));

            var pipeline = new BasicPipeline();
            var output = pipeline.Process(input);

            Console.WriteLine(string.Format("Output Value: {0} [{1}]", output, output.GetType().Name));
            Console.WriteLine();
        }

        private static void NestedPipelineTest()
        {
            Console.WriteLine("Nested Pipeline Test");

            var input = 103;
            Console.WriteLine(string.Format("Input Value: {0} [{1}]", input, input.GetType().Name));

            var pipeline = new NestedPipeline();
            var output = pipeline.Process(input);

            Console.WriteLine(string.Format("Output Value: {0} [{1}]", output, output.GetType().Name));
            Console.WriteLine();
        }

        private static void BranchingPipelineTest()
        {
            Console.WriteLine("Branching Pipeline Test");

            foreach (int input in new int[] { 1, 10, 100, 1000 })
            {
                Console.WriteLine(string.Format("Input Value: {0} [{1}]", input, input.GetType().Name));

                var pipeline = new BranchingPipeline();
                var output = pipeline.Process(input);

                Console.WriteLine(string.Format("Output Value: {0} [{1}]", output, output.GetType().Name));
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            BasicPipelineTest();
            NestedPipelineTest();
            BranchingPipelineTest();
        }
    }
}
