using Microsoft.AspNetCore.Mvc;

namespace ttdemo.Web.Rest.Utilities {
    public static class ActionResultUtil {
        public static ActionResult WrapOrNotFound(object value)
        {
            return value != null ? (ActionResult) new OkObjectResult(value) : new NotFoundResult();
        }
    }
}
