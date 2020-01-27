using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace com.imp.net.Test.Infrastructure {
    public class TestMvcStartup {
        public static Action<MvcOptions> ConfigureMvcAuthorization()
        {
            return options => { options.Filters.Add(new AllowAnonymousFilter()); };
        }
    }
}
