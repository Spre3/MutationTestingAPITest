namespace TestIllegalChars.Controllers
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Results;

    public class BaseApiController : ApiController
    {
        protected ResponseMessageResult CreatedWithWarnings()
        {
            var newResponse = Request.CreateResponse(
                   HttpStatusCode.Created,
                   new
                   {
                       a = ""
                   });

            return new ResponseMessageResult(newResponse);
        }



    }
}