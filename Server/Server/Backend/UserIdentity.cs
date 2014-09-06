using System.Collections.Generic;
using Nancy.Security;

namespace Backend
{
    public class UserIdentity : IUserIdentity
    {
        public IEnumerable<string> Claims { get; set; }
        public string UserName { get; set; }
    }
}