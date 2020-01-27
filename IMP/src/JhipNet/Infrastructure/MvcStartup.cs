using JHipsterNet.Pagination.Binders;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace com.imp.net.Infrastructure {
    public static class WebConfiguration {
        public static IServiceCollection AddWebModule(this IServiceCollection @this)
        {
            @this.AddHttpContextAccessor();

            @this.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/health-checks?view=aspnetcore-2.2
            @this.AddHealthChecks();

            //TODO use AddMvcCore + config
            @this.AddMvc(options => { options.ModelBinderProviders.Insert(0, new PageableBinderProvider()); })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => {
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                });

            return @this;
        }

        public static IApplicationBuilder UseApplicationWeb(this IApplicationBuilder @this, IHostingEnvironment env)
        {
            @this.UseDefaultFiles();
            @this.UseStaticFiles();

            @this.UseMvc();

            @this.UseHealthChecks("/health");

            return @this;
        }
    }
}
