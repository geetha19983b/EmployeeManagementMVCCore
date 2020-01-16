using System.Security.Authentication;

namespace ttdemo.Security {
    public class UsernameNotFoundException : AuthenticationException {
        public UsernameNotFoundException(string message) : base(message)
        {
        }
    }
}
