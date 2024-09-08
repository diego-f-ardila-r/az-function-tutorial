
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace az_function_tutorial.Function
{
    public static class MessageProcessor
    {
        [FunctionName("MessageProcessor")]
        public static void Run([QueueTrigger("message-queue", Connection = "AzureWebJobsStorage")] string myQueueItem, ILogger log)
        {
            // Send an email
            // validate
            // alert someone
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
