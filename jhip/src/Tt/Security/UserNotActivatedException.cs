using System.Security.Authentication;

namespace ttdemo.Security {
    public class UserNotActivatedException : AuthenticationException {
        public UserNotActivatedException(string message) : base(message)
        {
        }
    }
}
