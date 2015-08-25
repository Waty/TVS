using System.ComponentModel;

namespace TVS
{
    /// <summary>
    ///     Event args for the login event
    /// </summary>
    public class LoginEventArgs : CancelEventArgs
    {
        /// <summary>
        ///     Construct the event args with the specified username and password
        /// </summary>
        /// <param name="username">The username to login</param>
        /// <param name="password">The password to login</param>
        public LoginEventArgs(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        ///     The Username the class was constructed with
        /// </summary>
        public string Username { get; }

        /// <summary>
        ///     The password the class was constructed with
        /// </summary>
        public string Password { get; }
    }
}