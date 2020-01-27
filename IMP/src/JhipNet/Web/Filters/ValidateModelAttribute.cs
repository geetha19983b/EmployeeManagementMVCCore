using com.imp.net.Web.Rest.Problems;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace com.imp.net.Web.Filters {
    public class ValidateModelAttribute : ActionFilterAttribute {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
                context.Result = new BadRequestObjectResult(new ValidationFailedProblem(context.ModelState));
        }
    }
}
