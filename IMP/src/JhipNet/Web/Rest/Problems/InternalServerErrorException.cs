using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace com.imp.net.Web.Rest.Problems {
    public class InternalServerErrorException : ProblemDetailsException {
        public InternalServerErrorException(string message) : base(new ProblemDetails {
            Type = ErrorConstants.DefaultType,
            Detail = message,
            Status = StatusCodes.Status500InternalServerError
        })
        {
        }
    }
}
