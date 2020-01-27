using System.Security.Authentication;

namespace com.imp.net.Security {
    public class UsernameNotFoundException : AuthenticationException {
        public UsernameNotFoundException(string message) : base(message)
        {
        }
    }
}
