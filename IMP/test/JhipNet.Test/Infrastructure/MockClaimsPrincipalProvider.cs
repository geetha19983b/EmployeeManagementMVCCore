using System.Security.Claims;

namespace com.imp.net.Test.Setup {
    public class MockClaimsPrincipalProvider {
        public MockClaimsPrincipalProvider(ClaimsPrincipal user)
        {
            User = user;
        }

        public ClaimsPrincipal User { get; }
    }
}
