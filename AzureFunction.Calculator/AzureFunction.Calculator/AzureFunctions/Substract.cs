using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace AzureFunction.Calculator
{
    public static class Substract
    {
        [FunctionName("Substract")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]HttpRequestMessage req, TraceWriter log)
        {


            // parse query parameter
            string firstNumber = req.GetQueryNameValuePairs()
                .FirstOrDefault(q => string.Compare(q.Key, "a", true) == 0)
                .Value;
            string secondNumber = req.GetQueryNameValuePairs()
                .FirstOrDefault(q => string.Compare(q.Key, "b", true) == 0)
                .Value;

            if (string.IsNullOrEmpty(firstNumber) || string.IsNullOrEmpty(secondNumber))
                return req.CreateResponse(HttpStatusCode.BadRequest, "Please pass a first number or second parameter on the query string");


            int result = Calculator.Substract(int.Parse(firstNumber), int.Parse(secondNumber));


            return req.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
