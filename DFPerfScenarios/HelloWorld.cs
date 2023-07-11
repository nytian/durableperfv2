using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;

namespace DFPerfScenarios.DFPerfScenarios
{
    public class HelloWorld
    {
        [FunctionName("HelloWorldOrchestrator")]
        public string HelloWorldOrchestrator(
            [OrchestrationTrigger] IDurableOrchestrationContext ctx)
        {
            var input = ctx.GetInput<dynamic>();
            return $"{input.Hello}, {input.Name}";
        }

        [FunctionName("FailedActivity")]
        public string FailedActivity(
    [ActivityTrigger] IDurableActivityContext ctx)
        {
            return null;
        }
    }
}
