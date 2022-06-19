using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shadow.Pipeline.Core.Pipeline;
using System;

namespace Shadow.Pipeline.Core.Tests
{
    [TestClass]
    public class PipelineTests
    {
        [TestMethod]
        public void BranchingPipeline_Test()
        {
            foreach (int input in new int[] { 1, 10, 100, 1000 })
            {
                var pipeline = new BranchingPipeline();
                var output = pipeline.Process(input);
            }
        }

        [TestMethod]
        public void BasicPipelineTest()
        {
            var input = 49;
            var pipeline = new BasicPipeline();
            var output = pipeline.Process(input);
        }

        [TestMethod]
        public void NestedPipelineTest()
        {
            var input = 103;
            var pipeline = new NestedPipeline();
            var output = pipeline.Process(input);
        }
    }
}
