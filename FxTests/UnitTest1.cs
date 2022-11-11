using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.Extensions.Logging.Abstractions;

namespace FxTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestWatchFunctionSuccess()
        {
            var logger = NullLoggerFactory.Instance.CreateLogger("Null Logger");

            var queryStringValue = "abc";
            var request = new DefaultHttpRequest(new DefaultHttpContext())
            {
                Query = new QueryCollection
                (
                    new System.Collections.Generic.Dictionary<string, StringValues>()
                    {
            { "model", queryStringValue }
                    }
                )
            };

            //var response =  WatchPortalFunction.WatchInfo.Run(request, logger);
            //response.Wait();


        }
    }
}