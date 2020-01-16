using ttdemo.Data;
using ttdemo.Models;
using ttdemo.Test.Setup;

namespace ttdemo.Test {
    public static class Fixme {
        public static User ReloadUser<TEntryPoint>(NhipsterWebApplicationFactory<TEntryPoint> factory, User user)
            where TEntryPoint : class
        {
            var applicationDatabaseContext = factory.GetRequiredService<ApplicationDatabaseContext>();
            applicationDatabaseContext.Entry(user).Reload();
            return user;
        }
    }
}
