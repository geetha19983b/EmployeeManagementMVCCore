using Microsoft.AspNetCore.Mvc;

namespace com.imp.net.Web.Rest.Utilities {
    public static class ActionResultUtil {
        public static ActionResult WrapOrNotFound(object value)
        {
            return value != null ? (ActionResult) new OkObjectResult(value) : new NotFoundResult();
        }
    }
}
