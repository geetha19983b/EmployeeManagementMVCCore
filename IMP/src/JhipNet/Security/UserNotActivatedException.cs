using System.Security.Authentication;

namespace com.imp.net.Security {
    public class UserNotActivatedException : AuthenticationException {
        public UserNotActivatedException(string message) : base(message)
        {
        }
    }
}
