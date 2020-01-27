using com.imp.net.Data;
using com.imp.net.Models;
using com.imp.net.Test.Setup;

namespace com.imp.net.Test {
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
