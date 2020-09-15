using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Api.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : Controller
    {
        [Route("error")]
        public object Error()
        {
            var exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
            var code = HttpContext.Response.StatusCode;
            Response.StatusCode = code;
            return new { status = code, exception = exception };
        }
    }
}